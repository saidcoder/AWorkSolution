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
    public class PersonCreditCardRepository : RepositoryBase<PersonCreditCard>, IPersonCreditCardRepository
    {
        public PersonCreditCardRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Change(PersonCreditCard personCreditCard)
        {
            Update(personCreditCard);
        }

        public Task<IEnumerable<PersonCreditCard>> GetAllPersonCreditCard(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<PersonCreditCard> GetByIdPersonCreditCard(int personCreditCardId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Insert(PersonCreditCard personCreditCard)
        {
            Create(personCreditCard);
        }

        public void Remove(PersonCreditCard personCreditCard)
        {
            Delete(personCreditCard);
        }
    }
}
