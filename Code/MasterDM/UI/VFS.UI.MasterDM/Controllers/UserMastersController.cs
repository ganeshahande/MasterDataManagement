﻿using System;
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
    public class UserMastersController : Controller
    {
        private readonly ApplicationContext _context;

        public UserMastersController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: UserMasters
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserMaster.ToListAsync());
        }

        // GET: UserMasters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMaster = await _context.UserMaster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userMaster == null)
            {
                return NotFound();
            }

            return View(userMaster);
        }

        // GET: UserMasters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserMasters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LoginId,FirstName,LastName")] UserMaster userMaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userMaster);
        }

        // GET: UserMasters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMaster = await _context.UserMaster.FindAsync(id);
            if (userMaster == null)
            {
                return NotFound();
            }
            return View(userMaster);
        }

        // POST: UserMasters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LoginId,FirstName,LastName")] UserMaster userMaster)
        {
            if (id != userMaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserMasterExists(userMaster.Id))
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
            return View(userMaster);
        }

        // GET: UserMasters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMaster = await _context.UserMaster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userMaster == null)
            {
                return NotFound();
            }

            return View(userMaster);
        }

        // POST: UserMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userMaster = await _context.UserMaster.FindAsync(id);
            _context.UserMaster.Remove(userMaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserMasterExists(int id)
        {
            return _context.UserMaster.Any(e => e.Id == id);
        }
    }
}
