using AWork.Domain.Models;
using AWork.Domain.Repositories.PersonModul;
using AWork.Persistence.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Persistence.Repositories.PersonModul
{
    public class ContactTypeRepository : RepositoryBase<ContactType>, IContactTypeRepository
    {
        public ContactTypeRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Edit(ContactType contactType)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ContactType>> GetAllContactType(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<ContactType> GetAllContactTypeById(int contactId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Insert(ContactType contactType)
        {
            throw new NotImplementedException();
        }

        public void Remove(ContactType contactType)
        {
            throw new NotImplementedException();
        }
    }
}
