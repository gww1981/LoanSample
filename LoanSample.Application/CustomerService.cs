using LoanSample.Application.Contracts;
using LoanSample.Application.Contracts.Dtos;
using LoanSample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace LoanSample.Application
{
    public class CustomerService : ApplicationService, ICustomerService
    {
        private IRepository<Customer, Guid> _customerRepo;

        

        public CustomerService(IRepository<Customer, Guid> customerRepo)
        {
            _customerRepo = customerRepo;
        }
        
        public async Task<List<CustomerDto>> GetListAsync()
        {
            var customers = await _customerRepo.GetListAsync();

            return ObjectMapper.Map<List<Customer>, List<CustomerDto>>(customers);
        }

        public async Task<CustomerDto> AddLinkManAsync(CustomerDto customer, LinkManDto linkMan)
        {
            var customerEntity = ObjectMapper.Map<CustomerDto, Customer>(customer);
            var LinkManEntity = ObjectMapper.Map<LinkManDto, LinkMan>(linkMan);
            customerEntity.AddLinkMan(LinkManEntity);
            var customerEntityResult = await _customerRepo.UpdateAsync(customerEntity);
            return ObjectMapper.Map<Customer, CustomerDto>(customerEntityResult);
        }

        public async Task<CustomerDto> CreateAsync(CustomerDto customer)
        {
            var customerEntity = ObjectMapper.Map<CustomerDto,Customer>(customer);

            var customerEntityResult  = await _customerRepo.InsertAsync(customerEntity);

            return ObjectMapper.Map< Customer, CustomerDto>(customerEntityResult);
        }

        public async Task<CustomerDto> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var customerEntity = await _customerRepo.GetAsync(id,true);

            if (customerEntity == null)
                throw new EntityNotFoundException("未找到客户信息！");

            return ObjectMapper.Map<Customer, CustomerDto>(customerEntity);
        }
    }
}
