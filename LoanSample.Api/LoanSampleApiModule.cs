using LoanSample.Application;
using LoanSample.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.AspNetCore;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.VirtualFileSystem;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace LoanSample.Api
{
    [DependsOn(typeof(AbpAspNetCoreModule))]
    [DependsOn(typeof(AbpAutofacModule))]
    [DependsOn(typeof(LoanSampleDomainModule))]
    public class LoanSampleApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);

            context.Services.Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.ConventionalControllers.Create(typeof(LoanSampleApplicationModule).Assembly);
            });
            ConfigSwaggerServices(context.Services);
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            base.OnApplicationInitialization(context);
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            app.UseRouting();
            app.UseConfiguredEndpoints();
            app.UseSwagger();
            app.UseSwaggerUI(options => {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Loan Sample Web Api");
            });

        }

        private void ConfigSwaggerServices(IServiceCollection services)
        {
            services.AddSwaggerGen(options => {
                options.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Loan Sample Web Api ",
                        Version = "1.0.0",
                        Description = "Loan Sample Web Api !",
                        Contact = new OpenApiContact { Email = "guowenwu1981815@163.com", Name = "郭文武", Url = new Uri("https://www.baidu.com") }
                    }
                    );
                options.DocInclusionPredicate((docName, description) => true);
                options.CustomSchemaIds(type => type.FullName);
            });
        }
    }
}
