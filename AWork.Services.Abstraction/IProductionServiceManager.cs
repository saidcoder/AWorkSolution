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
        /*ICategoryServices CategoryServices { get; }*/

        IUnitMeasureService UnitMeasureservice { get;  }
    }
}
