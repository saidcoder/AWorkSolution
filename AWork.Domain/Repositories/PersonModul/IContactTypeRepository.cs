using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.PersonModul
{
    public interface IContactTypeRepository
    {
        Task<IEnumerable<ContactType>> GetAllContactType(bool trackChanges);
        Task<ContactType> GetAllContactTypeById(int contactId, bool trackChanges);
        void Insert(ContactType contactType);
        void Edit(ContactType contactType);
        void Remove(ContactType contactType);
    }
}
