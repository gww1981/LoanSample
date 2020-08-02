using LoanSample.Application.Contracts;
using LoanSample.Application.Contracts.Dtos;
using LoanSample.Domain.Entities;
using LoanSample.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;

namespace LoanSample.Application
{
    public class CustomerService : ApplicationService, ICustomerService
    {
        private ICustomerRepository _customerRepo;
        private IUnitOfWorkManager _unitOfWork;
        private ICurrentTenant _currentTenant;
        

        public CustomerService(ICustomerRepository customerRepo, IUnitOfWorkManager unitOfWork, ICurrentTenant currentTenant)
        {
            _customerRepo = customerRepo;
            _unitOfWork = unitOfWork;
            _currentTenant = currentTenant;
        }
        
        public async Task<List<CustomerDto>> GetListAsync(CancellationToken cancellationToken = default)
        {
            var customers = await _customerRepo.GetListAsync(true, cancellationToken);

            return ObjectMapper.Map<List<Customer>, List<CustomerDto>>(customers);
        }

        public async Task<CustomerDto> AddLinkManAsync(Guid id, LinkManDto linkMan, CancellationToken cancellationToken = default)
        {
            var customerEntity = await _customerRepo.GetAsync(id, true, cancellationToken);
            var LinkManEntity = ObjectMapper.Map<LinkManDto, LinkMan>(linkMan);
            customerEntity.AddLinkMan(LinkManEntity);
            Customer customerEntityResult;

            using (var uow = _unitOfWork.Begin())
            {
                customerEntityResult = await _customerRepo.UpdateAsync(customerEntity, false, cancellationToken);
                if (linkMan.Name == "colin")
                    throw new InvalidOperationException("duplicated name colin !");
                await uow.CompleteAsync();
            }
            
            return ObjectMapper.Map<Customer, CustomerDto>(customerEntityResult);
        }

        public async Task<CustomerDto> CreateAsync(CustomerDto customer, CancellationToken cancellationToken = default)
        {
            var customerEntity = ObjectMapper.Map<CustomerDto,Customer>(customer);
            customerEntity.TenantId = _currentTenant.Id;
            var customerEntityResult  = await _customerRepo.InsertAsync(customerEntity,true, cancellationToken);

            return ObjectMapper.Map< Customer, CustomerDto>(customerEntityResult);
        }

        public async Task<CustomerDto> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var customerEntity = await _customerRepo.GetAsync(id,true, cancellationToken);

            if (customerEntity == null)
                throw new EntityNotFoundException("未找到客户信息！");

            return ObjectMapper.Map<Customer, CustomerDto>(customerEntity);
        }
    }
}
