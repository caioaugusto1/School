using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Project.Entities
{
    public class CourseStudent
    {
        public Guid IdStudent { get; set; }

        public Guid IdCourse { get; set; }
    }
}