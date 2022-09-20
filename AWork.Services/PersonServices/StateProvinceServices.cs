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
    public class StateProvinceServices : IStateProvinceServices
    {
        private IPersonRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public StateProvinceServices(IPersonRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public void Edit(StateProvinceDto stateProvinceDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<StateProvinceDto>> GetAllStateprovince(bool trackChanges)
        {
            var stateProvinceMdl = await _repositoryManager._stateProvinceRepository.GetAllStateProvince(trackChanges);
            var stateProvinceDto = _mapper.Map<IEnumerable<StateProvinceDto>>(stateProvinceMdl);
            return stateProvinceDto;
        }

        public async Task<StateProvinceDto> GetAllStateProvinceById(int stateId, bool trackChanges)
        {
            var stateProvinceMdl = await _repositoryManager._stateProvinceRepository.GetAllStateProvinceById(stateId, trackChanges);
            var stateProvinceDto = _mapper.Map<StateProvinceDto>(stateProvinceMdl);
            return stateProvinceDto;
        }

        public void Insert(StateProvinceForCreateDto stateProvinceForCreateDto)
        {
            var stateProvinceMdl = _mapper.Map<StateProvince>(stateProvinceForCreateDto);
            _repositoryManager._stateProvinceRepository.Insert(stateProvinceMdl);
            _repositoryManager.Save();
        }

        public void Remove(StateProvinceDto stateProvinceDto)
        {
            var stateProvinceMdl = _mapper.Map<StateProvince>(stateProvinceDto);
            _repositoryManager._stateProvinceRepository.Remove(stateProvinceMdl);
            _repositoryManager.SaveAsync();
        }
    }
}
