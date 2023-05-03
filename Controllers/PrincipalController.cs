using Carros.Data;
using Carros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Carros.Controllers
{
    public class PrincipalController : Controller
    {

        private readonly ApplicationDbContext _context;

        public PrincipalController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Principal/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Principal/Create
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
                return RedirectToAction("Index", "ConsumoCombustivels");
            }
            return View(consumoCombustivel);
        }

    }
}
