using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class Hospitals
    {
        public Hospitals()
        {
            Patients = new HashSet<Patients>();
        }

        public int HospitalId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Patients> Patients { get; set; }
    }
}
