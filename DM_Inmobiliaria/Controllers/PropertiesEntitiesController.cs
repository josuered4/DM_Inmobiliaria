using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DM_Inmobiliaria;
using DM_Inmobiliaria.Entities;

namespace DM_Inmobiliaria.Controllers
{
    public class PropertiesEntitiesController : Controller
    {
        private readonly ApplicationDBContext _context;

        public PropertiesEntitiesController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: PropertiesEntities
        public async Task<IActionResult> Index()
        {
              return _context.Properties != null ? 
                          View(await _context.Properties.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.Properties'  is null.");
        }

        // GET: PropertiesEntities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Properties == null)
            {
                return NotFound();
            }

            var propertiesEntity = await _context.Properties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (propertiesEntity == null)
            {
                return NotFound();
            }

            return View(propertiesEntity);
        }

        // GET: PropertiesEntities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PropertiesEntities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion,Amedidas,Ubicacion,Precio")] PropertiesEntity propertiesEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(propertiesEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(propertiesEntity);
        }

        // GET: PropertiesEntities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Properties == null)
            {
                return NotFound();
            }

            var propertiesEntity = await _context.Properties.FindAsync(id);
            if (propertiesEntity == null)
            {
                return NotFound();
            }
            return View(propertiesEntity);
        }

        // POST: PropertiesEntities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion,Amedidas,Ubicacion,Precio")] PropertiesEntity propertiesEntity)
        {
            if (id != propertiesEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(propertiesEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertiesEntityExists(propertiesEntity.Id))
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
            return View(propertiesEntity);
        }

        // GET: PropertiesEntities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Properties == null)
            {
                return NotFound();
            }

            var propertiesEntity = await _context.Properties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (propertiesEntity == null)
            {
                return NotFound();
            }

            return View(propertiesEntity);
        }

        // POST: PropertiesEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Properties == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Properties'  is null.");
            }
            var propertiesEntity = await _context.Properties.FindAsync(id);
            if (propertiesEntity != null)
            {
                _context.Properties.Remove(propertiesEntity);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropertiesEntityExists(int id)
        {
          return (_context.Properties?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
