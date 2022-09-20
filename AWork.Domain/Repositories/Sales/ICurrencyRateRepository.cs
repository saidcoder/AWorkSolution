using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.Sales
{
    public interface ICurrencyRateRepository
    {
        Task<IEnumerable<CurrencyRate>> GetAllAsync(bool trackChanges);
        Task<CurrencyRate> GetByIdAsync(int currencyRateId ,bool trackChanges);
        void Insert(CurrencyRate currencyRate);
        void Remove(CurrencyRate currencyRate);
        void Change(CurrencyRate currencyRate);

    }
}
