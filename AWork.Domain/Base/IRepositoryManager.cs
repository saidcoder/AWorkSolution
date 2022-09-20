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
        ISpecialOfferRepository SpecialOfferRepository { get; }
        ISpecialOfferProductRepository SpecialOfferProductRepository { get; }
        ISalesOrderDetailRepository SalesOrderDetailRepository { get; }

        void Save();

        Task SaveAsync();
    }
}
