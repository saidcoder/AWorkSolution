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
        private IContactTypeRepository _contactTypeRepository;
        private IPasswordRepository _passwordRepository;
        private IPersonPhoneRepository _personPhoneRepository;
        private IAddressTypeRepository _addressTypeRepository;
        public RepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }


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
        public IPasswordRepository PasswordRepository
        {
            get
            {
                if (_passwordRepository == null)
                {
                    _passwordRepository = new PasswordRepository(_dbContext);
                }
                return _passwordRepository;
            }
        }
        public IPersonPhoneRepository PersonPhoneRepository
        {
            get
            {
                if (_personPhoneRepository == null)
                {
                    _personPhoneRepository = new PersonPhoneRepository(_dbContext);
                }
                return _personPhoneRepository;
            }
        }

        public IAddressTypeRepository AddressTypeRepository
        {
            get
            {
                if (_addressTypeRepository == null)
                {
                    _addressTypeRepository = new AddressTypeRepository(_dbContext);
                }
                return _addressTypeRepository;
            }
        }

        public void Save () => _dbContext.SaveChanges();
        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();

    }
}
