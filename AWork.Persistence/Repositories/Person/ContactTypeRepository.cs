using AWork.Domain.Models;
using AWork.Domain.Repositories.Person;
using AWork.Persistence.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Persistence.Repositories.Person
{
    public class ContactTypeRepository : RepositoryBase<ContactType>, IContactTypeRepository
    {
        public ContactTypeRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Edit(ContactType contactType)
        {
            Update(contactType);
        }

        public async Task<IEnumerable<ContactType>> GetAllContactType(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(a => a.ContactTypeId).ToListAsync();
        }

        public async Task<ContactType> GetContactTypeId(int contactTypeId, bool trackChanges)
        {
            return await FindByCondition(c => c.ContactTypeId.Equals(contactTypeId), trackChanges).SingleOrDefaultAsync();
        }

        public void Insert(ContactType contactType)
        {
            Create(contactType);
        }

        public void Remove(ContactType contactType)
        {
            Delete(contactType);
        }
    }
}
