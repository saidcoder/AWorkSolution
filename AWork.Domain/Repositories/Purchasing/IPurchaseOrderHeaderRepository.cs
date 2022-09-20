using AWork.Contracts.Dto.Purchasing;
using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.Purchasing
{
    public interface IPurchaseOrderHeaderRepository
    {
        Task<IEnumerable<PurchaseOrderHeader>> GetAllPurchaseOrderHeader(bool trackChanges);

        Task<PurchaseOrderHeader> GetPurchaseOrderHeaderById(int id, bool trackChanges);

        void Insert(PurchaseOrderHeader purchaseOrderHeader);

        void Edit(PurchaseOrderHeader purchaseOrderHeader);

        void Remove(PurchaseOrderHeader purchaseOrderHeader);
    }
}
