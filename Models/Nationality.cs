using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class Nationality
    {
        public Nationality()
        {
            Parents = new HashSet<Parent>();
            Students = new HashSet<Student>();
        }

        public int NatId { get; set; }
        public string NatName { get; set; } = null!;

        public virtual ICollection<Parent> Parents { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
