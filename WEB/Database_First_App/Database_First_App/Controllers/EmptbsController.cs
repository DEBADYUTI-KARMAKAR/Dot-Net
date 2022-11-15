using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Database_First_App.Models;

namespace Database_First_App.Controllers
{
    public class EmptbsController : Controller
    {
        private readonly EmployeeContext _context;

        public EmptbsController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: Emptbs
        public async Task<IActionResult> Index()
        {
              return View(await _context.Emptbs.ToListAsync());
        }

        // GET: Emptbs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Emptbs == null)
            {
                return NotFound();
            }

            var emptb = await _context.Emptbs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emptb == null)
            {
                return NotFound();
            }

            return View(emptb);
        }

        // GET: Emptbs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Emptbs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Salary")] Emptb emptb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emptb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emptb);
        }

        // GET: Emptbs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Emptbs == null)
            {
                return NotFound();
            }

            var emptb = await _context.Emptbs.FindAsync(id);
            if (emptb == null)
            {
                return NotFound();
            }
            return View(emptb);
        }

        // POST: Emptbs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Salary")] Emptb emptb)
        {
            if (id != emptb.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emptb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmptbExists(emptb.Id))
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
            return View(emptb);
        }

        // GET: Emptbs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Emptbs == null)
            {
                return NotFound();
            }

            var emptb = await _context.Emptbs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emptb == null)
            {
                return NotFound();
            }

            return View(emptb);
        }

        // POST: Emptbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Emptbs == null)
            {
                return Problem("Entity set 'EmployeeContext.Emptbs'  is null.");
            }
            var emptb = await _context.Emptbs.FindAsync(id);
            if (emptb != null)
            {
                _context.Emptbs.Remove(emptb);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmptbExists(string id)
        {
          return _context.Emptbs.Any(e => e.Id == id);
        }
    }
}
