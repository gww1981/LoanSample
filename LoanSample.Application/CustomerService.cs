using LoanSample.Application.Contracts;
using LoanSample.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace LoanSample.Application
{
    public class CustomerService : ApplicationService, ICustomerService
    {
        public Task<CustomerDto> AddLinkManAsync(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDto> CreateAsync(CustomerDto customer)
        {
            throw new NotImplementedException();
        }
    }
}
