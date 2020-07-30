using LoanSample.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LoanSample.EntityFrameworkCore.Migration
{
    [Volo.Abp.DependencyInjection.Dependency(ServiceLifetime.Transient, ReplaceServices = true)]
    [ExposeServices(typeof(ICustomerStoreDbSchemaMigrator))]
    public class EntityFrameworkCoreCustomerDbContextMigrator : ICustomerStoreDbSchemaMigrator
    {
        private readonly CustomerMigrationDbContext _migrationDbContext;
        public EntityFrameworkCoreCustomerDbContextMigrator(CustomerMigrationDbContext migrationDbContext)
        {
            _migrationDbContext = migrationDbContext;
        }

        public async Task MigrateAsync()
        {
            await _migrationDbContext.Database.MigrateAsync();
        }
    }
}
