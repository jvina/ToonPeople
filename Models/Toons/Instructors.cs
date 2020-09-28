using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class Instructors
    {
        public Instructors()
        {
            Courses = new HashSet<Courses>();
        }

        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
    }
}
