namespace IotProject
{
    using System.Device.Gpio;
    using System.Threading;

    class Application
    {
        ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            int ledPin = 4;
            GpioController controller = new GpioController();
            controller.OpenPin(ledPin, PinMode.Output);

            int lightTimeInMiliseconds = 5000;
            int dimTimeInMiliseconds = 5000;

            while(true)
            {
                _logger.Write($"LED1 on for {lightTimeInMiliseconds}ms");

                controller.Write(ledPin, PinValue.Low);

                Thread.Sleep(lightTimeInMiliseconds);

                _logger.Write($"LED off for {dimTimeInMiliseconds}ms");
                controller.Write(ledPin, PinValue.High);
                Thread.Sleep(dimTimeInMiliseconds);
            }
        }
    }
}