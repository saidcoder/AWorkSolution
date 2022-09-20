using AWork.Services.Abstraction.Purchasing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction
{
    public interface IPurchasingServiceManager
    {
        IVendorService VendorService { get; }
        IPurchaseOrderHeaderService PurchaseOrderHeaderService { get; }
        IPurchaseOrderDetailService purchaseOrderDetailService { get; }
    }
}
