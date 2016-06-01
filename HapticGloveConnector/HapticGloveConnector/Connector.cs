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



namespace HapticGloveConnector
{

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

    public static class Connector
    {

        public static event Action<string> Failure;
        private static List<Glove> gloves;
        private static int timeout = 0;

        public static async void  Connect(int timeout = 0)
        {
            Connector.timeout = timeout;
            var info = await DeviceInformation.FindAllAsync(GattDeviceService.GetDeviceSelectorFromUuid(new Guid("6E400001-B5A3-F393-E0A9-E50E24DCCA9E")));
            gloves = info.Select(async x => await GattDeviceService.FromIdAsync(x.Id)).Select(s => new Glove(s.Result.GetCharacteristics(new Guid("6E400003-B5A3-F393-E0A9-E50E24DCCA9E")).FirstOrDefault(), s.Result.GetCharacteristics(new Guid("6E400002-B5A3-F393-E0A9-E50E24DCCA9E")).FirstOrDefault())).ToList();
        }

        class Glove
        {
            AutoResetEvent initialized = new AutoResetEvent(false);
            public Hand hand;
            public Action<Finger, byte> Intensity;

            public Glove(GattCharacteristic reader, GattCharacteristic writer)
            {
                hand = Hand.None;
                Action<byte> Write =  x => writer?.WriteValueAsync((new byte[] { x }).AsBuffer());
                Intensity = (finger, intensity) => Write((byte)(intensity % 32 << 3 | (byte)(finger + 1)));
                if (reader == null || writer == null) { Failure?.Invoke("Could not create a reader/writer for a glove."); return; }
                Action fun = (async () =>  await reader.WriteClientCharacteristicConfigurationDescriptorAsync(GattClientCharacteristicConfigurationDescriptorValue.Notify));
                fun();
                reader.ValueChanged += (x, args) => { hand = args.CharacteristicValue.GetByte(0) == 0 ? Hand.Left : Hand.Right; initialized.Set(); };
                Write(0);
                if (!initialized.WaitOne(timeout)) Failure?.Invoke("Response from glove not received within " + timeout + " ms. Try reconnecting!");
            }
        }


        public static void Intensity(Hand hand, Finger finger, byte intensity)
        {
            var foundGloves = gloves.Where(x => x.hand == hand);
            if (foundGloves.Count() > 0)
            {
                foundGloves.First().Intensity(finger, intensity);
            } else
            {
                Failure?.Invoke("Glove for " + hand.ToString().ToLower() + " hand not found");
            }

   
        }

    }
}
