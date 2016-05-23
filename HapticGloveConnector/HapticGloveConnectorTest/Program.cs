using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

namespace HapticGloveConnectorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("started");
            foreach (var port in SerialPort.GetPortNames())
            {
                Console.WriteLine(port);
            }
            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
