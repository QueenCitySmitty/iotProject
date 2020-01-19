using System;
using System.Device.Gpio;
using System.Threading;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int ledPin = 4;
            GpioController controller = new GpioController();
            controller.OpenPin(ledPin, PinMode.Output);

            int lightTimeInMiliseconds = 5000;
            int dimTimeInMiliseconds = 5000;

            while(true)
            {
                Console.WriteLine ($"LED1 on for {lightTimeInMiliseconds}ms");

                controller.Write(ledPin, PinValue.Low);

                Thread.Sleep(lightTimeInMiliseconds);

                Console.WriteLine($"LED off for {dimTimeInMiliseconds}ms");
                controller.Write(ledPin, PinValue.High);
                Thread.Sleep(dimTimeInMiliseconds);
            }
        }
    }
}
