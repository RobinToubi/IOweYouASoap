using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BottomUp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using SoapCore;

namespace BottomUp
{
    public class Startup
    {
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSoapCore();
			services.TryAddSingleton<IRandomizerService, RandomizerService>();
			services.AddMvc();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseRouting();

			app.UseEndpoints(endpoints => {
				endpoints.UseSoapEndpoint<IRandomizerService>("/ServiceRandomize.svc", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
				endpoints.UseSoapEndpoint<IRandomizerService>("/ServiceRandomize.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
			});
		}
	}
}
