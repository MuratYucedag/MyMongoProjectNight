using AutoMapper;
using MyMongoProjectNight.Dtos.CustomerDtos;
using MyMongoProjectNight.Entities;

namespace MyMongoProjectNight.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Customer, CreateCustomerDto>().ReverseMap();
            CreateMap<Customer, UpdateCustomerDto>().ReverseMap();
            CreateMap<Customer, ResultCustomerDto>().ReverseMap();
            CreateMap<Customer, GetByIdCustomerDto>().ReverseMap();
        }
    }
}
