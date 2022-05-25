using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class City
    {
        public City()
        {
            Students = new HashSet<Student>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
