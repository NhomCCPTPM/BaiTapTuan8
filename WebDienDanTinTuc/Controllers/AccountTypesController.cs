using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebDienDanTinTuc.Data;
using WebDienDanTinTuc.Models;

namespace WebDienDanTinTuc.Controllers
{
    public class AccountTypesController : Controller
    {
        private readonly WebDienDanTinTucContext _context;

        public AccountTypesController(WebDienDanTinTucContext context)
        {
            _context = context;
        }

        // GET: AccountTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.AccountTypes.ToListAsync());
        }

        // GET: AccountTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountType = await _context.AccountTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accountType == null)
            {
                return NotFound();
            }

            return View(accountType);
        }

        // GET: AccountTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccountTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccountTypeName,Status")] AccountType accountType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accountType);
        }

        // GET: AccountTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountType = await _context.AccountTypes.FindAsync(id);
            if (accountType == null)
            {
                return NotFound();
            }
            return View(accountType);
        }

        // POST: AccountTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AccountTypeName,Status")] AccountType accountType)
        {
            if (id != accountType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountTypeExists(accountType.Id))
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
            return View(accountType);
        }

        // GET: AccountTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountType = await _context.AccountTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accountType == null)
            {
                return NotFound();
            }

            return View(accountType);
        }

        // POST: AccountTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountType = await _context.AccountTypes.FindAsync(id);
            _context.AccountTypes.Remove(accountType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountTypeExists(int id)
        {
            return _context.AccountTypes.Any(e => e.Id == id);
        }
    }
}
