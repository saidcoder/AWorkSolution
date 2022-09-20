using AWork.Domain.Models;
using AWork.Domain.Repositories.PersonModul;
using AWork.Persistence.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Persistence.Repositories.PersonModul
{
    public class CountryRegionRepository : RepositoryBase<CountryRegion>, ICountryRegionRepository
    {
        public CountryRegionRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Edit(CountryRegion countryRegion)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CountryRegion>> GetAllCountryRegion(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<CountryRegion> GetAllCountryRegionByCode(string countryCode, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Insert(CountryRegion countryRegion)
        {
            throw new NotImplementedException();
        }

        public void Remove(CountryRegion countryRegion)
        {
            throw new NotImplementedException();
        }
    }
}
