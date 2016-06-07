using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HapticGloveShared;
using NamedPipeWrapper.IO;
using NamedPipeWrapper;

namespace HapticGloveClient
{
    public static class Client
    {
        static NamedPipeClient<HapticGloveMessage> client = new NamedPipeClient<HapticGloveMessage>(HapticGloveMessage.pipeName);
        static NamedPipeConnection<HapticGloveMessage, HapticGloveMessage> connection;
        public static event Action<string> ConnectionEstablished;
        public static event Action<string> ConnectionFailed;

        static Client()
        {
            client.ServerMessage += (conn, message) => { connection = conn; ConnectionEstablished?.Invoke("Connection to Haptic Glove Utility established"); };
            client.Start();
        }

        public static void Vibrate(Hand hand, Finger finger, byte intensity)
        {
            if (connection == null)
            {
                ConnectionFailed?.Invoke("Connection to Haptic Glove Utility could not be established. Try to reconnect to client from Haptic Glove Utility!");
            } else
            {
                connection.PushMessage(new HapticGloveMessage(hand, finger, intensity));
            }
        }

    }
}
