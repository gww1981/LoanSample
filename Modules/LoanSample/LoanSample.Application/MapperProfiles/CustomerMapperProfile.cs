using AutoMapper;
using LoanSample.Application.Contracts.Dtos;
using LoanSample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanSample.Application.MapperProfiles
{
    public class CustomerMapperProfile : Profile
    {
        public CustomerMapperProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<LinkMan, LinkManDto>().ReverseMap();
        }
    }
}
