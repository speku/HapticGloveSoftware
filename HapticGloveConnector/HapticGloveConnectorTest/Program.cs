using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Threading;

namespace HapticGloveConnectorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //HapticGloveConnector.Connector.failed += x => Console.WriteLine(x);
            for (;;)
            {
                Thread.Sleep(2000);
                HapticGloveConnector.Connector.send(HapticGloveConnector.Hand.Right, HapticGloveConnector.Finger.Middle, true);
            }

            Console.ReadKey();
        }
    }
}
