using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class Species
    {
        public Species()
        {
            Organisms = new HashSet<Organisms>();
        }

        public string SpecieName { get; set; }

        public virtual ICollection<Organisms> Organisms { get; set; }
    }
}
