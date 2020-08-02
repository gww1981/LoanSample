using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Colin.AbpDemo
{
    public class AbpDemoWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<AbpDemoWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}