using AutoMapper;
using AWork.Contracts.Dto;
using AWork.Domain.Base;
using AWork.Domain.Models;
using AWork.Domain.Repositories.PersonModul;
using AWork.Services.Abstraction.PersonModul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.PersonServices
{
    public class AddressServices : IAddressServices
    {
        private IPersonRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public void Edit(AddressDto addressDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AddressDto>> GetAllAddress(bool trackChanges)
        {
            var addressMdl = await _repositoryManager._addressRepository.GetAllAdress(trackChanges);
            var addressDto = _mapper.Map<IEnumerable<AddressDto>>(addressMdl);
            return addressDto;
        }

        public async Task<AddressDto> GetAllAddressById(int addressId, bool trackChanges)
        {
            var addressMdl = await _repositoryManager._addressRepository.GetAllAddressById(addressId, trackChanges);
            var addressDto = _mapper.Map<AddressDto>(addressMdl);
            return addressDto;
        }

        public void Insert(AddressForCreateDto addressForCreateDto)
        {
            var addressMdl = _mapper.Map<Address>(addressForCreateDto);
            _repositoryManager._addressRepository.Insert(addressMdl);
            _repositoryManager.Save();
        }

        public void Remove(AddressDto addressDto)
        {
            var addressMdl = _mapper.Map<Address>(addressDto);
            _repositoryManager._addressRepository.Remove(addressMdl);
            _repositoryManager.SaveAsync();
        }
    }
}
