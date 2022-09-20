using AWork.Persistence;
using AWork.Domain.Base;
using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWork.Domain.Repositories.Person;
using AWork.Persistence.Repositories.Person;

namespace AWork.Persistence.Base
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly AdventureWorks2019Context _dbContext;
        /*private ICategoryRepository _categoryRepository;*/
        
        public RepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }

        private IContactTypeRepository _contactTypeRepository;



        public IContactTypeRepository ContactTypeRepository
        {
            get
            {
                if (_contactTypeRepository == null)
                {
                    _contactTypeRepository = new ContactTypeRepository(_dbContext);
                }
                return _contactTypeRepository;
            }
        }



        public void Save () => _dbContext.SaveChanges();
        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();

    }
}
