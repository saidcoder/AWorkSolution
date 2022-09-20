using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.PersonModul
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetAllPerson(bool trackChanges);
        Task<Person> GetPersonById(int personId, bool trackChanges);
        void Insert(Person person);
        void Edit(Person person);
        void Remove(Person person);
    }
}
