using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Carros.Data;
using Carros.Models;
using System.Composition;

namespace Carros.Controllers
{
    public class ConsumoCombustivelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConsumoCombustivelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ConsumoCombustivels
        public async Task<IActionResult> Index()
        {
            try
            {
                return _context.ConsumoCombustivel.First() != null ?
                      View(await _context.ConsumoCombustivel.ToListAsync()) :
                      Problem($"Entity set 'ApplicationDbContext.ConsumoCombustivel'  is null.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("Create", "Principal");
            }
        }

        // GET: ConsumoCombustivels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ConsumoCombustivel == null)
            {
                return NotFound();
            }

            var consumoCombustivel = await _context.ConsumoCombustivel
                .FirstOrDefaultAsync(m => m.NumeroDeSerie == id);
            if (consumoCombustivel == null)
            {
                return NotFound();
            }

            return View(consumoCombustivel);
        }

        // GET: ConsumoCombustivels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ConsumoCombustivels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NumeroDeSerie,Capacidade,Portador,CombustivelAtual")] ConsumoCombustivel consumoCombustivel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consumoCombustivel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consumoCombustivel);
        }

        // GET: ConsumoCombustivels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ConsumoCombustivel == null)
            {
                return NotFound();
            }

            var consumoCombustivel = await _context.ConsumoCombustivel.FindAsync(id);
            if (consumoCombustivel == null)
            {
                return NotFound();
            }
            return View(consumoCombustivel);
        }

        // POST: ConsumoCombustivels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NumeroDeSerie,Capacidade,Portador,CombustivelAtual")] ConsumoCombustivel consumoCombustivel)
        {
            if (id != consumoCombustivel.NumeroDeSerie)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consumoCombustivel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsumoCombustivelExists(consumoCombustivel.NumeroDeSerie))
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
            return View(consumoCombustivel);
        }

        // GET: ConsumoCombustivels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ConsumoCombustivel == null)
            {
                return NotFound();
            }

            var consumoCombustivel = await _context.ConsumoCombustivel
                .FirstOrDefaultAsync(m => m.NumeroDeSerie == id);
            if (consumoCombustivel == null)
            {
                return NotFound();
            }

            return View(consumoCombustivel);
        }

        // POST: ConsumoCombustivels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ConsumoCombustivel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ConsumoCombustivel'  is null.");
            }
            var consumoCombustivel = await _context.ConsumoCombustivel.FindAsync(id);
            if (consumoCombustivel != null)
            {
                _context.ConsumoCombustivel.Remove(consumoCombustivel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsumoCombustivelExists(int id)
        {
          return (_context.ConsumoCombustivel?.Any(e => e.NumeroDeSerie == id)).GetValueOrDefault();
        }
    }
}
