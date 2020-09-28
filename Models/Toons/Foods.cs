using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class Foods
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public float UnitPrice { get; set; }
        public int FoodCategoryId { get; set; }

        public virtual FoodCategories FoodCategory { get; set; }
    }
}
