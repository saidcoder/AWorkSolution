using AutoMapper;
using AWork.Contracts.Dto.Production;
using AWork.Domain.Models;

namespace AWork.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<ProductPhoto, ProductPhotoDto>().ReverseMap();
            CreateMap<ProductPhoto, ProductPhotoForCreateDto>().ReverseMap();

            // CONTOH
            /*CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryForCreateDto>().ReverseMap();*/
        }
    }
}
