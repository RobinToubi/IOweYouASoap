using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SoapCore;
using IOweYouASoap.Models;
using Microsoft.Extensions.Logging;

namespace IOweYouASoap
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSoapCore();
            services.TryAddSingleton<IRandomizerService, RandomizerService>();
            services.AddMvc();
        }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
		{
			WsdlFileOptions options = new WsdlFileOptions
			{
				UrlOverride = string.Empty,
				VirtualPath = string.Empty,
				WebServiceWSDLMapping = new Dictionary<string, WebServiceWSDLMapping>
				{
					{
						"Random.asmx", new WebServiceWSDLMapping
						{
							SchemaFolder = "utils",
							WsdlFile = "randomizer.wsdl",
							WSDLFolder = "utils"
						}
					}
				},
				AppPath = env.ContentRootPath
			};
			loggerFactory.CreateLogger("info").LogInformation(options.AppPath);
			app.UseRouting();

			app.UseEndpoints(x =>
			{
				x.UseSoapEndpoint<IRandomizerService>("/Random.svc", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
				x.UseSoapEndpoint<IRandomizerService>("/Random.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer, false, null, options);
			});
		}
	}
}
