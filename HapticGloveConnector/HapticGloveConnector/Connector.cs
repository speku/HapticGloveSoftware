using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Threading;

namespace HapticGloveConnector
{

    public enum Hand
    {
        Right,
        Left
    }

    public enum Finger
    {
        Thumb,
        Index,
        Middle,
        Ring,
        Pinky
    }

    public static class Connector
    {
        private static string mcu = "Adafruit Flora";
        private static SerialPort leftGlove, rightGlove;
        private static List<SerialPort> ports;
        private static byte leftState, rightState;
        private static int baudRate = 9600;

        public static event Action<string> failed;

        static Connector()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort"))
            {
                ports = searcher.Get().Cast<ManagementBaseObject>().Where(mo => mo["Caption"].ToString().Contains(mcu)).Select(mo => new SerialPort(mo["DeviceID"].ToString(), baudRate)).ToList();
            }
            ports.ForEach(port =>
            {
                new Thread(() =>
                    {
                    port.Open();
                    port.Write(new byte[] { 1 }, 0, 1);
                    if (port.ReadByte() == 0)
                    {
                    leftGlove = port;
                    }
                    else
                    {
                    rightGlove = port;
                    }
                    });
            }); // request info about which hand the port represents
        }

        public static bool send(Hand hand, Finger finger, bool vibrate)
        {
            byte outgoing = (hand == Hand.Right ? rightState : leftState);
            byte mask = (byte)(1 << (byte)finger);
            outgoing = (byte)(vibrate ? outgoing | mask : outgoing & ~mask);
            try
            {
                if (hand == Hand.Right)
                {
                    rightState = outgoing;
                    failure(rightGlove);
                    rightGlove?.Write(new byte[] { outgoing }, 0, 1);
                } else
                {
                    leftState = outgoing;
                    failure(leftGlove);
                    leftGlove?.Write(new byte[] { outgoing}, 0, 1);
                }
                return true;
            } catch
            {
                return false;
            }
        }

        private static void failure(SerialPort port)
        {
            if (port == null && failed != null)
            {
                failed("Connection to glove could not be established.");
            }
        }

        public static void Exit()
        {
            ports.ForEach(p => p.Close());
        }







    }
}
