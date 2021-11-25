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
                new Trophy(1, "Premier trophée"),
                new Trophy(2, "Deuxième trophée"),
                new Trophy(3, "Troisième trophée"),
                new Trophy(4, "Quatrième trophée"),
                new Trophy(5, "Cinquième trophée"),
                new Trophy(6, "Sixième trophée"),
                new Trophy(7, "Septième trophée")
            };

            Services.ManageTrophies manager = new Services.ManageTrophies();

            var lstTriee = manager.GetAllTrophiesNamesAsc(trophies);

            Console.WriteLine(lstTriee);
        }
    }
}
