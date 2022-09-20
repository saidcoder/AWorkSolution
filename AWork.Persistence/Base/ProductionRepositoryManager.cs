using AWork.Persistence;
using AWork.Domain.Base;
using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWork.Domain.Repositories.Production;
using AWork.Persistence.Repositories.Production;

namespace AWork.Persistence.Base
{
    public class ProductionRepositoryManager : IProductionRepositoryManager
    {
        private AdventureWorks2019Context _dbContext;
        /*private ICategoryRepository _categoryRepository;*/
        private IUnitMeasureRepository _unitMeasureRepository;

        public ProductionRepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }

        public IUnitMeasureRepository UnitMeasureRepository
        {
            get
            {
                if (_unitMeasureRepository == null)
                {
                    _unitMeasureRepository = new UnitMeasureRepository(_dbContext);
                }
                return _unitMeasureRepository;
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



        public void Save() => _dbContext.SaveChanges();
        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();

    }
}
