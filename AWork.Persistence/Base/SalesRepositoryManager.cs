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
using System.Runtime.InteropServices;

namespace AWork.Persistence.Base
{
    public class SalesRepositoryManager : ISalesRepositoryManager
    {
        private AdventureWorks2019Context _dbContext;
        private ISalesTerritoryRepository _salesTerritoryRepository;
        private ISalesPersonRepository _salesPersonRepository;
        private IShoppingCartItemRepository _shoppingCartItemRepository;
        private ICustomerRepository _customerRepository;

        public SalesRepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }

        public ISalesTerritoryRepository SalesTerritoryRepository 
        {
            get
            {
                if (_salesTerritoryRepository == null)
                {
                    _salesTerritoryRepository = new SalesTerritoryRepository(_dbContext);
                }
                return _salesTerritoryRepository;
            }
        }

        public ISalesPersonRepository SalesPersonRepository 
        {
            get
            {
                if (_salesPersonRepository == null)
                {
                    _salesPersonRepository = new SalesPersonRepository(_dbContext);
                }
                return _salesPersonRepository;
            }
        }

        public IShoppingCartItemRepository ShoppingCartItemRepository
        {
            get
            {
                if (_shoppingCartItemRepository == null)
                {
                    _shoppingCartItemRepository = new ShoppingCartItemRepository(_dbContext);
                }
                return _shoppingCartItemRepository;
            }
        }

        public ICustomerRepository CustomerRepository 
        { 
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_dbContext);
                }
                return _customerRepository;
            }
        }

        public void Save () => _dbContext.SaveChanges();
        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();

    }
}
