using School_Project.Entities;
using School_Project.Models.StudentsCourses;
using School_Project.Repositories;
using System;

namespace School_Project.BLL
{
    public class CourseStudentBLL
    {
        private CourseStudentRepository _courseStudentRepository;

        private CourseRepository _courseRepository;

        private StudentRepository _studentRepository;

        public CourseStudentBLL(CourseStudentRepository courseStudentRepository,
            CourseRepository courseRepository,
            StudentRepository studentRepository)
        {
            _courseRepository = courseRepository;
            _courseStudentRepository = courseStudentRepository;
            _studentRepository = studentRepository;
        }

        public LinkCourseManyStudentsVM OneCourseManyStudent(Guid idCourse)
        {
            Course courses = _courseRepository.GetById(idCourse);

            LinkCourseManyStudentsVM linkCourseManyStudentsVM = new LinkCourseManyStudentsVM(courses);

            return linkCourseManyStudentsVM;
        }
        
        public void CreateLinkCourseToStudent(Guid idStudent, Guid idCourse)
        {
            CourseStudent courses = _courseStudentRepository.GetById(idStudent);

            if (courses != null)
            {

            }
        }
    }
}