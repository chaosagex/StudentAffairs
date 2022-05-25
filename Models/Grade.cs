using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class Grade
    {
        public Grade()
        {
            Classes = new HashSet<Class>();
            Students = new HashSet<Student>();
        }

        public int GradeId { get; set; }
        public string GradeName { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
