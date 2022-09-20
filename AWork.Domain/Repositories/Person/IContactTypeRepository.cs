using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AWork.Domain.Models;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.Person
{
    public interface IContactTypeRepository
    {
        Task<IEnumerable<ContactType>> GetAllCategory(bool trackChanges);

        Task<ContactType> GetCategoryById(int contactTypeId, bool trackChanges);

        void Insert(ContactType contactType);

        void Edit(ContactType contactType);

        void Remove(ContactType contactType);
    }
}
