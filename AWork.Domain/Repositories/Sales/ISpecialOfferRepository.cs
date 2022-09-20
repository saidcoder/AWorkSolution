using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.Sales
{
    public interface ISpecialOfferRepository
    {
        Task<IEnumerable<SpecialOffer>> GetAllSpecialOffer(bool trackChanges);
        Task<SpecialOffer> GetSpecialOfferById(int specialOfferId, bool trackChanges);
        void Insert(SpecialOffer specialOffer);
        void Edit(SpecialOffer specialOffer);
        void Remove(SpecialOffer specialOffer);
    }
}
