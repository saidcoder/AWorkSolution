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
using System.Net.Http.Headers;

namespace AWork.Persistence.Base
{
    public class RepositoryManager : IRepositoryManager
    {
        private AdventureWorks2019Context _dbContext;

        private ICurrencyRepository _currencyRepository;
        private ICurrencyRateRepository _currencyRateRepository;
        private IStoreRepository _storeRepository;

        public RepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }
        public IStoreRepository StoreRepository
        {
            get
            {
                if (_storeRepository == null)
                {
                    _storeRepository = new StoreRepository(_dbContext);
                }
                return _storeRepository;
            }
        }

        public ICurrencyRepository CurrencyRepository
        {
            get
            {
                if (_currencyRepository==null)
                {
                    _currencyRepository = new CurrencyRepository(_dbContext);
                }
                return _currencyRepository;
            }
        }

        public ICurrencyRateRepository CurrencyRateRepository
        {
            get
            {
                if (_currencyRateRepository==null)
                {
                    _currencyRateRepository= new CurrencyRateRepository(_dbContext);
                }
                return _currencyRateRepository;
            }
        }

        public void Save () => _dbContext.SaveChanges();
        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();

    }
}
