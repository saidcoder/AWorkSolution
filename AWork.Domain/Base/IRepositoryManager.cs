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
        ICurrencyRepository CurrencyRepository { get; }
        ICurrencyRateRepository CurrencyRateRepository { get; }
        IStoreRepository StoreRepository { get; }

        void Save();

        Task SaveAsync();
    }
}
