using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Threading;
using Windows.Devices.Enumeration;
using Windows.Devices;
using System.Runtime;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Storage.Streams;
using HapticGloveConnector;

namespace HapticGloveConnectorTest
{
    class Program
    {

        static void Main(string[] args)
        {
            byte value = 0;
            int sleep = 5;
            Connector.Connect();
            Thread.Sleep(3000);
            Connector.Intensity(Hand.Right, Finger.Thumb, value);
            Thread.Sleep(sleep);
            Connector.Intensity(Hand.Right, Finger.Index, value);
            Thread.Sleep(sleep);
            Connector.Intensity(Hand.Right, Finger.Middle, value);
            Thread.Sleep(sleep);
            Connector.Intensity(Hand.Right, Finger.Ring, value);
            Thread.Sleep(sleep);
            Connector.Intensity(Hand.Right, Finger.Pinky, value);
            //for (int i = 0; i < 256; i++)
            //{
            //    Connector.Intensity(Hand.Right, Finger.Thumb, (byte)i);
            //    Thread.Sleep(1000);
            //}


            ////Init();
            Console.ReadKey();
        }


        public static async void Init()
        {
            var Services = await DeviceInformation.FindAllAsync(GattDeviceService.GetDeviceSelectorFromUuid(new Guid("6E400001-B5A3-F393-E0A9-E50E24DCCA9E")));
            GattDeviceService Service = await GattDeviceService.FromIdAsync(Services[0].Id);
            GattCharacteristic gattCharacteristic = Service.GetCharacteristics(new Guid("6E400002-B5A3-F393-E0A9-E50E24DCCA9E"))[0];
            
            for (byte i = 0; i < 255; i++) 
            {
                Thread.Sleep(1000);
                byte test = 31 << (byte)3 | 1;
                await gattCharacteristic.WriteValueAsync((new byte[] { test }).AsBuffer());
            }

           
        }
       
    }
}
