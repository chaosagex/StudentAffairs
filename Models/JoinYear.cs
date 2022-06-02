using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class JoinYear
    {
        public JoinYear()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
