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
    public class UIRoleMapsController : Controller
    {
        private readonly ApplicationContext _context;

        public UIRoleMapsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: UIRoleMaps
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.UIRoleMap.Include(u => u.Role).Include(u => u.Ui);
            return View(await applicationContext.ToListAsync());
        }

        // GET: UIRoleMaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uIRoleMap = await _context.UIRoleMap
                .Include(u => u.Role)
                .Include(u => u.Ui)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uIRoleMap == null)
            {
                return NotFound();
            }

            return View(uIRoleMap);
        }

        // GET: UIRoleMaps/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.RoleMaster, "Id", "Code");
            ViewData["Uiid"] = new SelectList(_context.UIMaster, "Id", "Name");
            return View();
        }

        // POST: UIRoleMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Uiid,RoleId")] UIRoleMap uIRoleMap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uIRoleMap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.RoleMaster, "Id", "Code", uIRoleMap.RoleId);
            ViewData["Uiid"] = new SelectList(_context.UIMaster, "Id", "Name", uIRoleMap.Uiid);
            return View(uIRoleMap);
        }

        // GET: UIRoleMaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uIRoleMap = await _context.UIRoleMap.FindAsync(id);
            if (uIRoleMap == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.RoleMaster, "Id", "Code", uIRoleMap.RoleId);
            ViewData["Uiid"] = new SelectList(_context.UIMaster, "Id", "Name", uIRoleMap.Uiid);
            return View(uIRoleMap);
        }

        // POST: UIRoleMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Uiid,RoleId")] UIRoleMap uIRoleMap)
        {
            if (id != uIRoleMap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uIRoleMap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UIRoleMapExists(uIRoleMap.Id))
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
            ViewData["RoleId"] = new SelectList(_context.RoleMaster, "Id", "Code", uIRoleMap.RoleId);
            ViewData["Uiid"] = new SelectList(_context.UIMaster, "Id", "Name", uIRoleMap.Uiid);
            return View(uIRoleMap);
        }

        // GET: UIRoleMaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uIRoleMap = await _context.UIRoleMap
                .Include(u => u.Role)
                .Include(u => u.Ui)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uIRoleMap == null)
            {
                return NotFound();
            }

            return View(uIRoleMap);
        }

        // POST: UIRoleMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uIRoleMap = await _context.UIRoleMap.FindAsync(id);
            _context.UIRoleMap.Remove(uIRoleMap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UIRoleMapExists(int id)
        {
            return _context.UIRoleMap.Any(e => e.Id == id);
        }
    }
}
