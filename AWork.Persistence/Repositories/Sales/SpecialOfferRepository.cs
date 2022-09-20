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
    public class SpecialOfferRepository : RepositoryBase<SpecialOffer>, ISpecialOfferRepository
    {
        public SpecialOfferRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Edit(SpecialOffer specialOffer)
        {
            Update(specialOffer);
        }

        public async Task<IEnumerable<SpecialOffer>> GetAllSpecialOffer(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(c => c.SpecialOfferId).ToListAsync();
        }

        public async Task<SpecialOffer> GetSpecialOfferById(int specialOfferId, bool trackChanges)
        {
            return await FindByCondition(c => c.SpecialOfferId.Equals(specialOfferId), trackChanges).SingleOrDefaultAsync();
        }

        public void Insert(SpecialOffer specialOffer)
        {
            Create(specialOffer);
        }

        public void Remove(SpecialOffer specialOffer)
        {
            Delete(specialOffer);
        }
    }
}
