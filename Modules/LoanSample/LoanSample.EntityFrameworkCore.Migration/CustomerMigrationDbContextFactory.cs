using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace LoanSample.EntityFrameworkCore.Migration
{
    public class CustomerMigrationDbContextFactory : IDesignTimeDbContextFactory<CustomerMigrationDbContext>
    {
        public CustomerMigrationDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();
            var builder = new DbContextOptionsBuilder<CustomerMigrationDbContext>()
                .UseMySql(configuration.GetConnectionString("CustomerDbConnection"));

            return new CustomerMigrationDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }

    }
}
