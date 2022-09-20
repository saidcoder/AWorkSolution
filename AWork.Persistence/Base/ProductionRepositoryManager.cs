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
        private IProductCategoryRepository _productCategory;
        private IProductSubCategoryRepository _productSubCategory;
        /*private ICategoryRepository _categoryRepository;*/

        public ProductionRepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }

        public IProductCategoryRepository productCategory {
            get
            {
                if (_productCategory == null)
                {
                    _productCategory = new ProductCategoryRepository(_dbContext);
                }
                return _productCategory;
            }
        }

        public IProductSubCategoryRepository productSubCategory {
            get
            {
                if (_productSubCategory == null)
                {
                    _productSubCategory = new ProductSubCategoryRepository(_dbContext);
                }
                return _productSubCategory;
            }
        }

        /*public ICategoryRepository CategoryRepository
        {
            get
            {
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
