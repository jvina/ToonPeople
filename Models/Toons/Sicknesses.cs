using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class Sicknesses
    {
        public Sicknesses()
        {
            Medicines = new HashSet<Medicines>();
        }

        public int SicknessId { get; set; }
        public string SicknessName { get; set; }
        public int PatientId { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual ICollection<Medicines> Medicines { get; set; }
    }
}
