using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Students = new HashSet<Student>();
        }

        public int BranchId { get; set; }
        public string BranchName { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
