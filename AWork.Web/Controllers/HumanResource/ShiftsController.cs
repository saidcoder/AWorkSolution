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

namespace AWork.Web.Controllers.HumanResource
{
    public class ShiftsController : Controller
    {
        //private readonly AdventureWorks2019Context _context;
        private readonly IRepositoryManager _context;

        public ShiftsController(IRepositoryManager context)
        {
            _context = context;
        }

        // GET: Shifts
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShiftRepository.GetAllShift(false));
        }

        // GET: Shifts/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*var shift = await _context.Shifts
                .FirstOrDefaultAsync(m => m.ShiftId == id);*/
            var shift = await _context.ShiftRepository.GetShiftById((byte)id, false);
            if (shift == null)
            {
                return NotFound();
            }

            return View(shift);
        }

        // GET: Shifts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shifts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShiftId,Name,StartTime,EndTime,ModifiedDate")] Shift shift)
        {
            if (ModelState.IsValid)
            {
                /*_context.Add(shift);
                await _context.SaveChangesAsync();*/
                _context.ShiftRepository.Insert(shift);
                await _context.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shift);
        }

        // GET: Shifts/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var shift = await _context.Shifts.FindAsync(id);
            var shift = await _context.ShiftRepository.GetShiftById((byte)id, true);
            if (shift == null)
            {
                return NotFound();
            }
            return View(shift);
        }

        // POST: Shifts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("ShiftId,Name,StartTime,EndTime,ModifiedDate")] Shift shift)
        {
            if (id != shift.ShiftId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    /*_context.Update(shift);
                    await _context.SaveChangesAsync();*/
                    _context.ShiftRepository.Edit(shift);
                    await _context.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    /*if (!ShiftExists(shift.ShiftId))
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
            return View(shift);
        }

        // GET: Shifts/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*var shift = await _context.Shifts
                .FirstOrDefaultAsync(m => m.ShiftId == id);*/
            var shift = await _context.ShiftRepository.GetShiftById((byte)id, false);
            if (shift == null)
            {
                return NotFound();
            }

            return View(shift);
        }

        // POST: Shifts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            /*var shift = await _context.Shifts.FindAsync(id);
            _context.Shifts.Remove(shift);
            await _context.SaveChangesAsync();*/
            var shift = await _context.ShiftRepository.GetShiftById((byte)id, false);
            _context.ShiftRepository.Remove(shift);
            await _context.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

        /*private bool ShiftExists(byte id)
        {
            return _context.Shifts.Any(e => e.ShiftId == id);
        }*/
    }
}
