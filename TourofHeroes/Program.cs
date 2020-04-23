using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TourofHeroes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<ServerStartup>();
                });
    }
}
