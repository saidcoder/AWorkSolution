using AWork.Services.Abstraction.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction
{
    public interface ISalesServiceManager
    {
        ISalesTerritoryService SalesTerritoryService { get; }
        ISalesPersonService SalesPersonService { get; }
    }
}
