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
    public class StateProvinceRepository : RepositoryBase<StateProvince>, IStateProvinceRepository
    {
        public StateProvinceRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Edit(StateProvince stateProvince)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StateProvince>> GetAllStateProvince(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<StateProvince> GetAllStateProvinceById(int StateId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Insert(StateProvince stateProvince)
        {
            throw new NotImplementedException();
        }

        public void Remove(StateProvince stateProvince)
        {
            throw new NotImplementedException();
        }
    }
}
