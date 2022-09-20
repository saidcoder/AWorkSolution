using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.Purchasing
{
    public interface IVendorRepository
    {
        Task<IEnumerable<Vendor>> GetAllVendor(bool trackChanges);

        Task<Vendor> GetVendorById(int id, bool trackChanges);

        void Insert(Vendor vendor);

        void Edit(Vendor vendor);

        void Remove(Vendor vendor);
    }
}
