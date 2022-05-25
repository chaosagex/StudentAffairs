using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class Status
    {
        public Status()
        {
            Students = new HashSet<Student>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
