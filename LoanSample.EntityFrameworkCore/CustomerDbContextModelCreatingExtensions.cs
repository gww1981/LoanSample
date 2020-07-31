using LoanSample.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LoanSample.EntityFrameworkCore
{
    public static class CustomerDbContextModelCreatingExtensions
    {

        public static void ConfigureCustomerStore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Customer>(c =>
            {
                c.ToTable("Customer");
                c.ConfigureByConvention();
            });

            builder.Entity<LinkMan>(c =>
            {
                c.ToTable("LinkMan");
                c.ConfigureByConvention();
            });
        }
    }
}
