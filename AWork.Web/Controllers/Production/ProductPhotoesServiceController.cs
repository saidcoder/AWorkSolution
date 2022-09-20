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
using AWork.Contracts.Dto.Production;

namespace AWork.Web.Controllers.Production
{
    public class ProductPhotoesServiceController : Controller
    {
        private readonly AdventureWorks2019Context _context;
        private readonly IProductionServiceManager _productionserviceContext;

        public ProductPhotoesServiceController(AdventureWorks2019Context context , IProductionServiceManager productionserviceContext = null)
        {
            _context = context;
            _productionserviceContext = productionserviceContext;
        }

        // GET: ProductPhotoesService
        public async Task<IActionResult> Index()
        {
            var productPhoto = await _context.ProductPhotos.ToListAsync();
            var productPhotoDto = await _productionserviceContext.ProductPhotoService.GetAllProductPhoto(false);
            //return View(await _context.ProductPhotos.ToListAsync());
            return View(productPhotoDto);
        }

        // GET: ProductPhotoesService/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            /*var productPhoto = await _context.ProductPhotos
                 .FirstOrDefaultAsync(m => m.ProductPhotoId == id);*/
            var productPhotoDto = await _productionserviceContext.ProductPhotoService.GetProductPhotoById((int)id, false);
            if (productPhotoDto == null)
            {
                return NotFound();
            }

            return View(productPhotoDto);
        }

        // GET: ProductPhotoesService/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductPhotoesService/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ThumbNailPhoto,ThumbnailPhotoFileName,LargePhoto,LargePhotoFileName,ModifiedDate")] ProductPhotoForCreateDto productPhotoForCreateDto)
        {
            if (ModelState.IsValid)
            {
                _productionserviceContext.ProductPhotoService.Insert(productPhotoForCreateDto);
                /*_context.Add(productPhoto);
                await _context.SaveChangesAsync();*/
                return RedirectToAction(nameof(Index));
            }
            return View(productPhotoForCreateDto);
        }

        // GET: ProductPhotoesService/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productPhoto = await _productionserviceContext.ProductPhotoService.GetProductPhotoById((int)id,true);
            //var productPhoto = await _context.ProductPhotos.FindAsync(id);
            if (productPhoto == null)
            {
                return NotFound();
            }
            return View(productPhoto);
        }

        // POST: ProductPhotoesService/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductPhotoId,ThumbNailPhoto,ThumbnailPhotoFileName,LargePhoto,LargePhotoFileName,ModifiedDate")] ProductPhotoDto productPhotoDto)
        {
            if (id != productPhotoDto.ProductPhotoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    /*_context.Update(productPhoto);
                    await _context.SaveChangesAsync();*/
                    _productionserviceContext.ProductPhotoService.Edit(productPhotoDto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductPhotoExists(productPhotoDto.ProductPhotoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productPhotoDto);
        }

        // GET: ProductPhotoesService/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var productPhoto = await _context.ProductPhotos
            //.FirstOrDefaultAsync(m => m.ProductPhotoId == id);
            var productPhoto = await _productionserviceContext.ProductPhotoService.GetProductPhotoById((int)id, false);
            if (productPhoto == null)
            {
                return NotFound();
            }

            return View(productPhoto);
        }

        // POST: ProductPhotoesService/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productPhotoModel1 = await _productionserviceContext.ProductPhotoService.GetProductPhotoById((int)id, false);
            _productionserviceContext.ProductPhotoService.Remove(productPhotoModel1);
            /*var productPhoto = await _context.ProductPhotos.FindAsync(id);
            _context.ProductPhotos.Remove(productPhoto);
            await _context.SaveChangesAsync();*/
            return RedirectToAction(nameof(Index));
        }

        private bool ProductPhotoExists(int id)
        {
            return _context.ProductPhotos.Any(e => e.ProductPhotoId == id);
        }
    }
}
