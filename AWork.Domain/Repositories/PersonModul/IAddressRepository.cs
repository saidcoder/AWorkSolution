using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.PersonModul
{
    public interface IAddressRepository
    {
        Task<IEnumerable<Address>> GetAllAdress(bool trackChanges);
        Task<Address> GetAllAddressById(int addressId, bool trackChanges);
        void Insert(Address address);
        void Edit(Address address);
        void Remove(Address address);
    }
}
