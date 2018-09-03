﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VFS.Common.Models.Masters;
using VFS.Data.EFCore.Common;

namespace VFS.UI.MasterDM.Controllers
{
    public class CountriesController : Controller
    {
        private readonly ApplicationContext _context;       

        public CountriesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Countries
        public async Task<IActionResult> Index(int? id,string Search)
        {
            if (Search == null) Search = string.Empty;
            //var _DBMISSIONContext = _context.Country.Where(a => a.Name == Search).Include(c => c.CreatedByNavigation);
            if(id != null)
            {
                if (id != 3)
                {
                    HttpContext.Session.SetInt32("IsEditable", 1);
                }
                else
                {
                    HttpContext.Session.SetInt32("IsEditable", 0);
                }
                ViewData["IsEditable"] = HttpContext.Session.GetInt32("IsEditable");
                HttpContext.Session.SetInt32("UserId", Convert.ToInt32(id));
            }
            if(Search != string.Empty)
            {
                return View(await _context.Country.Where(a => a.Name.Contains(Search) || a.Isocode2.Contains(Search) || a.Isocode3.Contains(Search) || a.Nationality.Contains(Search)).Include(c => c.CreatedByNavigation).ToListAsync());
            }
            else
            {
                return View(await _context.Country.Include(c => c.CreatedByNavigation).ToListAsync());
            }           

        }

        // GET: Countries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Country
                .FirstOrDefaultAsync(m => m.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        // GET: Countries/Create
        public IActionResult Create()
        {
            ViewData["CreatedBy"] = new SelectList(_context.UserMaster, "Id", "FirstName");
            return View();
        }

        // POST: Countries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Code,Isocode2,Isocode3,DialCode,Nationality,CreatedBy]")] Country country)
        {
            if (ModelState.IsValid)
            {
                country.CreatedBy = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));

                _context.Add(country);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }

        // GET: Countries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if ((id == null) || (id == 0) )
            {
                return NotFound();
            }

            var country = await _context.Country.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }
            ViewData["CreatedBy"] = new SelectList(_context.UserMaster, "Id", "FirstName");
            ViewData["IsEditable"] = HttpContext.Session.GetInt32("IsEditable");
            return View(country);
        }

        // POST: Countries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Code,Isocode2,Isocode3,DialCode,Nationality,CreatedBy")] Country country)
        {
            if (id != country.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    country.CreatedBy = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));
                    _context.Update(country);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CountryExists(country.Id))
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
            return View(country);
        }

        // GET: Countries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Country
                .FirstOrDefaultAsync(m => m.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        // POST: Countries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var country = await _context.Country.FindAsync(id);
            _context.Country.Remove(country);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CountryExists(int id)
        {
            return _context.Country.Any(e => e.Id == id);
        }
    }
}
