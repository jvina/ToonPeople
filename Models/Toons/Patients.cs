using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class Patients
    {
        public Patients()
        {
            Sicknesses = new HashSet<Sicknesses>();
        }

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RoomNumber { get; set; }
        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }
        public int HospitalId { get; set; }

        public virtual Hospitals Hospital { get; set; }
        public virtual ICollection<Sicknesses> Sicknesses { get; set; }
    }
}
