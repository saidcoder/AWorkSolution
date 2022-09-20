using AWork.Contracts.Dto.Sales.SalesTerritory;
using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Contracts.Dto.Sales.SalesPerson
{
    public class SalesPersonForCreateDto
    {
        public int? TerritoryId { get; set; }
        public decimal? SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYtd { get; set; }
        public decimal SalesLastYear { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Employee BusinessEntity { get; set; }
        public virtual SalesTerritoryDto Territory { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
