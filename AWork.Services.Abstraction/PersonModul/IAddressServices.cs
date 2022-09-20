using AWork.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.PersonModul
{
    public interface IAddressServices
    {
        Task<IEnumerable<AddressDto>> GetAllAddress(bool trackChanges);
        Task<AddressDto> GetAllAddressById(int addressId, bool trackChanges);
        void Insert(AddressForCreateDto addressForCreateDto);
        void Edit(AddressDto addressDto);
        void Remove(AddressDto addressDto);
    }
}
