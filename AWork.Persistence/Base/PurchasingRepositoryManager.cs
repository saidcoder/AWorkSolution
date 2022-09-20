using AWork.Persistence;
using AWork.Domain.Base;
using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWork.Domain.Repositories.Purchasing;
using AWork.Persistence.Repositories.Purchasing;

namespace AWork.Persistence.Base
{
    public class PurchasingRepositoryManager : IPurchasingRepositoryManager
    {
        private AdventureWorks2019Context _dbContext;
        private IVendorRepository _vendorRepository;
        private IPurchaseOrderHeaderRepository _purchaseOrderHeader;
        private IPurchaseOrderDetailRepository _purchaseOrderDetail;


        public PurchasingRepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }

        public IVendorRepository VendorRepository
        {
            get
            {
                if (_vendorRepository == null)
                {
                    _vendorRepository = new VendorRepository(_dbContext);
                }
                return _vendorRepository;
            }
        }

        public IPurchaseOrderHeaderRepository PurchaseOrderHeaderRepository
        {
            get
            {
                if (_purchaseOrderHeader == null)
                {
                    _purchaseOrderHeader = new PurchaseOrderHeaderRepository(_dbContext);
                }
                return _purchaseOrderHeader;
            }
        }  

        public IPurchaseOrderDetailRepository PurchaseOrderDetailRepository
        {
            get
            {
                if (_purchaseOrderDetail == null)
                {
                    _purchaseOrderDetail = new PurchaseOrderDetailRepository(_dbContext);
                }
                return _purchaseOrderDetail;
            }
        }

        public void Save () => _dbContext.SaveChanges();
        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();

    }
}
