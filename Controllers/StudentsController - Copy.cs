//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using StudentAffairs.Data;
//using StudentAffairs.Models;

//namespace StudentAffairs.Controllers
//{
//    public class StudentsController : Controller
//    {




//        private readonly StudentAffairsContext _context;

//        public StudentsController(StudentAffairsContext context)
//        {
//            _context = context;
//        }

//        // GET: Students
//        public async Task<IActionResult> Index()
//        {


//            var studentAffairsContext = _context.Students.Include(s => s.CityNavigation).Include(s => s.GuardianNavigation).Include(s => s.ReligonNavigation).Include(s => s.StudentBranchNavigation).Include(s => s.StudentClassNavigation).Include(s => s.StudentGovNavigation).Include(s => s.StudentGradeNavigation).Include(s => s.StudentNatNavigation).Include(s => s.StudentStatusNavigation);
//            return View(await studentAffairsContext.ToListAsync());
//        }

//        // GET: Students/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null || _context.Students == null)
//            {
//                return NotFound();
//            }

//            var student = await _context.Students
//                .Include(s => s.CityNavigation)
//                .Include(s => s.GuardianNavigation)
//                .Include(s => s.ReligonNavigation)
//                .Include(s => s.StudentBranchNavigation)
//                .Include(s => s.StudentClassNavigation)
//                .Include(s => s.StudentGovNavigation)
//                .Include(s => s.StudentGradeNavigation)
//                .Include(s => s.StudentNatNavigation)
//                .Include(s => s.StudentStatusNavigation)
//                .FirstOrDefaultAsync(m => m.StudentId == id);
//            if (student == null)
//            {
//                return NotFound();
//            }

//            return View(student);
//        }

//        // GET: Students/Create
//        public IActionResult Create()
//        {
//            ViewData["City"] = new SelectList(_context.Cities, "CityId", "CityName");
//            ViewData["Guardian"] = new SelectList(_context.Guardians, "GuardianId", "GuardianName");
//            ViewData["Religon"] = new SelectList(_context.Religions, "ReligionId", "ReligionName");
//            ViewData["StudentBranch"] = new SelectList(_context.Branches, "BranchId", "BranchName");
//            ViewData["StudentClass"] = new SelectList(_context.Classes, "ClassId", "ClassName");
//            ViewData["StudentGov"] = new SelectList(_context.Govenantes, "GovId", "GovName");
//            ViewData["StudentGrade"] = new SelectList(_context.Grades, "GradeId", "GradeName");
//            ViewData["StudentNat"] = new SelectList(_context.Nationalities, "NatId", "NatName");
//            ViewData["StudentStatus"] = new SelectList(_context.Statuses, "StatusId", "StatusName");
//            return View();
//        }

//        // POST: Students/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("StudentId,StudentBranch,StudentGrade,StudentClass,StudentCode,StudentNid,StudentNat,StudentStatus,JoinYear,StaffSon,Guardian,ParentsSeparated,SchoolAbrev,StudentUpdate,StudentArabicFName,StudentArabicMName,StudentArabicLName,StudentArabicFmName,StudentEnglishFName,StudentEnglishMName,StudentEnglishLName,StudentEnglishFmName,Dob,BirthPlace,Gender,Religon,City,StudentAddress,StudentEmail,StudentPassword,StudentAffairs1,StudentAffairs2,BirthCode,StudentGov,EmergencyContact,EmergencyPhone")] Student student)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(student);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["City"] = new SelectList(_context.Cities, "CityId", "CityName", student.City);
//            ViewData["Guardian"] = new SelectList(_context.Guardians, "GuardianId", "GuardianName", student.Guardian);
//            ViewData["Religon"] = new SelectList(_context.Religions, "ReligionId", "ReligionName", student.Religon);
//            ViewData["StudentBranch"] = new SelectList(_context.Branches, "BranchId", "BranchName", student.StudentBranch);
//            ViewData["StudentClass"] = new SelectList(_context.Classes, "ClassId", "ClassName", student.StudentClass);
//            ViewData["StudentGov"] = new SelectList(_context.Govenantes, "GovId", "GovName", student.StudentGov);
//            ViewData["StudentGrade"] = new SelectList(_context.Grades, "GradeId", "GradeName", student.StudentGrade);
//            ViewData["StudentNat"] = new SelectList(_context.Nationalities, "NatId", "NatName", student.StudentNat);
//            ViewData["StudentStatus"] = new SelectList(_context.Statuses, "StatusId", "StatusName", student.StudentStatus);
//            //ViewData["Gender"] = new SelectList(["Male","Female"], "StatusId", "StatusName", student.Gender);
//            return View(student);
//        }

