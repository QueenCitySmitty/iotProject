using System;
using System.Device.Gpio;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using(ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var app = serviceProvider.GetService<Application>();

                app.Run();
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services
                .AddTransient<Application>()
                .AddSingleton<ILogger, ConsoleLogger>();
        }
    }
}
