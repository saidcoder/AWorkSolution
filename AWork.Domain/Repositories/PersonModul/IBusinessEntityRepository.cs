using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.PersonModul
{
    public interface IBusinessEntityRepository
    {
        Task<IEnumerable<BusinessEntity>> GetAllBusinessEntity(bool trackChanges);
        Task<BusinessEntity> GetBusinessEntityById(int businessEntityId, bool trackChanges);
        void Insert(BusinessEntity businessEntity);
        void Edit(BusinessEntity businessEntity);
        void Remove(BusinessEntity businessEntity);
    }
}
