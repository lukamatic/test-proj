using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace IntegrationAPI
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Run();
        }

        public static IWebHost CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
