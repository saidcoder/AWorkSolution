using AutoMapper;
using AWork.Contracts.Dto.Purchasing;
using AWork.Domain.Models;

namespace AWork.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Vendor, VendorDto>().ReverseMap();
            CreateMap<Vendor, VendorForCreateDto>().ReverseMap();
            CreateMap<PurchaseOrderHeader, PurchaseOrderHeaderDto>().ReverseMap();
            CreateMap<PurchaseOrderHeader, PurchaseOrderHeaderForCreateDto>().ReverseMap();
        }
    }
}
