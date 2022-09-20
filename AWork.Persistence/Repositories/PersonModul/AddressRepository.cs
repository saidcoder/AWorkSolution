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
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Edit(Address address)
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetAllAddressById(int addressId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetAllAdress(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Insert(Address address)
        {
            throw new NotImplementedException();
        }

        public void Remove(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
