using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.Production
{
    public interface ILocationRepository
    {
        Task<IEnumerable<Location>> GetAllLocation(bool trackChange);

        Task<Location> GetLocationById(int locationId, bool trackChange);

        void Insert (Location location);

        void Edit (Location location);

        void Remove (Location location);
    }
}
