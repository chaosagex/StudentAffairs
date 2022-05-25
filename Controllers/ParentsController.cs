using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentAffairs.Data;
using StudentAffairs.Models;

namespace StudentAffairs.Controllers
{
    public class ParentsController : Controller
    {
        private readonly StudentAffairsContext _context;

        public ParentsController(StudentAffairsContext context)
        {
            _context = context;
        }

        // GET: Parents
        public async Task<IActionResult> Index()
        {
            var studentAffairsContext = _context.Parents.Include(p => p.ParentLanguageNavigation).Include(p => p.ParentNationalityNavigation);
            return View(await studentAffairsContext.ToListAsync());
        }

        // GET: Parents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Parents == null)
            {
                return NotFound();
            }

            var parent = await _context.Parents
                .Include(p => p.ParentLanguageNavigation)
                .Include(p => p.ParentNationalityNavigation)
                .FirstOrDefaultAsync(m => m.ParentId == id);
            if (parent == null)
            {
                return NotFound();
            }

            return View(parent);
        }

        // GET: Parents/Create
        public IActionResult Create()
        {
            ViewData["ParentLanguage"] = new SelectList(_context.Languages, "LanguageId", "LanguageName");
            ViewData["ParentNationality"] = new SelectList(_context.Nationalities, "NatId", "NatName");
            return View();
        }

        // POST: Parents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParentId,ParentType,ParentEnglishName,ParentArabicName,ParentNid,ParentMobilephone,ParentEmail,ParentJob,ParentQualification,ParentLanguage,ParentNationality")] Parent parent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ParentLanguage"] = new SelectList(_context.Languages, "LanguageId", "LanguageName", parent.ParentLanguage);
            ViewData["ParentNationality"] = new SelectList(_context.Nationalities, "NatId", "NatName", parent.ParentNationality);
            return View(parent);
        }

        // GET: Parents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Parents == null)
            {
                return NotFound();
            }

            var parent = await _context.Parents.FindAsync(id);
            if (parent == null)
            {
                return NotFound();
            }
            ViewData["ParentLanguage"] = new SelectList(_context.Languages, "LanguageId", "LanguageName", parent.ParentLanguage);
            ViewData["ParentNationality"] = new SelectList(_context.Nationalities, "NatId", "NatName", parent.ParentNationality);
            return View(parent);
        }

        // POST: Parents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ParentId,ParentType,ParentEnglishName,ParentArabicName,ParentNid,ParentMobilephone,ParentEmail,ParentJob,ParentQualification,ParentLanguage,ParentNationality")] Parent parent)
        {
            if (id != parent.ParentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParentExists(parent.ParentId))
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
            ViewData["ParentLanguage"] = new SelectList(_context.Languages, "LanguageId", "LanguageId", parent.ParentLanguage);
            ViewData["ParentNationality"] = new SelectList(_context.Nationalities, "NatId", "NatId", parent.ParentNationality);
            return View(parent);
        }

        // GET: Parents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Parents == null)
            {
                return NotFound();
            }

            var parent = await _context.Parents
                .Include(p => p.ParentLanguageNavigation)
                .Include(p => p.ParentNationalityNavigation)
                .FirstOrDefaultAsync(m => m.ParentId == id);
            if (parent == null)
            {
                return NotFound();
            }

            return View(parent);
        }

        // POST: Parents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Parents == null)
            {
                return Problem("Entity set 'StudentAffairsContext.Parents'  is null.");
            }
            var parent = await _context.Parents.FindAsync(id);
            if (parent != null)
            {
                _context.Parents.Remove(parent);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParentExists(int id)
        {
            return (_context.Parents?.Any(e => e.ParentId == id)).GetValueOrDefault();
        }
    }
}
