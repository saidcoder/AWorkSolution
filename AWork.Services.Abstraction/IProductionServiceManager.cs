using AWork.Domain.Repositories.Production;
using AWork.Services.Abstraction.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction
{
    public interface IProductionServiceManager
    {
        ILocationService LocationService { get; }
        /*ICategoryServices CategoryServices { get; }*/
    }
}
