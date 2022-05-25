using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class Parent
    {
        public Parent()
        {
            Students = new HashSet<Student>();
        }

        public int ParentId { get; set; }
        public int ParentType { get; set; }
        public string ParentEnglishName { get; set; } = null!;
        public string ParentArabicName { get; set; } = null!;
        public string ParentNid { get; set; } = null!;
        public string ParentMobilephone { get; set; } = null!;
        public string ParentEmail { get; set; } = null!;
        public string ParentJob { get; set; } = null!;
        public string ParentQualification { get; set; } = null!;
        public int? ParentLanguage { get; set; }
        public int? ParentNationality { get; set; }

        public virtual Language? ParentLanguageNavigation { get; set; }
        public virtual Nationality? ParentNationalityNavigation { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
