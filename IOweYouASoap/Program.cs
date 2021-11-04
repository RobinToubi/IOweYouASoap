using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace IOweYouASoap
{
    public class Program
    {
		public static void Main(string[] args)
		{
			var host = new WebHostBuilder()
				.UseKestrel()
				.UseUrls("http://localhost:5050")
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
