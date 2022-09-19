using AWork.Persistence;
using AWork.Domain.Base;
using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWork.Domain.Repositories.HumanResource;
using AWork.Persistence.Repositories.HumanResource;

namespace AWork.Persistence.Base
{
    public class RepositoryManager : IRepositoryManager
    {
        private AdventureWorks2019Context _dbContext;
        private IShiftRepository _shiftRepository;
        /*private ICategoryRepository _categoryRepository;*/

        public RepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }

        public IShiftRepository ShiftRepository
        {
            get
            {
                if (_shiftRepository == null)
                {
                    _shiftRepository = new ShiftRepository(_dbContext);
                }
                return _shiftRepository;
            }
        }

        /*public ICategoryRepository CategoryRepository
        {
            get {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_dbContext);
                }
                return _categoryRepository; 
            }
        }*/



        public void Save () => _dbContext.SaveChanges();
        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();

    }
}
