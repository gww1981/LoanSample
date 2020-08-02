using LoanSample.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace LoanSample.EntityFrameworkCore.Migration
{
    [DependsOn(typeof(LoanSampleEntityFrameworkCoreModule))]
    [DependsOn(typeof(LoanSampleDomainModule))]
    public class LoanSampleEntityFrameworkCoreMigrationModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);

            context.Services.AddAbpDbContext<CustomerMigrationDbContext>();
        }
    }
}
