using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VFS.Common.Models.AdminMasters;
using VFS.Data.EFCore.Common;

namespace VFS.UI.MasterDM.Controllers
{
    public class UIMastersController : Controller
    {
        private readonly ApplicationContext _context;

        public UIMastersController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: UIMasters
        public async Task<IActionResult> Index()
        {
            return View(await _context.UIMaster.ToListAsync());
        }

        // GET: UIMasters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uIMaster = await _context.UIMaster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uIMaster == null)
            {
                return NotFound();
            }

            return View(uIMaster);
        }

        // GET: UIMasters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UIMasters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PageName")] UIMaster uIMaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uIMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uIMaster);
        }

        // GET: UIMasters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uIMaster = await _context.UIMaster.FindAsync(id);
            if (uIMaster == null)
            {
                return NotFound();
            }
            return View(uIMaster);
        }

        // POST: UIMasters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PageName")] UIMaster uIMaster)
        {
            if (id != uIMaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uIMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UIMasterExists(uIMaster.Id))
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
            return View(uIMaster);
        }

        // GET: UIMasters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uIMaster = await _context.UIMaster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uIMaster == null)
            {
                return NotFound();
            }

            return View(uIMaster);
        }

        // POST: UIMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uIMaster = await _context.UIMaster.FindAsync(id);
            _context.UIMaster.Remove(uIMaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UIMasterExists(int id)
        {
            return _context.UIMaster.Any(e => e.Id == id);
        }
    }
}
