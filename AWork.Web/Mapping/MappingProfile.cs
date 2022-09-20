using AutoMapper;
using AWork.Contracts.Dto.Sales.SalesPerson;
using AWork.Contracts.Dto.Sales.SalesTerritory;
using AWork.Domain.Models;

namespace AWork.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SalesTerritory, SalesTerritoryDto>().ReverseMap();
            CreateMap<SalesTerritory, SalesTerritoryForCreateDto>().ReverseMap();

            CreateMap<SalesPerson, SalesPersonDto>().ReverseMap();
            CreateMap<SalesPerson, SalesPersonForCreateDto>().ReverseMap();
        }
    }
}
