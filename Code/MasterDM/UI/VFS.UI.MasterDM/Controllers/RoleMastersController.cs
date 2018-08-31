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
    public class RoleMastersController : Controller
    {
        private readonly ApplicationContext _context;

        public RoleMastersController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: RoleMasters
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoleMaster.ToListAsync());
        }

        // GET: RoleMasters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleMaster = await _context.RoleMaster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roleMaster == null)
            {
                return NotFound();
            }

            return View(roleMaster);
        }

        // GET: RoleMasters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoleMasters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Code")] RoleMaster roleMaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roleMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roleMaster);
        }

        // GET: RoleMasters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleMaster = await _context.RoleMaster.FindAsync(id);
            if (roleMaster == null)
            {
                return NotFound();
            }
            return View(roleMaster);
        }

        // POST: RoleMasters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Code")] RoleMaster roleMaster)
        {
            if (id != roleMaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roleMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoleMasterExists(roleMaster.Id))
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
            return View(roleMaster);
        }

        // GET: RoleMasters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleMaster = await _context.RoleMaster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roleMaster == null)
            {
                return NotFound();
            }

            return View(roleMaster);
        }

        // POST: RoleMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roleMaster = await _context.RoleMaster.FindAsync(id);
            _context.RoleMaster.Remove(roleMaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoleMasterExists(int id)
        {
            return _context.RoleMaster.Any(e => e.Id == id);
        }
    }
}
