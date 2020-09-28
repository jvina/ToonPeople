using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class FoodCategories
    {
        public FoodCategories()
        {
            Foods = new HashSet<Foods>();
        }

        public int FoodCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Foods> Foods { get; set; }
    }
}
