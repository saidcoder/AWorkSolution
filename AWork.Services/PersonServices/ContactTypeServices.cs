using AutoMapper;
using AWork.Contracts.Dto;
using AWork.Domain.Base;
using AWork.Domain.Models;
using AWork.Services.Abstraction.PersonModul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.PersonServices
{
    public class ContactTypeServices : IContactTypeServices
    {
        private IPersonRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ContactTypeServices(IPersonRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public void Edit(ContactTypeDto contactTypeDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ContactTypeDto>> GetAllContactType(bool trackChanges)
        {
            var contactTypesMdl = await _repositoryManager._contactTypeRepository.GetAllContactType(trackChanges);
            var contactTypesDto = _mapper.Map<IEnumerable<ContactTypeDto>>(contactTypesMdl);
            return contactTypesDto;
        }

        public async Task<ContactTypeDto> GetAllContactTypeById(int contactId, bool trackChanges)
        {
            var contactTypeMdl = await _repositoryManager._contactTypeRepository.GetAllContactTypeById(contactId, trackChanges);
            var contactTypeDto = _mapper.Map<ContactTypeDto>(contactTypeMdl);
            return contactTypeDto;
        }

        public void Insert(ContactTypeForCreateDto contactTypeForCreateDto)
        {
            var contactTypeMdl = _mapper.Map<ContactType>(contactTypeForCreateDto);
            _repositoryManager._contactTypeRepository.Insert(contactTypeMdl);
            _repositoryManager.Save();
        }

        public void Remove(ContactTypeDto contactTypeDto)
        {
            var contactTypeMdl = _mapper.Map<ContactType>(contactTypeDto); 
            _repositoryManager._contactTypeRepository.Remove(contactTypeMdl);
            _repositoryManager.SaveAsync();
        }
    }
}
