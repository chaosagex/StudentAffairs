using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class Grade
    {
        public Grade()
        {
            Classes = new HashSet<Class>();
            StudentApplyingForGradeNavigations = new HashSet<Student>();
            StudentStudentGradeNavigations = new HashSet<Student>();
        }

        public int GradeId { get; set; }
        public string GradeName { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Student> StudentApplyingForGradeNavigations { get; set; }
        public virtual ICollection<Student> StudentStudentGradeNavigations { get; set; }
    }
}
