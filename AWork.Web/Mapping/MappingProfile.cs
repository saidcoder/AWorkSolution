using AutoMapper;
using AWork.Contracts.Dto.Purchasing.ShipMethod;
using AWork.Domain.Models;

namespace AWork.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ShipMethod, ShipMethodDto>().ReverseMap();
            CreateMap<ShipMethod, ShipMethodForCreateDto>().ReverseMap();
        }
    }
}
