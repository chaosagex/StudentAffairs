using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentAffairs.Models
{
    public partial class Parent
    {
        public Parent()
        {
            StudentStudentFatherNavigations = new HashSet<Student>();
            StudentStudentMotherNavigations = new HashSet<Student>();
        }

        public int ParentId { get; set; }
        public int ParentType { get; set; }
        
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "enter the name in english")]
        public string? ParentEnglishName { get; set; } = null!;
        
        [RegularExpression("^[\u0621-\u064A]+$", ErrorMessage = "أدخل الأسم بالعربية")]
        public string? ParentArabicName { get; set; } = null!;
        [Required(ErrorMessage = "You need to put the 14 National id numbers")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "You need to put the 14 National id numbers")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "You need to put the 14 National id numbers")]
        public string? ParentNid { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string ParentMobilephone { get; set; } = null!;
        
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string ParentEmail { get; set; } = null!;
        [Required]
        public string ParentJob { get; set; } = null!;
        public int? ParentQualification { get; set; }
        public int? ParentLanguage { get; set; }
        public int? ParentNationality { get; set; }
        public string? ParentPassport { get; set; } = null!;
        [Required]
        public string ParentJobLocation { get; set; } = null!;

        public virtual Language? ParentLanguageNavigation { get; set; }
        public virtual Nationality? ParentNationalityNavigation { get; set; }
        public virtual Qualification? ParentQualificationNavigation { get; set; }
        public virtual ICollection<Student> StudentStudentFatherNavigations { get; set; }
        public virtual ICollection<Student> StudentStudentMotherNavigations { get; set; }
    }
}
