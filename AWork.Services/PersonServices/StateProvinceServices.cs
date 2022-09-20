using AutoMapper;
using AWork.Contracts.Dto;
using AWork.Domain.Base;
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

        public Task<StateProvinceDto> GetAllStateProvinceById(int stateId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Insert(StateProvinceForCreateDto stateProvinceForCreateDto)
        {
            throw new NotImplementedException();
        }

        public void Remove(StateProvinceDto stateProvinceDto)
        {
            throw new NotImplementedException();
        }
    }
}
