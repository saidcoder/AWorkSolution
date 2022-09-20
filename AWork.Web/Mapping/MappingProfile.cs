using AutoMapper;
using AWork.Contracts.Dto;
using AWork.Domain.Models;

namespace AWork.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BusinessEntity, BusinessEntityDto>().ReverseMap();
            CreateMap<BusinessEntity, BusinessEntityForCreateDto>().ReverseMap();
            
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Address, AddressForCreateDto>().ReverseMap();

            CreateMap<ContactType, ContactTypeDto>().ReverseMap();
            CreateMap<ContactType, ContactTypeForCreateDto>().ReverseMap();

            CreateMap<CountryRegion, CountryRegionDto>().ReverseMap();
            CreateMap<CountryRegion, CountryRegionForCreateDto>().ReverseMap();

            CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<Person, PersonForCreateDto>().ReverseMap();

            CreateMap<StateProvince, StateProvinceDto>().ReverseMap();
            CreateMap<StateProvince, StateProvinceForCreateDto>().ReverseMap();
            // CONTOH
            /*CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryForCreateDto>().ReverseMap();*/
        }
    }
}
