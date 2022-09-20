using AWork.Contracts.Dto.Sales.SalesTerritory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.Sales
{
    public interface ISalesTerritoryService
    {
        Task<IEnumerable<SalesTerritoryDto>> GetAllSalesTerritory(bool trackChanges);
        Task<SalesTerritoryDto> GetSalesTerritoryById(int territoryId, bool trackChanges);

        void Insert(SalesTerritoryForCreateDto salesTerritoryForCreateDto);

        void Edit(SalesTerritoryDto salesTerritoryDto);

        void Remove(SalesTerritoryDto salesTerritoryDto);
    }
}
