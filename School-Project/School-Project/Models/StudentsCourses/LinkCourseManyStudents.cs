using School_Project.Entities;
using System;
using System.Collections.Generic;

namespace School_Project.Models.StudentsCourses
{
    public class LinkCourseManyStudentsVM
    {
        public Guid IdCourse { get; set; }

        public string Name { get; set; }

        public string TeacherName { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string NumberVacancies { get; set; }

        public List<StudentVM> Students { get; set; }

        public LinkCourseManyStudentsVM(Course course)
        {
            IdCourse = course.Id;
            TeacherName = course.TeacherName;
            StartDate = course.StartDate.ToString("dd/MM/yyyy");
            EndDate = course.EndDate.ToString("dd/MM/yyyy");
            NumberVacancies = course.NumberVacancies.ToString();

            Students = new List<StudentVM>();

            foreach (var courseStudent in course.Students)
            {
                StudentVM studentVM = new StudentVM();

                studentVM.FirstName = courseStudent.FirstName;
                studentVM.SurName = courseStudent.SurName;
                studentVM.DOB = courseStudent.DOB.ToString();
                studentVM.Gender = courseStudent.Gender;

                Students.Add(studentVM);
            }
        }
    }
}