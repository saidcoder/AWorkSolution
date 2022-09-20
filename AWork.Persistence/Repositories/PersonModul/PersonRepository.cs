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
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Edit(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Person>> GetAllPerson(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetPersonById(int personId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Insert(Person person)
        {
            throw new NotImplementedException();
        }

        public void Remove(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
