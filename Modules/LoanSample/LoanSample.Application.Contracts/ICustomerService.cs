using LoanSample.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace LoanSample.Application.Contracts
{
    public interface ICustomerService : IApplicationService
    {
        Task<List<CustomerDto>> GetListAsync(CancellationToken cancellationToken);

        Task<CustomerDto> CreateAsync(CustomerDto customer, CancellationToken cancellationToken = default);

        Task<CustomerDto> AddLinkManAsync(Guid id, LinkManDto linkMan, CancellationToken cancellationToken = default);

        Task<CustomerDto> GetAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
