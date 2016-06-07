using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;

namespace HapticGlovePipeServer
{
    public static class Server
    {
        static AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable);
        static StreamWriter writer = new StreamWriter(pipeServer);

        static Server()
        {
            Process pipeClient = new Process();

            pipeClient.StartInfo.FileName = "HapticGlovePipeClient.exe";
            pipeClient.StartInfo.Arguments = pipeServer.GetClientHandleAsString();
            pipeClient.StartInfo.UseShellExecute = false;
            pipeClient.Start();
            pipeServer.DisposeLocalCopyOfClientHandle();

            writer.AutoFlush = true;

            Connect(); 
        }

        private static void Connect()
        {
            try
            {
                writer.WriteLine("connect");
                pipeServer.WaitForPipeDrain();
            }
            catch
            {

            }

        }

        public static void Vibrate(string hand, string finger, byte intensity)
        {
            try
            {
                writer.WriteLine("intensity" + " " + hand + " " + finger + " " + intensity.ToString());
                pipeServer.WaitForPipeDrain();
            }
            catch
            {

            }
        }

        
    }
}
