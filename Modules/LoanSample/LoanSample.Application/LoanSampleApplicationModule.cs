using LoanSample.Application.Contracts;
using LoanSample.Domain;
using LoanSample.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace LoanSample.Application
{

    [DependsOn(typeof(LoanSampleApplicationContractModule))]
    [DependsOn(typeof(LoanSampleDomainModule))]
    [DependsOn(typeof(AbpAutoMapperModule))]
    [DependsOn(typeof(LoanSampleEntityFrameworkCoreModule))]
    public class LoanSampleApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);

            context.Services.AddAutoMapperObjectMapper<LoanSampleApplicationModule>();

            Configure<AbpAutoMapperOptions>(options => {
                options.AddMaps<LoanSampleApplicationModule>();
            });
        }
    }
}
