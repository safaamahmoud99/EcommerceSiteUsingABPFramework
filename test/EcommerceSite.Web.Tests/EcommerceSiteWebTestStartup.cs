using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace EcommerceSite
{
    public class EcommerceSiteWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<EcommerceSiteWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}