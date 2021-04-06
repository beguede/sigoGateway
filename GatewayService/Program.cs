using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace GatewayService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            var builder = WebHost.CreateDefaultBuilder(args);

            builder//.ConfigureServices(s => s.AddSingleton(builder))
                   .ConfigureAppConfiguration(
                          ic => ic.AddJsonFile("configuration.json"))
                    .UseStartup<Startup>();
            var host = builder.Build();
            return host;
        }
    }
}
