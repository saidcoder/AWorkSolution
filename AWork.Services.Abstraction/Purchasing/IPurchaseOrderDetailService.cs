using AWork.Contracts.Dto.Purchasing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.Purchasing
{
    public interface IPurchaseOrderDetailService
    {
        Task<IEnumerable<PurchaseOrderDetailDto>> GetAllPurchaseOD(bool trackChanges);

        Task<PurchaseOrderDetailDto> GetPurchaseODById(int purchaseODId, bool trackChanges);

        void Insert(PurchaseOrderDetailForCreateDto purchaseOrderDetailForCreateDto);

        void Edit(PurchaseOrderDetailDto purchaseOrderDetailDto);

        void Remove(PurchaseOrderDetailDto purchaseOrderDetailDto);
    }
}
