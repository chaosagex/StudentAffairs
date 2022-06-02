using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentAffairs.Data;
using StudentAffairs.Models;

namespace StudentAffairs.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentAffairsContext _context;

        public StudentsController(StudentAffairsContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var studentAffairsContext = _context.Students.Include(s => s.ApplyingForGradeNavigation).Include(s => s.CityNavigation).Include(s => s.GuardianNavigation).Include(s => s.JoinYearNavigation).Include(s => s.ReligonNavigation).Include(s => s.StudentBranchNavigation).Include(s => s.StudentClassNavigation).Include(s => s.StudentFatherNavigation).Include(s => s.StudentGovNavigation).Include(s => s.StudentGradeNavigation).Include(s => s.StudentMotherNavigation).Include(s => s.StudentNatNavigation).Include(s => s.StudentStatusNavigation);
            return View(await studentAffairsContext.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.ApplyingForGradeNavigation)
                .Include(s => s.CityNavigation)
                .Include(s => s.GuardianNavigation)
                .Include(s => s.JoinYearNavigation)
                .Include(s => s.ReligonNavigation)
                .Include(s => s.StudentBranchNavigation)
                .Include(s => s.StudentClassNavigation)
                .Include(s => s.StudentFatherNavigation)
                .Include(s => s.StudentGovNavigation)
                .Include(s => s.StudentGradeNavigation)
                .Include(s => s.StudentMotherNavigation)
                .Include(s => s.StudentNatNavigation)
                .Include(s => s.StudentStatusNavigation)
                .Include(s => s.StudentFatherNavigation.ParentLanguageNavigation)
                .Include(s => s.StudentFatherNavigation.ParentQualificationNavigation)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            ViewData["ApplyingForGrade"] = new SelectList(_context.Grades, "GradeId", "GradeName");
            ViewData["City"] = new SelectList(_context.Cities, "CityId", "CityName");
            ViewData["Guardian"] = new SelectList(_context.Guardians, "GuardianId", "GuardianName");
            List<SelectListItem> years = new List<SelectListItem>
        {
            new SelectListItem { Value = _context.JoinYears.OrderByDescending(p => p.Id).FirstOrDefault().Id.ToString(), Text = _context.JoinYears.OrderByDescending(p => p.Id).FirstOrDefault().Name },
        };
            ViewData["JoinYear"] = years;
            ViewData["Religon"] = new SelectList(_context.Religions, "ReligionId", "ReligionName");
            ViewData["StudentBranch"] = new SelectList(_context.Branches, "BranchId", "BranchName");
            ViewData["StudentGov"] = new SelectList(_context.Govenantes, "GovId", "GovName");
            ViewData["StudentGrade"] = new SelectList(_context.Grades, "GradeId", "GradeName");
            ViewData["StudentNat"] = new SelectList(_context.Nationalities, "NatId", "NatName");
            ViewData["ParentNationality"] = new SelectList(_context.Nationalities, "NatId", "NatName");
            ViewData["ParentLanguage"] = new SelectList(_context.Languages, "LanguageId", "LanguageName");
            ViewData["ParentQualification"] = new SelectList(_context.Qualifications, "Id", "Name");
            
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentView sv)
        {
            sv.student.StudentFatherNavigation = sv.father;
            sv.student.StudentMotherNavigation = sv.mother;
            var student = sv.student;
            student.StudentStatus = 3;
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            ViewData["ApplyingForGrade"] = new SelectList(_context.Grades, "GradeId", "GradeId", student.ApplyingForGrade);
            ViewData["City"] = new SelectList(_context.Cities, "CityId", "CityId", student.City);
            ViewData["Guardian"] = new SelectList(_context.Guardians, "GuardianId", "GuardianId", student.Guardian);
            List<SelectListItem> years = new List<SelectListItem>
        {
            new SelectListItem { Value = _context.JoinYears.OrderByDescending(p => p.Id).FirstOrDefault().Id.ToString(), Text = _context.JoinYears.OrderByDescending(p => p.Id).FirstOrDefault().Name },
        };
            ViewData["JoinYear"] = years;
            ViewData["Religon"] = new SelectList(_context.Religions, "ReligionId", "ReligionName", student.Religon);
            ViewData["StudentBranch"] = new SelectList(_context.Branches, "BranchId", "BranchName", student.StudentBranch);
            ViewData["StudentGov"] = new SelectList(_context.Govenantes, "GovId", "GovId", student.StudentGov);
            ViewData["StudentGrade"] = new SelectList(_context.Grades, "GradeId", "GradeId", student.StudentGrade);
            ViewData["StudentNat"] = new SelectList(_context.Nationalities, "NatId", "NatId", student.StudentNat);
            ViewData["ParentNationality"] = new SelectList(_context.Nationalities, "NatId", "NatName");
            ViewData["ParentLanguage"] = new SelectList(_context.Languages, "LanguageId", "LanguageName");
            ViewData["ParentQualification"] = new SelectList(_context.Qualifications, "Id", "Name");
            return View(sv);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            
            if (student == null)
            {
                return NotFound();
            }
            StudentView sv = new StudentView();
            sv.student = student;
            sv.father = await _context.Parents.FindAsync(student.StudentFather);
            sv.mother = await _context.Parents.FindAsync(student.StudentMother);
            ViewData["ApplyingForGrade"] = new SelectList(_context.Grades, "GradeId", "GradeName", student.ApplyingForGrade);
            ViewData["City"] = new SelectList(_context.Cities, "CityId", "CityId", student.City);
            ViewData["Guardian"] = new SelectList(_context.Guardians, "GuardianId", "GuardianName", student.Guardian);
            List<SelectListItem> years = new List<SelectListItem>
        {
            new SelectListItem { Value = _context.JoinYears.OrderByDescending(p => p.Id).FirstOrDefault().Id.ToString(), Text = _context.JoinYears.OrderByDescending(p => p.Id).FirstOrDefault().Name },
        };
            ViewData["JoinYear"] = years;
            ViewData["Religon"] = new SelectList(_context.Religions, "ReligionId", "ReligionId", student.Religon);
            ViewData["StudentBranch"] = new SelectList(_context.Branches, "BranchId", "BranchId", student.StudentBranch);
            ViewData["StudentGov"] = new SelectList(_context.Govenantes, "GovId", "GovId", student.StudentGov);
            ViewData["StudentGrade"] = new SelectList(_context.Grades, "GradeId", "GradeId", student.StudentGrade);
            ViewData["StudentNat"] = new SelectList(_context.Nationalities, "NatId", "NatId", student.StudentNat);
            ViewData["ParentNationality"] = new SelectList(_context.Nationalities, "NatId", "NatName");
            ViewData["ParentLanguage"] = new SelectList(_context.Languages, "LanguageId", "LanguageName");
            ViewData["ParentQualification"] = new SelectList(_context.Qualifications, "Id", "Name");
            return View(sv);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StudentView sv)
        {
            sv.student.StudentFatherNavigation = sv.father;
            sv.student.StudentMotherNavigation = sv.mother;
            var student = sv.student;
            if (id != sv.student.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sv.father);
                    _context.Update(sv.mother);
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentId))
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
            ViewData["ApplyingForGrade"] = new SelectList(_context.Grades, "GradeId", "GradeId", student.ApplyingForGrade);
            ViewData["City"] = new SelectList(_context.Cities, "CityId", "CityId", student.City);
            ViewData["Guardian"] = new SelectList(_context.Guardians, "GuardianId", "GuardianId", student.Guardian);
            List<SelectListItem> years = new List<SelectListItem>
        {
            new SelectListItem { Value = _context.JoinYears.OrderByDescending(p => p.Id).FirstOrDefault().Id.ToString(), Text = _context.JoinYears.OrderByDescending(p => p.Id).FirstOrDefault().Name },
        };
            ViewData["JoinYear"] = years;
            ViewData["Religon"] = new SelectList(_context.Religions, "ReligionId", "ReligionId", student.Religon);
            ViewData["StudentBranch"] = new SelectList(_context.Branches, "BranchId", "BranchId", student.StudentBranch);
            ViewData["StudentGov"] = new SelectList(_context.Govenantes, "GovId", "GovId", student.StudentGov);
            ViewData["StudentGrade"] = new SelectList(_context.Grades, "GradeId", "GradeId", student.StudentGrade);
            ViewData["StudentNat"] = new SelectList(_context.Nationalities, "NatId", "NatId", student.StudentNat);
            ViewData["ParentNationality"] = new SelectList(_context.Nationalities, "NatId", "NatName");
            ViewData["ParentLanguage"] = new SelectList(_context.Languages, "LanguageId", "LanguageName");
            ViewData["ParentQualification"] = new SelectList(_context.Qualifications, "Id", "Name");
            return View(sv);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.ApplyingForGradeNavigation)
                .Include(s => s.CityNavigation)
                .Include(s => s.GuardianNavigation)
                .Include(s => s.JoinYearNavigation)
                .Include(s => s.ReligonNavigation)
                .Include(s => s.StudentBranchNavigation)
                .Include(s => s.StudentClassNavigation)
                .Include(s => s.StudentFatherNavigation)
                .Include(s => s.StudentGovNavigation)
                .Include(s => s.StudentGradeNavigation)
                .Include(s => s.StudentMotherNavigation)
                .Include(s => s.StudentNatNavigation)
                .Include(s => s.StudentStatusNavigation)
                .Include(s => s.StudentFatherNavigation.ParentLanguageNavigation)
                .Include(s => s.StudentFatherNavigation.ParentQualificationNavigation)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'StudentAffairsContext.Students'  is null.");
            }
            var student = await _context.Students.FindAsync(id);
            var father = await _context.Parents.FindAsync(student.StudentFather);
            var mother = await _context.Parents.FindAsync(student.StudentMother);
            if (student != null)
            {
                _context.Parents.Remove(father);
                _context.Parents.Remove(mother);
                _context.Students.Remove(student);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> Accept(int id)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'StudentAffairsContext.Students'  is null.");
            }
            var student = await _context.Students.FindAsync(id);
            
            if (student != null)
            {
                student.StudentStatus = 4;
                _context.Update(student);
                
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> Reject(int id)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'StudentAffairsContext.Students'  is null.");
            }
            var student = await _context.Students.FindAsync(id);

            if (student != null)
            {
                student.StudentStatus = 5;
                _context.Update(student);

            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool StudentExists(int id)
        {
          return (_context.Students?.Any(e => e.StudentId == id)).GetValueOrDefault();
        }
    }
}
