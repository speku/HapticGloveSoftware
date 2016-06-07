using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using HapticGloveConnector;

namespace HapticGlovePipeClient
{
    class Program
    {
        static void Main(string[] args)
        {
      
                if (args.Length == 0) return;

                Console.WriteLine("creating pipeclientstream");
            //using (PipeStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, args[0]))
            using (PipeStream pipeClient = new AnonymousPipeClientStream(args[0]))
            {
                    Console.WriteLine("opening stream reader");
                    using (StreamReader sr = new StreamReader(pipeClient))
                    {
                        var strToFinger = new Dictionary<string, Finger>() { { "thumb", Finger.Thumb }, { "index", Finger.Index }, { "middle", Finger.Middle }, { "ring", Finger.Ring }, { "pinky", Finger.Pinky } };
                        for (;;)
                        {
                            Console.WriteLine("reading from stream");
                            var arguments = sr.ReadLine().Split(' ');
                            if (arguments[0] == "connect")
                            {
                                Console.WriteLine("connecting to glove");
                                Connector.Connect(1000);
                            }
                            else
                            {
                                Console.WriteLine("adjusting intensity of vibration");
                                Connector.Intensity(arguments[1] == "right" ? Hand.Right : Hand.Left, strToFinger[arguments[2]], byte.Parse(arguments[3]));
                            }
                        }
                    }
                }
         
    }
    }
          
}
