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

            CreateMap<ProductCategory,ProductCategoryDto>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryForCreatDto>().ReverseMap();
            CreateMap<ProductSubcategory,ProductSubCategoryDto>().ReverseMap();
            CreateMap<ProductSubcategory, ProductSubCategoryForCreateDto>().ReverseMap();

        }
    }
}
