using System;
using System.Collections.Generic;

namespace StudentAffairs.Models
{
    public partial class Language
    {
        public Language()
        {
            Parents = new HashSet<Parent>();
        }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; } = null!;

        public virtual ICollection<Parent> Parents { get; set; }
    }
}
