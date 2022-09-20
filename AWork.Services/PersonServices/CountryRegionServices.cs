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
    public class CountryRegionServices : ICountryRegionServices
    {
        private IPersonRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public CountryRegionServices(IPersonRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public void Edit(CountryRegionDto countryRegionDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CountryRegionDto>> GetAllCountryRegion(bool trackChanges)
        {
            var countryRegionMdl = await _repositoryManager._countryRegionRepository.GetAllCountryRegion(trackChanges);
            var countryRegionDto = _mapper.Map<IEnumerable<CountryRegionDto>>(countryRegionMdl);
            return countryRegionDto;
        }

        public Task<CountryRegionDto> GetAllCountryRegionByCode(string countryCode, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Insert(CountryRegionForCreateDto countryRegionForCreateDto)
        {
            throw new NotImplementedException();
        }

        public void Remove(CountryRegionDto countryRegionDto)
        {
            throw new NotImplementedException();
        }
    }
}
