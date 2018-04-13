﻿using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>()
                .ForMember(m => m.Id, opt => opt.Ignore());

            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}