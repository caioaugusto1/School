using School_Project.Entities;
using School_Project.Models.Courses;
using System;
using System.Collections.Generic;

namespace School_Project.Models.StudentsCourses
{
    public class ListCoursesAvaliableVM
    {
        public Guid IdStudent { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string DOB { get; set; }

        public List<CourseVM> CoursesVM { get; set; }

        public ListCoursesAvaliableVM(Student student, List<Course> courses)
        {
            IdStudent = student.Id;
            FirstName = student.FirstName;
            SurName = student.SurName;
            DOB = student.DOB.ToString();

            CoursesVM = new List<CourseVM>();

            courses.ForEach(course =>
            {
                CoursesVM.Add(new CourseVM()
                {
                    Id = course.Id,
                    Name = course.Name,
                    StartDate = course.StartDate.ToString(),
                    EndDate = course.EndDate.ToString(),
                    NumberVacancies = course.NumberVacancies.ToString(),
                    TeacherName = course.TeacherName
                });
            });
        }
    }
}