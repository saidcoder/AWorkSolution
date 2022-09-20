using AWork.Domain.Models;
using AWork.Domain.Repositories.Sales;
using AWork.Persistence.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Persistence.Repositories.Sales
{
    public class SpecialOfferProductRepository : RepositoryBase<SpecialOfferProduct>, ISpecialOfferProductRepository
    {
        public SpecialOfferProductRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Edit(SpecialOfferProduct specialOfferProduct)
        {
            Update(specialOfferProduct);
        }

        public async Task<IEnumerable<SpecialOfferProduct>> GetAllSpecialOfferProduct(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(c => c.SpecialOfferProductId).ToListAsync();
        }

        public async Task<SpecialOfferProduct> GetSpecialOfferProductById(int specialOfferProductId, bool trackChanges)
        {
            return await FindByCondition(c => c.SpecialOfferProductId.Equals(specialOfferProductId), trackChanges).SingleOrDefaultAsync();
        }

        public void Insert(SpecialOfferProduct specialOfferProduct)
        {
            Create(specialOfferProduct);
        }

        public void Remove(SpecialOfferProduct specialOfferProduct)
        {
            Delete(specialOfferProduct);
        }
    }
}
