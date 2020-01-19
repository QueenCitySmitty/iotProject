namespace IotProject
{
    using Microsoft.Extensions.DependencyInjection;

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
