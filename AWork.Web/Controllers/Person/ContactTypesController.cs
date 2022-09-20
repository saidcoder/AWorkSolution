using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AWork.Domain.Models;
using AWork.Persistence;
using AWork.Domain.Base;

namespace AWork.Web.Controllers.Person
{
    public class ContactTypesController : Controller
    {
/*        private readonly AdventureWorks2019Context _context;*/

        private readonly IRepositoryManager _context;
        public ContactTypesController(IRepositoryManager context)
        {
            _context = context;
        }

        // GET: ContactTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactTypeRepository.GetAllCategory(false));
        }

        // GET: ContactTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*            var contactType = await _context.ContactTypes
                            .FirstOrDefaultAsync(m => m.ContactTypeId == id);*/
            var contactType = await _context.ContactTypeRepository.GetCategoryById((int)id, false);
            if (contactType == null)
            {
                return NotFound();
            }

            return View(contactType);
        }

        // GET: ContactTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContactTypeId,Name,ModifiedDate")] ContactType contactType)
        {
            if (ModelState.IsValid)
            {
                /*                _context.Add(contactType);
                                await _context.SaveChangesAsync();
                */
                _context.ContactTypeRepository.Insert(contactType);
                await _context.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactType);
        }

        // GET: ContactTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*            var contactType = await _context.ContactTypes.FindAsync(id);*/
            var contactType = await _context.ContactTypeRepository.GetCategoryById((int)id, true);
            if (contactType == null)
            {
                return NotFound();
            }
            return View(contactType);
        }

        // POST: ContactTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContactTypeId,Name,ModifiedDate")] ContactType contactType)
        {
            if (id != contactType.ContactTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    /*                    _context.Update(contactType);
                                        await _context.SaveChangesAsync();*/
                    _context.ContactTypeRepository.Edit(contactType);
                    await _context.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    /*                    if (!ContactTypeExists(contactType.ContactTypeId))
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
            return View(contactType);
        }

        // GET: ContactTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

/*            var contactType = await _context.ContactTypes
                .FirstOrDefaultAsync(m => m.ContactTypeId == id);*/
            var contactType =await _context.ContactTypeRepository.GetCategoryById((int)id, false);
            if (contactType == null)
            {
                return NotFound();
            }

            return View(contactType);
        }

        // POST: ContactTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            /*            var contactType = await _context.ContactTypes.FindAsync(id);
                        _context.ContactTypes.Remove(contactType);
            */
            var contactType = await _context.ContactTypeRepository.GetCategoryById((int)id, false);
            _context.ContactTypeRepository.Remove(contactType);
            await _context.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

/*        private bool ContactTypeExists(int id)
        {
            return _context.ContactTypes.Any(e => e.ContactTypeId == id);
        }*/
    }
}
