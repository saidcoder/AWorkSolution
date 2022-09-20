using Microsoft.EntityFrameworkCore;
using AWork.Domain.Models;
using AWork.Persistence.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWork.Domain.Repositories.PersonModul;

namespace AWork.Persistence.Repositories.PersonModul
{
    public class BusinessEntityRepository : RepositoryBase<BusinessEntity>, IBusinessEntityRepository
    {
        public BusinessEntityRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Edit(BusinessEntity businessEntity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BusinessEntity>> GetAllBusinessEntity(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessEntity> GetBusinessEntityById(int businessEntityId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Insert(BusinessEntity businessEntity)
        {
            throw new NotImplementedException();
        }

        public void Remove(BusinessEntity businessEntity)
        {
            throw new NotImplementedException();
        }
    }
}
