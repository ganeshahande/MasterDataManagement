using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VFS.Common.Models.Masters;
using VFS.Data.EFCore.Common;

namespace VFS.UI.MasterDM.Controllers
{
    public class NationalityMapsController : Controller
    {
        private readonly ApplicationContext _context;

        public NationalityMapsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: NationalityMaps
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.NationalityMap.Include(n => n.CountryOps).Include(n => n.Mission).Include(n => n.Nationality).Include(n => n.UnitOps);
            return View(await applicationContext.ToListAsync());
        }

        // GET: NationalityMaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nationalityMap = await _context.NationalityMap
                .Include(n => n.CountryOps)
                .Include(n => n.Mission)
                .Include(n => n.Nationality)
                .Include(n => n.UnitOps)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nationalityMap == null)
            {
                return NotFound();
            }

            return View(nationalityMap);
        }

        // GET: NationalityMaps/Create
        public IActionResult Create()
        {
            ViewData["CountryOpsId"] = new SelectList(_context.CountryOfOperation, "Id", "Name");
            ViewData["MissionId"] = new SelectList(_context.Mission, "Id", "Name");
            ViewData["NationalityId"] = new SelectList(_context.Country, "Id", "Nationality");
            ViewData["UnitOpsId"] = new SelectList(_context.UnitOps, "Id", "Name");
            return View();
        }

        // POST: NationalityMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NationalityId,MissionId,CountryOpsId,UnitOpsId")] NationalityMap nationalityMap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nationalityMap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryOpsId"] = new SelectList(_context.CountryOfOperation, "Id", "Name", nationalityMap.CountryOpsId);
            ViewData["MissionId"] = new SelectList(_context.Mission, "Id", "Name", nationalityMap.MissionId);
            ViewData["NationalityId"] = new SelectList(_context.Country, "Id", "Nationality", nationalityMap.NationalityId);
            ViewData["UnitOpsId"] = new SelectList(_context.UnitOps, "Id", "Name", nationalityMap.UnitOpsId);
            return View(nationalityMap);
        }

        // GET: NationalityMaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nationalityMap = await _context.NationalityMap.FindAsync(id);
            if (nationalityMap == null)
            {
                return NotFound();
            }
            ViewData["CountryOpsId"] = new SelectList(_context.CountryOfOperation, "Id", "Name", nationalityMap.CountryOpsId);
            ViewData["MissionId"] = new SelectList(_context.Mission, "Id", "Name", nationalityMap.MissionId);
            ViewData["NationalityId"] = new SelectList(_context.Country, "Id", "Nationality", nationalityMap.NationalityId);
            ViewData["UnitOpsId"] = new SelectList(_context.UnitOps, "Id", "Name", nationalityMap.UnitOpsId);
            return View(nationalityMap);
        }

        // POST: NationalityMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NationalityId,MissionId,CountryOpsId,UnitOpsId")] NationalityMap nationalityMap)
        {
            if (id != nationalityMap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nationalityMap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NationalityMapExists(nationalityMap.Id))
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
            ViewData["CountryOpsId"] = new SelectList(_context.CountryOfOperation, "Id", "Name", nationalityMap.CountryOpsId);
            ViewData["MissionId"] = new SelectList(_context.Mission, "Id", "Name", nationalityMap.MissionId);
            ViewData["NationalityId"] = new SelectList(_context.Country, "Id", "Nationality", nationalityMap.NationalityId);
            ViewData["UnitOpsId"] = new SelectList(_context.UnitOps, "Id", "Name", nationalityMap.UnitOpsId);
            return View(nationalityMap);
        }

        // GET: NationalityMaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nationalityMap = await _context.NationalityMap
                .Include(n => n.CountryOps)
                .Include(n => n.Mission)
                .Include(n => n.Nationality)
                .Include(n => n.UnitOps)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nationalityMap == null)
            {
                return NotFound();
            }

            return View(nationalityMap);
        }

        // POST: NationalityMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nationalityMap = await _context.NationalityMap.FindAsync(id);
            _context.NationalityMap.Remove(nationalityMap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NationalityMapExists(int id)
        {
            return _context.NationalityMap.Any(e => e.Id == id);
        }
    }
}
