﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenteAutoestima.Models;

namespace GerenteAutoestima.Controllers
{
    public class CategoriasServicosController : Controller
    {
        private readonly GerenteAutoestimaContext _context;

        public CategoriasServicosController(GerenteAutoestimaContext context)
        {
            _context = context;
        }

        // GET: CategoriasServicos
        public async Task<IActionResult> Index()
        {
            return View(await _context.CategoriaServico.ToListAsync());
        }

        // GET: CategoriasServicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaServico = await _context.CategoriaServico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriaServico == null)
            {
                return NotFound();
            }

            return View(categoriaServico);
        }

        // GET: CategoriasServicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoriasServicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] CategoriaServico categoriaServico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoriaServico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaServico);
        }

        // GET: CategoriasServicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaServico = await _context.CategoriaServico.FindAsync(id);
            if (categoriaServico == null)
            {
                return NotFound();
            }
            return View(categoriaServico);
        }

        // POST: CategoriasServicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] CategoriaServico categoriaServico)
        {
            if (id != categoriaServico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoriaServico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaServicoExists(categoriaServico.Id))
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
            return View(categoriaServico);
        }

        // GET: CategoriasServicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaServico = await _context.CategoriaServico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriaServico == null)
            {
                return NotFound();
            }

            return View(categoriaServico);
        }

        // POST: CategoriasServicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoriaServico = await _context.CategoriaServico.FindAsync(id);
            _context.CategoriaServico.Remove(categoriaServico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaServicoExists(int id)
        {
            return _context.CategoriaServico.Any(e => e.Id == id);
        }
    }
}
