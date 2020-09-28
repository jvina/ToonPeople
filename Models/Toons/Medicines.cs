using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class Medicines
    {
        public int MedicineId { get; set; }
        public string Name { get; set; }
        public string DosageUnit { get; set; }
        public int Dosage { get; set; }
        public int SicknessId { get; set; }
        public int FrequencyInHours { get; set; }

        public virtual Sicknesses Sickness { get; set; }
    }
}
