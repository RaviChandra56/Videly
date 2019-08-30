using AutoMapper;
using Videly.Dtos;
using Videly.Models;

namespace Videly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();//automapper uses reflection to scan the property with the name and to map
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
        }
    }
}