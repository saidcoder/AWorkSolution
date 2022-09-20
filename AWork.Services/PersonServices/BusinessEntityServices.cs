using AutoMapper;
using AWork.Contracts.Dto;
using AWork.Domain.Base;
using AWork.Domain.Models;
using AWork.Services.Abstraction.PersonModul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.PersonServices
{
    public class BusinessEntityServices : IBusinessEntityServices
    {
        private IPersonRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public BusinessEntityServices(IPersonRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            this._mapper = mapper;
        }

        public void delete(BusinessEntityDto businessEntityDto)
        {
            var businessEntityMdl = _mapper.Map<BusinessEntity>(businessEntityDto);
            _repositoryManager.BusinessEntityRepository.Remove(businessEntityMdl);
            _repositoryManager.SaveAsync();

        }

        public void edit(BusinessEntityDto businessEntityDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BusinessEntityDto>> GetAllBusinessEntity(bool trackChanges)
        {
            var businessEntityMdl = await _repositoryManager.BusinessEntityRepository.GetAllBusinessEntity(trackChanges);
            var businessEntityDto = _mapper.Map<IEnumerable<BusinessEntityDto>>(businessEntityMdl);
            return businessEntityDto;
        }

        public async Task<BusinessEntityDto> GetBusinessEntityById(int businessEntityid, bool trackChanges)
        {
            var businessEntityMdl = await _repositoryManager.BusinessEntityRepository.GetBusinessEntityById(businessEntityid, trackChanges);
            var businessEntityDto = _mapper.Map<BusinessEntityDto>(businessEntityMdl);
            return businessEntityDto;
        }

        public void insert(BusinessEntityForCreateDto businessEntityForCreateDto)
        {
            var businessEntityMdl = _mapper.Map<BusinessEntity>(businessEntityForCreateDto);
            _repositoryManager.BusinessEntityRepository.Insert(businessEntityMdl);
            _repositoryManager.Save();
        }
    }
}
