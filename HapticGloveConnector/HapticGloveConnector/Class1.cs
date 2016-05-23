using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

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

        private static SerialPort leftGlove, rightGlove;
        private static byte leftState, rightState;

        static Connector()
        {

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
                    rightGlove.Write(new byte[] { outgoing }, 0, 1);
                } else
                {
                    leftState = outgoing;
                    leftGlove.Write(new byte[] { outgoing}, 0, 1);
                }
                return true;
            } catch
            {
                return false;
            }
        }





    }
}
