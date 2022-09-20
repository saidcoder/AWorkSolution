using AWork.Domain.Models;
using AWork.Domain.Repositories.Purchasing;
using AWork.Persistence.Base;
using AWork.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AWork.Persistence.Repositories.Purchasing
{
    internal class PurchaseOrderHeaderRepository : RepositoryBase<PurchaseOrderHeader>, IPurchaseOrderHeaderRepository
    {
        public PurchaseOrderHeaderRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Edit(PurchaseOrderHeader purchaseOrderHeader)
        {
            Update(purchaseOrderHeader);
        }

        public async Task<IEnumerable<PurchaseOrderHeader>> GetAllPurchaseOrderHeader(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(poh => poh.PurchaseOrderId).ToListAsync();
        }

        public async Task<PurchaseOrderHeader> GetPurchaseOrderHeaderById(int id, bool trackChanges)
        {
            return await FindByCondition(poh => poh.PurchaseOrderId.Equals(id), trackChanges).SingleOrDefaultAsync();
        }

        public void Insert(PurchaseOrderHeader purchaseOrderHeader)
        {
            Create(purchaseOrderHeader);
        }

        public void Remove(PurchaseOrderHeader purchaseOrderHeader)
        {
            Delete(purchaseOrderHeader);
        }
    }
}