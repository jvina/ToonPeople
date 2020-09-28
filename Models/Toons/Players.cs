using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class Players
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string TeamName { get; set; }

        public virtual Teams TeamNameNavigation { get; set; }
    }
}
