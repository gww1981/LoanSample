using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace LoanSample.EntityFrameworkCore.Migration
{
    [ConnectionStringName("CustomerDbConnection")]
    [Volo.Abp.DependencyInjection.Dependency(ServiceLifetime.Transient, ReplaceServices = true)]
    public class CustomerMigrationDbContext  : AbpDbContext<CustomerMigrationDbContext>
    {
        public CustomerMigrationDbContext(DbContextOptions<CustomerMigrationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureCustomerStore();
        }
    }
}
