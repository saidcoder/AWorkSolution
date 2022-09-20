using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.Sales
{
    public interface IPersonCreditCardRepository
    {
        Task<IEnumerable<PersonCreditCard>> GetAllPersonCreditCard(bool trackChanges);

        Task<PersonCreditCard> GetByIdPersonCreditCard(int personCreditCardId, bool trackChanges);

        void Insert(PersonCreditCard personCreditCard);
        void Remove(PersonCreditCard personCreditCard);
        void Change(PersonCreditCard personCreditCard);
        
    }
}
