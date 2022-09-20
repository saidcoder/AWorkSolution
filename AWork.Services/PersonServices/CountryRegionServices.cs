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

        public async Task<CountryRegionDto> GetAllCountryRegionByCode(string countryCode, bool trackChanges)
        {
            var countryRegionMdl = await _repositoryManager._countryRegionRepository.GetAllCountryRegionByCode(countryCode, trackChanges);
            var countryRegionDto = _mapper.Map<CountryRegionDto>(countryRegionMdl);
            return countryRegionDto;
        }

        public void Insert(CountryRegionForCreateDto countryRegionForCreateDto)
        {
            var countryRegionMdl = _mapper.Map<CountryRegion>(countryRegionForCreateDto);
            _repositoryManager._countryRegionRepository.Insert(countryRegionMdl);
            _repositoryManager.Save();
        }

        public void Remove(CountryRegionDto countryRegionDto)
        {
            var countryRegionMdl = _mapper.Map<CountryRegion>(countryRegionDto);
            _repositoryManager._countryRegionRepository.Remove(countryRegionMdl);
            _repositoryManager.SaveAsync();
        }
    }
}
