using LoanSample.Domain;
using LoanSample.Domain.Entities;
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
    [DependsOn(typeof(AbpEntityFrameworkCoreModule))]
    public class LoanSampleEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);

            context.Services.AddAbpDbContext<CustomerDbContext>(options => {
                options.AddDefaultRepositories();
                options.AddRepository<Customer, CustomerRepository>();
            });

            Configure<AbpDbContextOptions>(options => {
                options.UseMySQL();
            });
        }
    }
}
