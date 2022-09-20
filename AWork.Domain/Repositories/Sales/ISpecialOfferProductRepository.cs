using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.Sales
{
    public interface ISpecialOfferProductRepository
    {
        Task<IEnumerable<SpecialOfferProduct>> GetAllSpecialOfferProduct(bool trackChanges);
        Task<SpecialOfferProduct> GetSpecialOfferProductById(int specialOfferProductId, bool trackChanges);
        void Insert(SpecialOfferProduct specialOfferProduct);
        void Edit(SpecialOfferProduct specialOfferProduct);
        void Remove(SpecialOfferProduct specialOfferProduct);
    }
}
