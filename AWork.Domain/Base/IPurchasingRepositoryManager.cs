using AWork.Domain.Repositories.Purchasing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Base
{
    public interface IPurchasingRepositoryManager
    {
        IVendorRepository VendorRepository { get; }
        IPurchaseOrderHeaderRepository PurchaseOrderHeaderRepository { get; }
        IPurchaseOrderDetailRepository PurchaseOrderDetailRepository { get; }

        void Save();

        Task SaveAsync();
    }
}
