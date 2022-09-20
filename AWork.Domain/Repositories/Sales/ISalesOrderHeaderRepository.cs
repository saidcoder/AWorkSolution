using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.Sales
{
    public interface ISalesOrderHeaderRepository
    {
        Task<IEnumerable<SalesOrderHeader>>GetAllSalesOrderHeader(bool trackChanges);
        Task<SalesOrderHeader> GetByIdSalesOrderHeader(int salesorderHeader, bool trackChanges);
        void Insert(SalesOrderHeader salesorderHeader);
        void Remove(SalesOrderHeader salesorderHeader);
        void Change(SalesOrderHeader salesorderHeader);
        
    }
}
