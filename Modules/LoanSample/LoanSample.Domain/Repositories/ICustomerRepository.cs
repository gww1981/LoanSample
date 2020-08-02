using LoanSample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace LoanSample.Domain.Repositories
{
    public interface ICustomerRepository : IRepository<Customer, Guid>
    {

    }
}
