using System.Collections.Generic;
using System.IO;
using GroupService.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GroupService
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var host = new WebHostBuilder()
					.UseKestrel()
					.UseUrls("http://*:5050")
					.UseContentRoot(Directory.GetCurrentDirectory())
					.UseStartup<Startup>()
					.ConfigureLogging(x =>
					{
						x.AddDebug();
						x.AddConsole();
					})
					.Build();

			host.Run();
		}
    }
}
