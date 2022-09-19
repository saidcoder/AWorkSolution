using AutoMapper;
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
        }
    }
}
