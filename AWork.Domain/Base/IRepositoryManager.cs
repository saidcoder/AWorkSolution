using AWork.Domain.Repositories.Purchasing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Base
{
    public interface IRepositoryManager
    {
        IShipMethodRepository ShipMethodRepository { get; }

        void Save();

        Task SaveAsync();
    }
}
