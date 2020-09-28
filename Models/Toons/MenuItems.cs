using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class MenuItems
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public int RestaurantId { get; set; }

        public virtual Restaurants Restaurant { get; set; }
    }
}
