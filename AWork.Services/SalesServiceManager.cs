using AutoMapper;
using AWork.Domain.Base;
using AWork.Domain.Models;
using AWork.Services.Abstraction;
using AWork.Services.Abstraction.Sales;
using AWork.Services.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services
{
    public class SalesServiceManager : ISalesServiceManager
    {
        //private readonly ISalesRepositoryManager _salesRepositoryManager;
        private readonly Lazy<ISalesTerritoryService> _lazySalesTerritoryService;
        private readonly Lazy<ISalesPersonService> _lazySalesPersonService;

        public SalesServiceManager(ISalesRepositoryManager repositoryManager, IMapper mapper)
        {
            //_salesRepositoryManager = repositoryManager;
            _lazySalesTerritoryService = new Lazy<ISalesTerritoryService>(() => new SalesTerritoryService(repositoryManager, mapper));
            _lazySalesPersonService = new Lazy<ISalesPersonService>(() => new SalesPersonService(repositoryManager, mapper));
        }

        public ISalesTerritoryService SalesTerritoryService => _lazySalesTerritoryService.Value;

        public ISalesPersonService SalesPersonService => _lazySalesPersonService.Value;
    }
}
