using AutoMapper;
using AWork.Contracts.Dto.Production;
using AWork.Domain.Models;

namespace AWork.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // CONTOH
            /*CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryForCreateDto>().ReverseMap();*/
          
            CreateMap<UnitMeasure, UnitMeasureDto>().ReverseMap();
            CreateMap<UnitMeasure, UnitMeasureForCreateDto>().ReverseMap();

        }
    }
}
