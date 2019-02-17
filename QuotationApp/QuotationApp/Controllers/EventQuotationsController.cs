using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuotationApp.Models;

namespace QuotationApp.Controllers
{
    public class EventQuotationsController : Controller
    {
        private readonly QuotationAppContext _context;

        public EventQuotationsController(QuotationAppContext context)
        {
            _context = context;
        }

        // GET: EventQuotations
        public async Task<IActionResult> Index()
        {
            return View(await _context.EventQuotation.ToListAsync());
        }

        // GET: EventQuotations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventQuotation = await _context.EventQuotation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventQuotation == null)
            {
                return NotFound();
            }

            return View(eventQuotation);
        }

        // GET: EventQuotations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EventQuotations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Tematic,NumberOfPeople,Date,hour,Colors,FullPackage,Details")] EventQuotation eventQuotation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventQuotation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eventQuotation);
        }

        // GET: EventQuotations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventQuotation = await _context.EventQuotation.FindAsync(id);
            if (eventQuotation == null)
            {
                return NotFound();
            }
            return View(eventQuotation);
        }

        // POST: EventQuotations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Tematic,NumberOfPeople,Date,hour,Colors,FullPackage,Details")] EventQuotation eventQuotation)
        {
            if (id != eventQuotation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventQuotation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventQuotationExists(eventQuotation.Id))
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
            return View(eventQuotation);
        }

        // GET: EventQuotations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventQuotation = await _context.EventQuotation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventQuotation == null)
            {
                return NotFound();
            }

            return View(eventQuotation);
        }

        // POST: EventQuotations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventQuotation = await _context.EventQuotation.FindAsync(id);
            _context.EventQuotation.Remove(eventQuotation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventQuotationExists(int id)
        {
            return _context.EventQuotation.Any(e => e.Id == id);
        }
    }
}
