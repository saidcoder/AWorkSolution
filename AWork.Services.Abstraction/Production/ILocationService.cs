using AWork.Contracts.Dto.Production;
using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.Production
{
    public interface ILocationService
    {
        Task<IEnumerable<LocationDto>> GetAllLocation(bool trackChange);

        Task<LocationDto> GetLocationById(int locationId, bool trackChange);

        void Insert(LocationDto location);

        void Edit(LocationDto location);

        void Remove(LocationDto location);
    }
}
