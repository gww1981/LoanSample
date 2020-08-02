using LoanSample.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace LoanSample.EntityFrameworkCore
{
    [ConnectionStringName("CustomerDbConnection")]
    public class CustomerDbContext : AbpDbContext<CustomerDbContext>
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<LinkMan> LinkMan { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureCustomerStore();
        }
    }
}
