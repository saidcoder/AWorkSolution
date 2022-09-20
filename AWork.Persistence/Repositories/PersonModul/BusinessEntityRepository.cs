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
            Update(businessEntity);
        }

        public async Task<IEnumerable<BusinessEntity>> GetAllBusinessEntity(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(c => c.BusinessEntityId).ToListAsync();
        }

        public async Task<BusinessEntity> GetBusinessEntityById(int businessEntityId, bool trackChanges)
        {
            return await FindByCondition(c => c.BusinessEntityId.Equals(businessEntityId), trackChanges).SingleOrDefaultAsync();
        }

        public void Insert(BusinessEntity businessEntity)
        {
            Create(businessEntity);
        }

        public void Remove(BusinessEntity businessEntity)
        {
            Delete(businessEntity);
        }
    }
}
