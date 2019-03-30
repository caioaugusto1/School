using System;
using System.Collections.Generic;

namespace School_Project.Entities
{
    public class Student
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public char Gender { get; set; }

        public DateTime DOB { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public virtual List<Course> Courses { get; set; }
    }
}