using System;
using System.Collections.Generic;

namespace lab_2.Models.Toons
{
    public partial class Courses
    {
        public string CourseId { get; set; }
        public string Name { get; set; }
        public int InstructorId { get; set; }

        public virtual Instructors Instructor { get; set; }
    }
}
