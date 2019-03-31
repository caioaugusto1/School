using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Project.Entities
{
    public class CourseStudent
    {
        [NotMapped]
        public Guid IdStudent { get; set; }

        [NotMapped]
        public Guid IdCourse { get; set; }
    }
}