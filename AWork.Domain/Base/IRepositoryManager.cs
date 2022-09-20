using AWork.Domain.Repositories.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Base
{
    public interface IRepositoryManager
    {
        /*ICategoryRepository CategoryRepository { get; }*/
        ICreditCardRepository CreditCardRepository { get; }
        IPersonCreditCardRepository PersonCreditCard { get; }
        ISalesOrderHeaderRepository SalesOrderHeader { get; }

        void Save();

        Task SaveAsync();
    }
}
