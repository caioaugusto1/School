using School_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Project.Models.StudentsCourses
{
    public class ListCourseManyStudentsVM
    {
        public Guid IdCourse { get; set; }

        public string Name { get; set; }

        public string TeacherName { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string NumberVacancies { get; set; }

        public List<CStudentVM> Students { get; set; }

        public class CStudentVM : StudentVM
        {
            public bool StudentIncluedInCourse { get; set; }
        }

        public ListCourseManyStudentsVM(Course course)
        {
            IdCourse = course.Id;
            TeacherName = course.TeacherName;
            StartDate = course.StartDate.ToString("dd/MM/yyyy");
            EndDate = course.EndDate.ToString("dd/MM/yyyy");
            NumberVacancies = course.NumberVacancies.ToString();

            Students = new List<CStudentVM>();

            foreach (var courseStudent in course.Students)
            {
                CStudentVM studentVM = new CStudentVM();

                studentVM.Id = courseStudent.Id;
                studentVM.FirstName = courseStudent.FirstName;
                studentVM.SurName = courseStudent.SurName;
                studentVM.DOB = courseStudent.DOB.ToString();
                studentVM.Gender = courseStudent.Gender;
                studentVM.StudentIncluedInCourse = course.Students.Any(sc => sc.Id == courseStudent.Id) ? false : true;

                Students.Add(studentVM);
            }
        }

        public ListCourseManyStudentsVM(Course course, List<Student> students)
        {
            IdCourse = course.Id;
            TeacherName = course.TeacherName;
            StartDate = course.StartDate.ToString("dd/MM/yyyy");
            EndDate = course.EndDate.ToString("dd/MM/yyyy");
            NumberVacancies = course.NumberVacancies.ToString();

            Students = new List<CStudentVM>();

            foreach (var student in students)
            {
                CStudentVM studentVM = new CStudentVM();

                studentVM.Id = student.Id;
                studentVM.FirstName = student.FirstName;
                studentVM.SurName = student.SurName;
                studentVM.DOB = student.DOB.ToString();
                studentVM.Gender = student.Gender;
                studentVM.StudentIncluedInCourse = student.Courses.Any(sc => sc.Id == course.Id) ? false : true;

                Students.Add(studentVM);
            }
        }
    }
}