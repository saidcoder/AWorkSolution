using AWork.Domain.Models;
using AWork.Domain.Repositories.Sales;
using AWork.Persistence.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Persistence.Repositories.Sales
{
    public class CreditCardRepository : RepositoryBase<CreditCard>, ICreditCardRepository
    {
        public CreditCardRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Change(CreditCard creditCard)
        {
            Update(creditCard);
        }

     
        public Task<IEnumerable<CreditCard>> GetAllCreditCard(bool trackChanges)
        {
            throw new NotImplementedException();
        }

 

        public Task<CreditCard> GetCreditCardById(int CreditCardId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

 

        public void Insert(CreditCard creditCard)
        {
            Create(creditCard);
        }

        public void Remove(CreditCard creditCard)
        {
            Delete(creditCard);
        }
    }
}
