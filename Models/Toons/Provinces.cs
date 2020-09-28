using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class Provinces
    {
        public Provinces()
        {
            Cities = new HashSet<Cities>();
        }

        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public string CapitalCity { get; set; }
        public string CountryName { get; set; }

        public virtual Countries CountryNameNavigation { get; set; }
        public virtual ICollection<Cities> Cities { get; set; }
    }
}
