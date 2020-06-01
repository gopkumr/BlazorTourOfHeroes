using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace TourofHeroes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = CreateHostBuilder(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSingleton<MessageService>();
            builder.Services.AddSingleton<HeroService>();

            builder.Build().RunAsync();
        }

        public static WebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            WebAssemblyHostBuilder.CreateDefault(args);
                
    }
}
