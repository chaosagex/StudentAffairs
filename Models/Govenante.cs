using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class Govenante
    {
        public Govenante()
        {
            Students = new HashSet<Student>();
        }

        public int GovId { get; set; }
        public string GovName { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
