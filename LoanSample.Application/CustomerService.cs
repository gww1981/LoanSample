using LoanSample.Application.Contracts;
using LoanSample.Application.Contracts.Dtos;
using LoanSample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace LoanSample.Application
{
    public class CustomerService : ApplicationService, ICustomerService
    {
        private IRepository<Customer> _customerRepo;


        public CustomerService(IRepository<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }
        public async Task<List<CustomerDto>> GetListAsync()
        {
            var customers = await _customerRepo.GetListAsync();

            return ObjectMapper.Map<List<Customer>, List<CustomerDto>>(customers);
        }

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
