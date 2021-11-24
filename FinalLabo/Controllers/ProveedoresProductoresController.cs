using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalLabo.Data;
using FinalLabo.Models;

namespace FinalLabo.Controllers
{
    public class ProveedoresProductoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProveedoresProductoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProveedoresProductores
        public async Task<IActionResult> Index()
        {
            return View(await _context.proveedoresProductos.ToListAsync());
        }

        // GET: ProveedoresProductores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proveedorProducto = await _context.proveedoresProductos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proveedorProducto == null)
            {
                return NotFound();
            }

            return View(proveedorProducto);
        }

        // GET: ProveedoresProductores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProveedoresProductores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,productoId,proveedorId")] ProveedorProducto proveedorProducto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proveedorProducto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proveedorProducto);
        }

        // GET: ProveedoresProductores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proveedorProducto = await _context.proveedoresProductos.FindAsync(id);
            if (proveedorProducto == null)
            {
                return NotFound();
            }
            return View(proveedorProducto);
        }

        // POST: ProveedoresProductores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,productoId,proveedorId")] ProveedorProducto proveedorProducto)
        {
            if (id != proveedorProducto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proveedorProducto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProveedorProductoExists(proveedorProducto.Id))
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
            return View(proveedorProducto);
        }

        // GET: ProveedoresProductores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proveedorProducto = await _context.proveedoresProductos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proveedorProducto == null)
            {
                return NotFound();
            }

            return View(proveedorProducto);
        }

        // POST: ProveedoresProductores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proveedorProducto = await _context.proveedoresProductos.FindAsync(id);
            _context.proveedoresProductos.Remove(proveedorProducto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProveedorProductoExists(int id)
        {
            return _context.proveedoresProductos.Any(e => e.Id == id);
        }
    }
}
