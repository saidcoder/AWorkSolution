using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.Sales
{
    public interface IShoppingCartItemRepository
    {
        Task<IEnumerable<ShoppingCartItem>> GetAllShoppingCartItem(bool trackChanges);

        Task<ShoppingCartItem> GetShoppingCartItemById(int shoppingCartItemId, bool trackChanges);

        void Insert(ShoppingCartItem shoppingCartItem);

        void Edit(ShoppingCartItem shoppingCartItem);

        void Remove(ShoppingCartItem shoppingCartItem);
    }
}
