using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Project.Entities
{
    public class CourseStudent
    {
        [NotMapped]
        public Guid IdStudent { get; set; }

        [NotMapped]
        public Guid IdCourse { get; set; }

        //public virtual List<Student> Students { get; set; }

        //public virtual List<Course> Courses { get; set; }
    }
}