using AutoMapper;
using AWork.Domain.Base;
using AWork.Services.Abstraction;
using AWork.Services.Abstraction.Purchasing;
using AWork.Services.Purchasing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services
{
    public class PurchasingServiceManager : IPurchasingServiceManager
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly Lazy<IShipMethodService> _lazyShipMethodService;
        public PurchasingServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _lazyShipMethodService = new Lazy<IShipMethodService>(
                () => new ShipMethodService(repositoryManager, mapper)
                );
        }

        public IShipMethodService ShipMethodService => _lazyShipMethodService.Value;
    }
}
