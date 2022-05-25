using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class Religion
    {
        public Religion()
        {
            Students = new HashSet<Student>();
        }

        public int ReligionId { get; set; }
        public string ReligionName { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
