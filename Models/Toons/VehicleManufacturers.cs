using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class VehicleManufacturers
    {
        public VehicleManufacturers()
        {
            Vehicles = new HashSet<Vehicles>();
        }

        public string VehicleManufacturerName { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Vehicles> Vehicles { get; set; }
    }
}
