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

       static void Connect()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort"))
            {
                ports = searcher.Get().Cast<ManagementBaseObject>().Where(mo => mo["Caption"].ToString().Contains(mcu)).Select(mo => new SerialPort(mo["DeviceID"].ToString(), baudRate)).ToList();
            }
            ports.ForEach(port =>
            {
                port.Open();
                port.Write(new byte[] { 1 }, 0, 1);
                ThreadPool.QueueUserWorkItem(x =>
                {
                    if ((byte)port.ReadLine().Last() == 1)
                    {
                        rightGlove = port;
                    }
                    else
                    {
                        leftGlove = port;
                    }
                });
            });
        }

        public static bool Vibrate(Hand hand, Finger finger, bool vibrate)
        {
            byte outgoing = (hand == Hand.Right ? rightState : leftState);
            byte mask = (byte)(1 << (byte)finger);
            outgoing = (byte)(vibrate ? outgoing | mask : outgoing & ~mask);
            try
            {
                if (hand == Hand.Right)
                {
                    rightState = outgoing;
                    Failure(rightGlove, "right");
                    rightGlove?.Write(new byte[] { outgoing }, 0, 1);
                }
                else
                {
                    leftState = outgoing;
                    Failure(leftGlove, "left");
                    leftGlove?.Write(new byte[] { outgoing }, 0, 1);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static void Failure(SerialPort port, string glove)
        {
            if (port == null && failed != null)
            {
                failed(String.Format("Connection to {0} glove could not be established. Try to connect again.", glove));
            }
        }

        public static void Exit()
        {
            ports.ForEach(p => p.Close());
        }


        public static void Intensity(Hand hand, Finger finger, int intensity)
        {
            var glove = hand == Hand.Left ? leftGlove : rightGlove;
            Failure(glove, "");
            byte outgoing = (byte)(((byte)(intensity % 32) << (byte)3) | (byte)(finger + 1));
            glove?.Write(new byte[] { outgoing }, 0, 1);
        }

    }
}
