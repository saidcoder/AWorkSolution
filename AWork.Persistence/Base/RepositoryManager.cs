using AWork.Persistence;
using AWork.Domain.Base;
using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWork.Domain.Repositories.Sales;
using AWork.Persistence.Repositories.Sales;

namespace AWork.Persistence.Base
{
    public class RepositoryManager : IRepositoryManager
    {
        private AdventureWorks2019Context _dbContext;
        private ISpecialOfferRepository _specialOfferRepository;
        private ISpecialOfferProductRepository _specialOfferProductRepository;
        private ISalesOrderDetailRepository _salesOrderDetailRepository;
        public RepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }

        public ISpecialOfferRepository SpecialOfferRepository
        {
            get
            {
                if (_specialOfferRepository == null)
                {
                    _specialOfferRepository = new SpecialOfferRepository(_dbContext);
                }
                return _specialOfferRepository;
            }
        }

        public ISpecialOfferProductRepository SpecialOfferProductRepository
        {
            get
            {
                if (_specialOfferProductRepository == null)
                {
                    _specialOfferProductRepository = new SpecialOfferProductRepository(_dbContext);
                }
                return _specialOfferProductRepository;
            }
        }

        public ISalesOrderDetailRepository SalesOrderDetailRepository
        {
            get
            {
                if (_salesOrderDetailRepository == null)
                {
                    _salesOrderDetailRepository = new SalesOrderDetailRepository(_dbContext);
                }
                return _salesOrderDetailRepository;
            }
        }

        public void Save () => _dbContext.SaveChanges();
        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();

    }
}
