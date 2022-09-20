using AWork.Domain.Repositories.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Base
{
    public interface ISalesRepositoryManager
    {
        ISalesTerritoryRepository SalesTerritoryRepository { get; }
        ISalesPersonRepository SalesPersonRepository { get; }
        IShoppingCartItemRepository ShoppingCartItemRepository { get; }
        ICustomerRepository CustomerRepository { get; }

        void Save();

        Task SaveAsync();
    }
}
