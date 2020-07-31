using LoanSample.Domain.Entities;
using LoanSample.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace LoanSample.EntityFrameworkCore
{
    public class CustomerRepository : EfCoreRepository<CustomerDbContext, Customer, Guid>, ICustomerRepository
    {
        public CustomerRepository(IDbContextProvider<CustomerDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
        public override IQueryable<Customer> WithDetails()
        {
            return base.WithDetails().Include(x => x.LinkMen);
        }

        //public override Task<List<Customer>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = default)
        //{
        //    return base.GetListAsync(true, cancellationToken);
        //}

        //public override Task<Customer> GetAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = default)
        //{
        //    return base.GetAsync(id, true, cancellationToken);
        //}

    }
}
