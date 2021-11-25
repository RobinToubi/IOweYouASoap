using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceTrophies
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            testManageTrophies();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void testManageTrophies()
        {
            List<Trophy> trophies = new List<Trophy>() { 
                new Trophy(1, "Premier troph�e"),
                new Trophy(2, "Deuxi�me troph�e"),
                new Trophy(3, "Troisi�me troph�e"),
                new Trophy(4, "Quatri�me troph�e"),
                new Trophy(5, "Cinqui�me troph�e"),
                new Trophy(6, "Sixi�me troph�e"),
                new Trophy(7, "Septi�me troph�e")
            };

            Services.ManageTrophies manager = new Services.ManageTrophies();

            var lstTriee = manager.GetAllTrophiesNamesAsc(trophies);

            Console.WriteLine(lstTriee);
        }
    }
}