//        // GET: Students/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null || _context.Students == null)
//            {
//                return NotFound();
//            }

//            var student = await _context.Students.FindAsync(id);
//            if (student == null)
//            {
//                return NotFound();
//            }
//            ViewData["City"] = new SelectList(_context.Cities, "CityId", "CityName", student.City);
//            ViewData["Guardian"] = new SelectList(_context.Guardians, "GuardianId", "GuardianName", student.Guardian);
//            ViewData["Religon"] = new SelectList(_context.Religions, "ReligionId", "ReligionName", student.Religon);
//            ViewData["StudentBranch"] = new SelectList(_context.Branches, "BranchId", "BranchName", student.StudentBranch);
//            ViewData["StudentClass"] = new SelectList(_context.Classes, "ClassId", "ClassName", student.StudentClass);
//            ViewData["StudentGov"] = new SelectList(_context.Govenantes, "GovId", "GovName", student.StudentGov);
//            ViewData["StudentGrade"] = new SelectList(_context.Grades, "GradeId", "GradeName", student.StudentGrade);
//            ViewData["StudentNat"] = new SelectList(_context.Nationalities, "NatId", "NatName", student.StudentNat);
//            ViewData["StudentStatus"] = new SelectList(_context.Statuses, "StatusId", "StatusName", student.StudentStatus);
//            return View(student);
//        }

//        // POST: Students/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("StudentId,StudentBranch,StudentGrade,StudentClass,StudentCode,StudentNid,StudentNat,StudentStatus,JoinYear,StaffSon,Guardian,ParentsSeparated,SchoolAbrev,StudentUpdate,StudentArabicFName,StudentArabicMName,StudentArabicLName,StudentArabicFmName,StudentEnglishFName,StudentEnglishMName,StudentEnglishLName,StudentEnglishFmName,Dob,BirthPlace,Gender,Religon,City,StudentAddress,StudentEmail,StudentPassword,StudentAffairs1,StudentAffairs2,BirthCode,StudentGov,EmergencyContact,EmergencyPhone")] Student student)
//        {
//            if (id != student.StudentId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(student);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!StudentExists(student.StudentId))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["City"] = new SelectList(_context.Cities, "CityId", "CityName", student.City);
//            ViewData["Guardian"] = new SelectList(_context.Guardians, "GuardianId", "GuardianName", student.Guardian);
//            ViewData["Religon"] = new SelectList(_context.Religions, "ReligionId", "ReligionName", student.Religon);
//            ViewData["StudentBranch"] = new SelectList(_context.Branches, "BranchId", "BranchName", student.StudentBranch);
//            ViewData["StudentClass"] = new SelectList(_context.Classes, "ClassId", "ClassName", student.StudentClass);
//            ViewData["StudentGov"] = new SelectList(_context.Govenantes, "GovId", "GovName", student.StudentGov);
//            ViewData["StudentGrade"] = new SelectList(_context.Grades, "GradeId", "GradeName", student.StudentGrade);
//            ViewData["StudentNat"] = new SelectList(_context.Nationalities, "NatId", "NatName", student.StudentNat);
//            ViewData["StudentStatus"] = new SelectList(_context.Statuses, "StatusId", "StatusName", student.StudentStatus);
//            return View(student);
//        }

//        // GET: Students/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null || _context.Students == null)
//            {
//                return NotFound();
//            }

//            var student = await _context.Students
//                .Include(s => s.CityNavigation)
//                .Include(s => s.GuardianNavigation)
//                .Include(s => s.ReligonNavigation)
//                .Include(s => s.StudentBranchNavigation)
//                .Include(s => s.StudentClassNavigation)
//                .Include(s => s.StudentGovNavigation)
//                .Include(s => s.StudentGradeNavigation)
//                .Include(s => s.StudentNatNavigation)
//                .Include(s => s.StudentStatusNavigation)
//                .FirstOrDefaultAsync(m => m.StudentId == id);
//            if (student == null)
//            {
//                return NotFound();
//            }

//            return View(student);
//        }

//        // POST: Students/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            if (_context.Students == null)
//            {
//                return Problem("Entity set 'StudentAffairsContext.Students'  is null.");
//            }
//            var student = await _context.Students.FindAsync(id);
//            if (student != null)
//            {
//                _context.Students.Remove(student);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool StudentExists(int id)
//        {
//            return (_context.Students?.Any(e => e.StudentId == id)).GetValueOrDefault();
//        }
//        public PartialViewResult RenderStudent()
//        {
//            return ((PartialViewResult)Create());
//        }
//    }
//}
