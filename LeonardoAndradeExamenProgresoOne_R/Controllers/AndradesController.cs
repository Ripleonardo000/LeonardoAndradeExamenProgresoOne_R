using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeonardoAndradeExamenProgresoOne_R.Data;
using LeonardoAndradeExamenProgresoOne_R.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;



namespace LeonardoAndradeExamenProgresoOne_R.Controllers
{
    public class AndradesController : Controller
    {
        private readonly LeonardoAndradeExamenProgresoOne_RContext _context;
        

        public AndradesController(LeonardoAndradeExamenProgresoOne_RContext context)
        {
            _context = context;
        }

        // GET: Andrades
        public async Task<IActionResult> Index(string searchString)
        {
            var andrades = _context.Andrade.Include(a => a.Celular).AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                andrades = andrades.Where(a => a.Celular.Modelo.Contains(searchString));
            }
            return View(await andrades.ToListAsync());
        }

        // GET: Andrades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var andrade = await _context.Andrade
                .Include(a => a.Celular)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (andrade == null)
            {
                return NotFound();
            }

            return View(andrade);
        }

        // GET: Andrades/Create
        public IActionResult Create()
        {
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "Id", "Modelo");
            return View();
        }

        // POST: Andrades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,sueldo,empleo,Cumple,IdCelular")] Andrade andrade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(andrade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "Id", "Id", andrade.IdCelular);
            return View(andrade);
        }


        
        // GET: Andrades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var andrade = await _context.Andrade.FindAsync(id);
            if (andrade == null)
            {
                return NotFound();
            }
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "Id", "Id", andrade.IdCelular);
            return View(andrade);
        }





        
        // POST: Andrades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,name,sueldo,empleo,Cumple,IdCelular")] Andrade andrade)
        {
            if (id != andrade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(andrade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AndradeExists(andrade.Id))
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
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "Id", "Id", andrade.IdCelular);
            return View(andrade);
        }

        
        // GET: Andrades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var andrade = await _context.Andrade
                .Include(a => a.Celular)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (andrade == null)
            {
                return NotFound();
            }

            return View(andrade);
        }

        // POST: Andrades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var andrade = await _context.Andrade.FindAsync(id);
            if (andrade != null)
            {
                _context.Andrade.Remove(andrade);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AndradeExists(int id)
        {
            return _context.Andrade.Any(e => e.Id == id);
        }
    }
}
