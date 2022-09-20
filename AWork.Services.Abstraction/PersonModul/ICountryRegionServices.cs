using AWork.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.PersonModul
{
    public interface ICountryRegionServices
    {
        Task<IEnumerable<CountryRegionDto>> GetAllCountryRegion(bool trackChanges);
        Task<CountryRegionDto>GetAllCountryRegionByCode(string countryCode, bool trackChanges);
        void Insert(CountryRegionForCreateDto countryRegionForCreateDto);
        void Edit(CountryRegionDto countryRegionDto);
        void Remove(CountryRegionDto countryRegionDto);
    }
}
