using AutoMapper;
using AWork.Domain.Base;
using AWork.Domain.Repositories.Purchasing;
using AWork.Services.Abstraction;
using AWork.Services.Abstraction.Purchasing;
using AWork.Services.Purchasing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services
{
    public class ServiceManager : IPurchasingServiceManager
    {
        private readonly Lazy<IVendorService> _serviceVendor;
        private readonly Lazy<IPurchaseOrderHeaderService> _servicePurchaseOrderHeader;
        private readonly Lazy<IPurchaseOrderDetailService> _servicePurchaseOrderDetail;
        public ServiceManager(IPurchasingRepositoryManager repositoryManager, IMapper mapper)
        {
            _serviceVendor = new Lazy<IVendorService>(() => new VendorService(repositoryManager, mapper));
            _servicePurchaseOrderHeader = new Lazy<IPurchaseOrderHeaderService>(() => new PurchaseOrderHeaderService(repositoryManager, mapper));
        }

        public IVendorService VendorService => _serviceVendor.Value;

        public IPurchaseOrderHeaderService PurchaseOrderHeaderService => _servicePurchaseOrderHeader.Value;

        public IPurchaseOrderDetailService purchaseOrderDetailService => _servicePurchaseOrderDetail.Value;
    }
}
