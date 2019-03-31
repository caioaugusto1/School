using System;
using System.Collections.Generic;

namespace School_Project.Models.Courses
{
    public class CourseVM
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string TeacherName { get; set; }

        public string NumberVacancies { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public virtual List<StudentVM> Students { get; set; }
    }
}