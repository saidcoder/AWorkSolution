using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AWork.Domain.Models;
using AWork.Persistence;
using AWork.Services.Abstraction;
using AWork.Contracts.Dto.Sales.SalesTerritory;

namespace AWork.Web.Controllers.Sales
{
    public class SalesTerritoriesServiceController : Controller
    {
        //private readonly AdventureWorks2019Context _context;
        private readonly ISalesServiceManager _serviceContext;

        public SalesTerritoriesServiceController(ISalesServiceManager serviceManager)
        {
            //_context = context;
            _serviceContext = serviceManager;
        }

        // GET: SalesTerritoriesService
        public async Task<IActionResult> Index()
        {
            /*var adventureWorks2019Context = _context.SalesTerritories.Include(s => s.CountryRegionCodeNavigation);
            return View(await adventureWorks2019Context.ToListAsync());*/
            //var salesTerritory = await _context.SalesTerritories.ToListAsync();
            var salesTerritoryDto = await _serviceContext.SalesTerritoryService.GetAllSalesTerritory(false);
            return View(salesTerritoryDto);
        }

        // GET: SalesTerritoriesService/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*var salesTerritory = await _context.SalesTerritories
                .Include(s => s.CountryRegionCodeNavigation)
                .FirstOrDefaultAsync(m => m.TerritoryId == id);*/
            var salesTerritory = await _serviceContext.SalesTerritoryService.GetSalesTerritoryById((int)id, false);
            if (salesTerritory == null)
            {
                return NotFound();
            }

            return View(salesTerritory);
        }

        // GET: SalesTerritoriesService/Create
        public IActionResult Create()
        {
            //ViewData["CountryRegionCode"] = new SelectList(_context.CountryRegions, "CountryRegionCode", "CountryRegionCode");
            return View();
        }

        // POST: SalesTerritoriesService/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,CountryRegionCode,Group,SalesYtd,SalesLastYear,CostYtd,CostLastYear,Rowguid,ModifiedDate")] SalesTerritoryForCreateDto salesTerritory)
        {
            if (ModelState.IsValid)
            {
                /*_context.Add(salesTerritory);
                await _context.SaveChangesAsync();*/
                _serviceContext.SalesTerritoryService.Insert(salesTerritory);
                return RedirectToAction(nameof(Index));
            }
            //ViewData["CountryRegionCode"] = new SelectList(_context.CountryRegions, "CountryRegionCode", "CountryRegionCode", salesTerritory.CountryRegionCode);
            return View(salesTerritory);
        }

        // GET: SalesTerritoriesService/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*var salesTerritory = await _context.SalesTerritories.FindAsync(id);*/
            var salesTerritory = await _serviceContext.SalesTerritoryService.GetSalesTerritoryById((int)id, true);
            if (salesTerritory == null)
            {
                return NotFound();
            }
            //ViewData["CountryRegionCode"] = new SelectList(_context.CountryRegions, "CountryRegionCode", "CountryRegionCode", salesTerritory.CountryRegionCode);
            return View(salesTerritory);
        }

        // POST: SalesTerritoriesService/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TerritoryId,Name,CountryRegionCode,Group,SalesYtd,SalesLastYear,CostYtd,CostLastYear,Rowguid,ModifiedDate")] SalesTerritoryDto salesTerritoryDto)
        {
            if (id != salesTerritoryDto.TerritoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    /*_context.Update(salesTerritory);
                    await _context.SaveChangesAsync();*/
                    _serviceContext.SalesTerritoryService.Edit(salesTerritoryDto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    /*if (!SalesTerritoryExists(salesTerritory.TerritoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }*/
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            //ViewData["CountryRegionCode"] = new SelectList(, "CountryRegionCode", "CountryRegionCode", salesTerritoryDto.CountryRegionCode);
            return View(salesTerritoryDto);
        }

        // GET: SalesTerritoriesService/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*var salesTerritory = await _context.SalesTerritories
                .Include(s => s.CountryRegionCodeNavigation)
                .FirstOrDefaultAsync(m => m.TerritoryId == id);*/
            var salesTerritory = await _serviceContext.SalesTerritoryService.GetSalesTerritoryById((int)id, false);
            if (salesTerritory == null)
            {
                return NotFound();
            }

            return View(salesTerritory);
        }

        // POST: SalesTerritoriesService/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            /*var salesTerritory = await _context.SalesTerritories.FindAsync(id);
            _context.SalesTerritories.Remove(salesTerritory);
            await _context.SaveChangesAsync();*/
            var salesTerritory = await _serviceContext.SalesTerritoryService.GetSalesTerritoryById((int)id, false);
            _serviceContext.SalesTerritoryService.Remove(salesTerritory);
            return RedirectToAction(nameof(Index));
        }

        /*private bool SalesTerritoryExists(int id)
        {
            return _context.SalesTerritories.Any(e => e.TerritoryId == id);
        }*/
    }
}
