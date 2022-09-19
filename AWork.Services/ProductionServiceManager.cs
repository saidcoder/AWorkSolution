using AutoMapper;
using AWork.Domain.Base;
using AWork.Domain.Repositories.Production;
using AWork.Services.Abstraction;
using AWork.Services.Abstraction.Production;
using AWork.Services.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services
{
    public class ProductionServiceManager : IProductionServiceManager
    {
        // CONTOH SERVICE
        /*private readonly Lazy<ICategoryServices> _lazyCategoryService;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _lazyCategoryService = new Lazy<ICategoryServices>(
                () => new CategoryService(repositoryManager, mapper)
                );
        }

        public ICategoryServices CategoryServices => _lazyCategoryService.Value;*/

        private readonly Lazy<ILocationService> _lazyLocationService;
        public ProductionServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _lazyLocationService = new Lazy<ILocationService>(
                ()=> new LocationService(repositoryManager,mapper));
        }
        public ILocationService LocationService => _lazyLocationService.Value;
    }
}
