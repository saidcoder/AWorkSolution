using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.Sales
{
    public interface ISalesPersonRepository
    {
        Task<IEnumerable<SalesPerson>> GetAllSalesPerson(bool trackChanges);

        Task<SalesPerson> GetSalesPersonById(int businessEntityId, bool trackChanges);

        void Insert(SalesPerson salesTeritory);

        void Edit(SalesPerson salesTeritory);

        void Remove(SalesPerson salesTeritory);
    }
}
