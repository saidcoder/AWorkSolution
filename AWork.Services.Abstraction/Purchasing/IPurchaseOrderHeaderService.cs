using AWork.Contracts.Dto.Purchasing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.Purchasing
{
    public interface IPurchaseOrderHeaderService
    {
        Task<IEnumerable<PurchaseOrderHeaderDto>> GetAllPurchaseOH(bool trackChanges);

        Task<PurchaseOrderHeaderDto> GetPurchaseOHById(int purchaseOHId, bool trackChanges);

        void Insert(PurchaseOrderHeaderForCreateDto purchaseOrderHeaderForCreateDto);

        void Edit(PurchaseOrderHeaderDto purchaseOrderHeaderDto);

        void Remove(PurchaseOrderHeaderDto purchaseOrderHeaderDto);
    }
}
