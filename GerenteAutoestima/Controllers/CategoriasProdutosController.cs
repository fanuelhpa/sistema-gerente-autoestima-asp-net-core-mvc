using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenteAutoestima.Models;

namespace GerenteAutoestima.Controllers
{
    public class CategoriasProdutosController : Controller
    {
        private readonly GerenteAutoestimaContext _context;

        public CategoriasProdutosController(GerenteAutoestimaContext context)
        {
            _context = context;
        }

        // GET: CategoriasProdutos
        public async Task<IActionResult> Index()
        {
            return View(await _context.CategoriaProduto.ToListAsync());
        }

        // GET: CategoriasProdutos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaProduto = await _context.CategoriaProduto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriaProduto == null)
            {
                return NotFound();
            }

            return View(categoriaProduto);
        }

        // GET: CategoriasProdutos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoriasProdutos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] CategoriaProduto categoriaProduto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoriaProduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaProduto);
        }

        // GET: CategoriasProdutos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaProduto = await _context.CategoriaProduto.FindAsync(id);
            if (categoriaProduto == null)
            {
                return NotFound();
            }
            return View(categoriaProduto);
        }

        // POST: CategoriasProdutos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] CategoriaProduto categoriaProduto)
        {
            if (id != categoriaProduto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoriaProduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaProdutoExists(categoriaProduto.Id))
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
            return View(categoriaProduto);
        }

        // GET: CategoriasProdutos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaProduto = await _context.CategoriaProduto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriaProduto == null)
            {
                return NotFound();
            }

            return View(categoriaProduto);
        }

        // POST: CategoriasProdutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoriaProduto = await _context.CategoriaProduto.FindAsync(id);
            _context.CategoriaProduto.Remove(categoriaProduto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaProdutoExists(int id)
        {
            return _context.CategoriaProduto.Any(e => e.Id == id);
        }
    }
}
