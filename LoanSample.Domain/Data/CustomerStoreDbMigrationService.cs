using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LoanSample.Domain.Data
{
    public class CustomerStoreDbMigrationService : ITransientDependency
    {
        private readonly ICustomerStoreDbSchemaMigrator _dbSchemaMigrator;

        private  ILogger<CustomerStoreDbMigrationService> _logger;
        
        public CustomerStoreDbMigrationService(ICustomerStoreDbSchemaMigrator dbSchemaMigrator)
        {
            _dbSchemaMigrator = dbSchemaMigrator;
            _logger = NullLogger<CustomerStoreDbMigrationService>.Instance;
        }


        public async Task MigrateAsync()
        {
            _logger.LogInformation("Started database migrations...");

            _logger.LogInformation("Migrating database schema...");

            await _dbSchemaMigrator.MigrateAsync();

            _logger.LogInformation("Successfully complete database migrations.");
        }
    }
}
