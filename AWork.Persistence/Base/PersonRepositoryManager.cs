using AWork.Persistence;
using AWork.Domain.Base;
using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWork.Domain.Repositories.PersonModul;
using AWork.Persistence.Repositories.PersonModul;

namespace AWork.Persistence.Base
{
    public class PersonRepositoryManager : IPersonRepositoryManager
    {
        private AdventureWorks2019Context _dbContext;
        /*private ICategoryRepository _categoryRepository;*/
        private IBusinessEntityRepository _businessEntityRepository;
        private IPersonRepository _personRepository;
        private IStateProvinceRepository _stateProvinceRepository;
        private IAddressRepository _addressRepository;
        private IContactTypeRepository _contactTypeRepository;
        private ICountryRegionRepository _countryRegionRepository;
        public PersonRepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }

        public IBusinessEntityRepository BusinessEntityRepository
        {
            get
            {
                if (_businessEntityRepository == null)
                {
                    _businessEntityRepository = new BusinessEntityRepository(_dbContext);
                }
                return _businessEntityRepository;
            }
            
        }


        IPersonRepository IPersonRepositoryManager._personRepository
        {
            get
            {
                if(_personRepository == null)
                {
                    _personRepository = new PersonRepository(_dbContext);
                }
                return _personRepository;
            }
        }

        IStateProvinceRepository IPersonRepositoryManager._stateProvinceRepository
        {
            get
            {
                if (_stateProvinceRepository == null)
                {
                    _stateProvinceRepository = new StateProvinceRepository(_dbContext);
                }
                return _stateProvinceRepository;
            }
        }

        IAddressRepository IPersonRepositoryManager._addressRepository
        {
            get
            {
                if(_addressRepository == null)
                {
                    _addressRepository = new AddressRepository(_dbContext);
                }
                return _addressRepository;
            }
        }

        IContactTypeRepository IPersonRepositoryManager._contactTypeRepository
        {
            get
            {
                if(_contactTypeRepository == null)
                {
                    _contactTypeRepository = new ContactTypeRepository(_dbContext);
                }
                return _contactTypeRepository;
            }
        }

        ICountryRegionRepository IPersonRepositoryManager._countryRegionRepository
        {
            get
            {
                if(_countryRegionRepository == null)
                {
                    _countryRegionRepository = new CountryRegionRepository(_dbContext);
                }
                return _countryRegionRepository;
            }
        }





        /*public ICategoryRepository CategoryRepository
{
get {
if (_categoryRepository == null)
{
_categoryRepository = new CategoryRepository(_dbContext);
}
return _categoryRepository; 
}
}*/



        public void Save () => _dbContext.SaveChanges();
        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();

    }
}
