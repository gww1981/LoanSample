using LoanSample.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace LoanSample.Application.Contracts
{
    public interface ICustomerService : IApplicationService
    {
        Task<CustomerDto> CreateAsync(CustomerDto customer);

        Task<CustomerDto> AddLinkManAsync(CustomerDto customer);
    }
}
