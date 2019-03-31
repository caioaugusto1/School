using School_Project.Entities;
using System;
using System.Collections.Generic;

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

        public List<StudentVM> Students { get; set; }

        public ListCourseManyStudentsVM(Course course)
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

        public ListCourseManyStudentsVM(Course course, List<Student> students)
        {
            IdCourse = course.Id;
            TeacherName = course.TeacherName;
            StartDate = course.StartDate.ToString("dd/MM/yyyy");
            EndDate = course.EndDate.ToString("dd/MM/yyyy");
            NumberVacancies = course.NumberVacancies.ToString();

            Students = new List<StudentVM>();

            foreach (var student in students)
            {
                StudentVM studentVM = new StudentVM();

                studentVM.FirstName = student.FirstName;
                studentVM.SurName = student.SurName;
                studentVM.DOB = student.DOB.ToString();
                studentVM.Gender = student.Gender;

                Students.Add(studentVM);
            }
        }
    }
}