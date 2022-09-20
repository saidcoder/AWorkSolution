using AWork.Domain.Models;
using AWork.Domain.Repositories.Production;
using AWork.Persistence.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Persistence.Repositories.Production
{
    internal class ProductSubCategoryRepository : ProductionRepositoryBase<ProductSubcategory>, IProductSubCategoryRepository
    {
        public ProductSubCategoryRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void edit(ProductSubcategory productSubCategory)
        {
            Update(productSubCategory);
        }

        public async Task<IEnumerable<ProductSubcategory>> GetAllProdcSubCategory(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(c => c.ProductSubcategoryId).ToListAsync();
        }

        public async Task<ProductSubcategory> GetProcdSubCateById(int prodcSubCategory, bool trackChanges)
        {
            return await FindByCondition(c => c.ProductSubcategoryId.Equals(prodcSubCategory), trackChanges).SingleOrDefaultAsync();
        }

        public void insert(ProductSubcategory productSubCategory)
        {
            Create(productSubCategory);
        }

        public void remove(ProductSubcategory productSubCategory)
        {
            Delete(productSubCategory);
        }
    }
}
