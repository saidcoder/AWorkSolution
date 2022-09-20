
using AWork.Domain.Repositories.PersonModul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Base
{
    public interface IPersonRepositoryManager
    {
        /*ICategoryRepository CategoryRepository { get; }*/
        IBusinessEntityRepository BusinessEntityRepository { get; }
        IPersonRepository _personRepository { get; }
        IStateProvinceRepository _stateProvinceRepository { get; }
        IAddressRepository _addressRepository { get; }
        IContactTypeRepository _contactTypeRepository { get; }
        ICountryRegionRepository _countryRegionRepository { get; }

        void Save();

        Task SaveAsync();   
    }
}
