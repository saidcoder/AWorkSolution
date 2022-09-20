using System;
using AWork.Contracts.Dto.Purchasing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWork.Contracts.Dto.Purchasing.ShipMethod;

namespace AWork.Services.Abstraction.Purchasing
{
    public interface IShipMethodService
    {
        Task<IEnumerable<ShipMethodDto>> GetAllShipMethod(bool trackChanges);

        Task<ShipMethodDto> GetShipMethodById(int id, bool trackChanges);

        void Insert(ShipMethodForCreateDto shipMethod);

        void Edit(ShipMethodDto shipMethod);

        void Remove(ShipMethodDto shipMethod);
    }
}
