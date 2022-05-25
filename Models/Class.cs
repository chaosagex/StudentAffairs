using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public int ClassId { get; set; }
        public string ClassName { get; set; } = null!;
        public int? ClassGrade { get; set; }

        public virtual Grade? ClassGradeNavigation { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
