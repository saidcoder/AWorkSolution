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
    public class RepositoryManager : IRepositoryManager
    {
        private AdventureWorks2019Context _dbContext;
        private IShipMethodRepository _methodRepository;

        public RepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }

        public IShipMethodRepository ShipMethodRepository
        {
            get
            {
                if (_methodRepository == null)
                {
                    _methodRepository = new ShipMethodRepository(_dbContext);
                }
                return _methodRepository;
            }
        }


        public void Save () => _dbContext.SaveChanges();
        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();

    }
}
