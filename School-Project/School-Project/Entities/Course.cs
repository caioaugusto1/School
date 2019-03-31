using System;
using System.Collections.Generic;

namespace School_Project.Entities
{
    public class Course
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string TeacherName { get; set; }

        public int NumberVacancies { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}