using AutoMapper;
using AWork.Domain.Base;
using AWork.Services.Abstraction;
using AWork.Services.Abstraction.PersonModul;
using AWork.Services.PersonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services
{
    public class PersonServiceManager : IPersonServiceManager
    {
        private readonly Lazy<IBusinessEntityServices> _lazybusinessEntityServices;
        private readonly Lazy<IPersonServices> _lazypersonServices;
        private readonly Lazy<IStateProvinceServices> _lazystateProvinceServices;
        private readonly Lazy<IAddressServices> _lazyAddressServices;
        private readonly Lazy<IContactTypeServices> _lazycontactTypeServices;
        private readonly Lazy<ICountryRegionServices> _lazycountryRegionServices;
        public PersonServiceManager(IPersonRepositoryManager repositoryManager, IMapper mapper)
        {
            _lazybusinessEntityServices = new Lazy<IBusinessEntityServices>(
                () => new BusinessEntityServices(repositoryManager, mapper)
                ) ;

        }

        public IBusinessEntityServices BusinessEntityServices => _lazybusinessEntityServices.Value;

        public IPersonServices _personServices => _lazypersonServices.Value;

        public IStateProvinceServices _stateProvinceServices => _lazystateProvinceServices.Value;

        public IAddressServices _addressServices => _lazyAddressServices.Value;

        public IContactTypeServices _contactTypeServices => _lazycontactTypeServices.Value;

        public ICountryRegionServices _countryRegionServices => _lazycountryRegionServices.Value;
    }
}
