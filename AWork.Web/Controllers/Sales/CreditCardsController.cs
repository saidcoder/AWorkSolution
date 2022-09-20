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

namespace AWork.Web.Controllers.Sales
{
    public class CreditCardsController : Controller
    {
/*        private readonly AdventureWorks2019Context _context;
*/        private readonly IRepositoryManager _context;

        public CreditCardsController(IRepositoryManager context)
        {
            _context = context;
        }

        // GET: CreditCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.CreditCardRepository.GetAllCreditCard(false));
        }

        // GET: CreditCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

        /*    var creditCard = await _context.CreditCards
                .FirstOrDefaultAsync(m => m.CreditCardId == id);*/
            var creditCard = await _context.CreditCardRepository.GetCreditCardById((int)id,false);
            if (creditCard == null)
            {
                return NotFound();
            }

            return View(creditCard);
        }

        // GET: CreditCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CreditCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CreditCardId,CardType,CardNumber,ExpMonth,ExpYear,ModifiedDate")] CreditCard creditCard)
        {
            if (ModelState.IsValid)
            {
                /*      _context.Add(creditCard);
                      await _context.SaveChangesAsync();*/
                _context.CreditCardRepository.Insert(creditCard);
                await _context.SaveAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(creditCard);
        }

        // GET: CreditCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

/*            var creditCard = await _context.CreditCardRepository.FindAsync(id);
*/            var creditCard = await _context.CreditCardRepository.GetAllCreditCard(false);
            if (creditCard == null)
            {
                return NotFound();
            }
            return View(creditCard);
        }

        // POST: CreditCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CreditCardId,CardType,CardNumber,ExpMonth,ExpYear,ModifiedDate")] CreditCard creditCard)
        {
            if (id != creditCard.CreditCardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    /*       _context.Update(creditCard);
                           await _context.SaveChangesAsync();*/
                    _context.CreditCardRepository.Remove(creditCard);
                    await _context.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    /* if (!CreditCardExists(creditCard.CreditCardId))
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
            return View(creditCard);
        }

        // GET: CreditCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

    /*        var creditCard = await _context.CreditCards
                .FirstOrDefaultAsync(m => m.CreditCardId == id);*/

            var creditCard = await _context.CreditCardRepository.GetCreditCardById((int)id, false);
            if (creditCard == null)
            {
                return NotFound();
            }

            return View(creditCard);
        }

        // POST: CreditCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
         /*   var creditCard = await _context.CreditCards.FindAsync(id);
            _context.CreditCards.Remove(creditCard);
            await _context.SaveChangesAsync();*/
            var creditCard = await _context.CreditCardRepository.GetCreditCardById((int)id,false);
            _context.CreditCardRepository.Remove(creditCard);
            return RedirectToAction(nameof(Index));
        }

       /* private bool CreditCardExists(int id)
        {
            return _context.CreditCards.Any(e => e.CreditCardId == id);
        }*/
    }
}
