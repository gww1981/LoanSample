using LoanSample.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using DependencyAttribute = Volo.Abp.DependencyInjection.DependencyAttribute;

namespace LoanSample.EntityFrameworkCore.Migration
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(ICustomerStoreDbSchemaMigrator))]
    public class EntityFrameworkCoreCustomerDbContextMigrator : ICustomerStoreDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;
        public EntityFrameworkCoreCustomerDbContextMigrator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            await _serviceProvider
                .GetRequiredService<CustomerMigrationDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
