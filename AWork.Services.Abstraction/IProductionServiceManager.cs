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
        IProductPhotoService ProductPhotoService { get; }
        /*ICategoryServices CategoryServices { get; }*/
    }
}
