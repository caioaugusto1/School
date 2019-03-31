using School_Project.Entities;
using School_Project.Models.Courses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Project.Models.StudentsCourses
{
    public class ListCoursesAvaliableVM
    {
        public Guid IdStudent { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string DOB { get; set; }

        public List<StudentCourseVM> CoursesVM { get; set; }

        public class StudentCourseVM : CourseVM
        {
            public bool StudentIncluedInCourse { get; set; }
        }

        public ListCoursesAvaliableVM(Student student, List<Course> courses)
        {
            IdStudent = student.Id;
            FirstName = student.FirstName;
            SurName = student.SurName;
            DOB = student.DOB.ToString();

            CoursesVM = new List<StudentCourseVM>();

            courses.ForEach(course =>
            {
                CoursesVM.Add(new StudentCourseVM()
                {
                    Id = course.Id,
                    Name = course.Name,
                    StartDate = course.StartDate.ToString(),
                    EndDate = course.EndDate.ToString(),
                    NumberVacancies = course.NumberVacancies.ToString(),
                    TeacherName = course.TeacherName,
                    StudentIncluedInCourse = student.Courses.Any(sc => sc.Id == course.Id) ? false : true
                });
            });
        }
    }
}