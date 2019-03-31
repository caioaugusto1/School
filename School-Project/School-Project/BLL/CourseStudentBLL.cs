using School_Project.Entities;
using School_Project.Models.StudentsCourses;
using School_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<Student> GetStudentsAvaliable()
        {
            return _studentRepository.GetAllAvaliable();
        }

        public ListCourseManyStudentsVM OneCourseManyStudent(Guid idCourse)
        {
            Course courses = _courseRepository.GetById(idCourse);

            ListCourseManyStudentsVM linkCourseManyStudentsVM = new ListCourseManyStudentsVM(courses);

            return linkCourseManyStudentsVM;
        }

        public bool CreateLinkCourseToStudent(Guid idStudent, Guid idCourse)
        {
            Course course = _courseRepository.GetById(idCourse);
            Student student = _studentRepository.GetById(idStudent);

            if (course == null || student == null)
                return false;

            if (student.Courses.Count >= 5)
                return false;

            course.Students.Add(student);

            _courseRepository.Update(course, idCourse);

            return true;
        }

        public bool RemoveLinkCourseToStudent(Guid idStudent, Guid idCourse)
        {
            Course course = _courseRepository.GetById(idCourse);
            Student student = _studentRepository.GetById(idStudent);

            if (course == null || student == null)
                return false;

            course.Students.Remove(student);

            _courseRepository.Update(course, idCourse);

            return true;
        }
    }
}