using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class Guardian
    {
        public Guardian()
        {
            Students = new HashSet<Student>();
        }

        public int GuardianId { get; set; }
        public string GuardianName { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
