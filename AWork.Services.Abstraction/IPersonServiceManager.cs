using AWork.Services.Abstraction.PersonModul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction
{
    public interface IPersonServiceManager
    {
        /*ICategoryServices CategoryServices { get; }*/
        IBusinessEntityServices BusinessEntityServices { get; }
        IPersonServices _personServices { get; }
        IStateProvinceServices _stateProvinceServices { get; }
        IAddressServices _addressServices { get; }
        IContactTypeServices _contactTypeServices { get; }
        ICountryRegionServices _countryRegionServices { get; }
    }
}
