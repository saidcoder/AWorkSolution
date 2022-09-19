using AWork.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services
{
    public class ServiceManager : IServiceManager
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
    }
}
