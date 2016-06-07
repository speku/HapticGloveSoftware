using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HapticGloveShared
{
    public class HapticGloveMessage
    {
        public static string pipeName = "HapticGlovePipe"; 
        public Hand hand;
        public Finger finger;
        public byte intensity;
        public string message;

        public HapticGloveMessage(Hand hand, Finger finger, byte intensity, string message = "")
        {
            this.hand = hand;
            this.finger = finger;
            this.intensity = intensity;
            this.message = message;
        }

        public HapticGloveMessage(string message)
        {
            this.message = message;
        }
    }

    public enum Hand
    {
        Right,
        Left,
        None
    }

    public enum Finger
    {
        Thumb,
        Index,
        Middle,
        Ring,
        Pinky
    }
}
