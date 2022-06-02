using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentAffairs.Models
{
    public partial class Student
    {
        
        public int StudentId { get; set; }
        [Required]
        public int? StudentBranch { get; set; }
        [Required]
        public int? StudentGrade { get; set; }
        
        public int? StudentClass { get; set; } = null!;
        public string? StudentCode { get; set; } = null!;
        [Required(ErrorMessage = "You need to put the 14 National id numbers")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "You need to put the 14 National id numbers")]
        [StringLength(14,MinimumLength = 14, ErrorMessage = "You need to put the 14 National id numbers")]
        
        public string? StudentNid { get; set; }
        [Required]
        public int? StudentNat { get; set; }
        public int? StudentStatus { get; set; } = null!;
        [Required]
        public int JoinYear { get; set; }
        public bool? StaffSon { get; set; } = null!;
        public int? Guardian { get; set; }
        public byte? ParentsSeparated { get; set; }
        public string? SchoolAbrev { get; set; } = null!;
        public bool? StudentUpdate { get; set; } = false!;
        [Required]
        [RegularExpression("^[\u0621-\u064A]+$", ErrorMessage = "أدخل الأسم بالعربية")]
        
        public string StudentArabicFName { get; set; } = null!;
        [Required]
        [RegularExpression("^[\u0621-\u064A]+$", ErrorMessage = "أدخل الأسم بالعربية")]
        public string StudentArabicMName { get; set; } = null!;
        [Required]
        [RegularExpression("^[\u0621-\u064A]+$", ErrorMessage = "أدخل الأسم بالعربية")]
        public string StudentArabicLName { get; set; } = null!;
        [Required]
        [RegularExpression("^[\u0621-\u064A]+$", ErrorMessage = "أدخل الأسم بالعربية")]
        public string StudentArabicFmName { get; set; } = null!;
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "enter the name in english")]
        
        public string StudentEnglishFName { get; set; } = null!;
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "enter the name in english")]
        public string StudentEnglishMName { get; set; } = null!;
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "enter the name in english")]
        public string StudentEnglishLName { get; set; } = null!;
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "enter the name in english")]
        public string StudentEnglishFmName { get; set; } = null!;
        [DataType(DataType.Date)]
        [Required]
        public DateTime? Dob { get; set; }
        [Required]
        public string BirthPlace { get; set; } = null!;
        public byte Gender { get; set; }
        public int? Religon { get; set; }
        public int? City { get; set; }
        [Required]
        public string StudentAddress { get; set; } = null!;
        public string? StudentEmail { get; set; } = null!;
        public string? StudentPassword { get; set; } = null!;
        public string? StudentAffairs1 { get; set; } = null!;
        public string? StudentAffairs2 { get; set; } = null!;
        public string? BirthCode { get; set; } = null!;
        public int? StudentGov { get; set; }
        [Required]
        public string EmergencyContact { get; set; } = null!;
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string EmergencyPhone { get; set; } = null!;
        public int? StudentFather { get; set; } = null!;
        public int? StudentMother { get; set; } = null!;
        public string? StudentPassport { get; set; } = null!;
        public string? OldSchool { get; set; } = null!;
        public int ApplyingForGrade { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string? OldSchoolNumber { get; set; } = null!;
        public string? LeavingReason { get; set; } = null!;
        public byte AppliedBefore { get; set; }
        public byte HaveSibling { get; set; }
        public byte SubscribeBus { get; set; }
        [Required]
        public string ReferenceName1 { get; set; } = null!;
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string ReferencePhone1 { get; set; } = null!;
        [Required]
        
        public string ReferenceName2 { get; set; } = null!;
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string ReferencePhone2 { get; set; } = null!;

        public virtual Grade? ApplyingForGradeNavigation { get; set; } = null!;
        public virtual City? CityNavigation { get; set; }
        public virtual Guardian? GuardianNavigation { get; set; }
        public virtual JoinYear? JoinYearNavigation { get; set; } = null!;
        public virtual Religion? ReligonNavigation { get; set; }
        public virtual Branch? StudentBranchNavigation { get; set; }
        public virtual Class? StudentClassNavigation { get; set; }
        public virtual Parent? StudentFatherNavigation { get; set; }
        public virtual Govenante? StudentGovNavigation { get; set; }
        public virtual Grade? StudentGradeNavigation { get; set; }
        public virtual Parent? StudentMotherNavigation { get; set; }
        public virtual Nationality? StudentNatNavigation { get; set; }
        public virtual Status? StudentStatusNavigation { get; set; }
    }
}
