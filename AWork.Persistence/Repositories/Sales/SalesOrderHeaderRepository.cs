using AWork.Domain.Models;
using AWork.Domain.Repositories.Sales;
using AWork.Persistence.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Persistence.Repositories.Sales
{
    internal class SalesOrderHeaderRepository : RepositoryBase<SalesOrderHeader>, ISalesOrderHeaderRepository
    {
        public SalesOrderHeaderRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Change(SalesOrderHeader salesorderHeader)
        {
            Update(salesorderHeader);
        }

        public Task<IEnumerable<SalesOrderHeader>> GetAllSalesOrderHeader(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<SalesOrderHeader> GetByIdSalesOrderHeader(int salesorderHeader, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Insert(SalesOrderHeader salesorderHeader)
        {
            Create(salesorderHeader);
        }

        public void Remove(SalesOrderHeader salesorderHeader)
        {
            Delete(salesorderHeader);
        }
    }
}
