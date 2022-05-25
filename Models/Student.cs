using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentAffairs.Models
{
    public partial class Student
    {
        public Student()
        {
            Parents = new HashSet<Parent>();
        }

        public int StudentId { get; set; }
        public int? StudentBranch { get; set; }
        public int? StudentGrade { get; set; }
        public int? StudentClass { get; set; }
        public string StudentCode { get; set; } = null!;
        public string StudentNid { get; set; } = null!;
        public int? StudentNat { get; set; }
        public int? StudentStatus { get; set; }
        public string JoinYear { get; set; } = null!;
        public bool StaffSon { get; set; }
        public int? Guardian { get; set; }
        public bool ParentsSeparated { get; set; }
        public string SchoolAbrev { get; set; } = null!;
        public bool StudentUpdate { get; set; }
        public string StudentArabicFName { get; set; } = null!;
        public string StudentArabicMName { get; set; } = null!;
        public string StudentArabicLName { get; set; } = null!;
        public string StudentArabicFmName { get; set; } = null!;
        public string StudentEnglishFName { get; set; } = null!;
        public string StudentEnglishMName { get; set; } = null!;
        public string StudentEnglishLName { get; set; } = null!;
        public string StudentEnglishFmName { get; set; } = null!;
        [DataType(DataType.Date)]
        public DateTime? Dob { get; set; }
        public string BirthPlace { get; set; } = null!;
        public byte Gender { get; set; }
        public int? Religon { get; set; }
        public int? City { get; set; }
        public string StudentAddress { get; set; } = null!;
        public string StudentEmail { get; set; } = null!;
        public string StudentPassword { get; set; } = null!;
        public string StudentAffairs1 { get; set; } = null!;
        public string StudentAffairs2 { get; set; } = null!;
        public string BirthCode { get; set; } = null!;
        public int? StudentGov { get; set; }
        public string EmergencyContact { get; set; } = null!;
        public string EmergencyPhone { get; set; } = null!;

        public virtual City? CityNavigation { get; set; }
        public virtual Guardian? GuardianNavigation { get; set; }
        public virtual Religion? ReligonNavigation { get; set; }
        public virtual Branch? StudentBranchNavigation { get; set; }
        public virtual Class? StudentClassNavigation { get; set; }
        public virtual Govenante? StudentGovNavigation { get; set; }
        public virtual Grade? StudentGradeNavigation { get; set; }
        public virtual Nationality? StudentNatNavigation { get; set; }
        public virtual Status? StudentStatusNavigation { get; set; }

        public virtual ICollection<Parent> Parents { get; set; }
    }
}
