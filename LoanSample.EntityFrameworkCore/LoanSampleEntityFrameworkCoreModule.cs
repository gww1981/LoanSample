﻿using LoanSample.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LoanSample.EntityFrameworkCore
{
    [DependsOn(typeof(LoanSampleDomainModule))]
    public class LoanSampleEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);

            context.Services.AddAbpDbContext<CustomerDbContext>(builder => { builder.AddDefaultRepositories(); });

            Configure<AbpDbContextOptions>(options => {
                options.UseMySQL();
            });
        }
    }
}
