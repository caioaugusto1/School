using School_Project.Entities;
using School_Project.Models.StudentsCourses;
using School_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Helpers;
using System.Web.Mvc;

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

        public HttpStatusCode CreateLinkStudentToCourse(Guid idStudent, Guid idCourse)
        {
            Course courseSelected = _courseRepository.GetById(idCourse);
            Student student = _studentRepository.GetById(idStudent);

            if (courseSelected == null || student == null)
                return HttpStatusCode.NotFound;

            if (student.Courses.Count >= 5)
                return HttpStatusCode.Conflict;

            if (courseSelected.Students.Count >= courseSelected.NumberVacancies)
                return HttpStatusCode.Conflict;

            foreach (var course in student.Courses)
            {
                if (courseSelected.StartDate >= course.StartDate || courseSelected.EndDate <= course.EndDate)
                    return HttpStatusCode.Conflict;
            }


            courseSelected.Students.Add(student);

            _courseRepository.Update(courseSelected, idCourse);

            return HttpStatusCode.NoContent;
        }

        public HttpStatusCode RemoveLinkStudentToCourse(Guid idStudent, Guid idCourse)
        {
            Course course = _courseRepository.GetById(idCourse);
            Student student = _studentRepository.GetById(idStudent);

            if (course == null || student == null)
                return HttpStatusCode.NotFound;

            course.Students.Remove(student);

            _courseRepository.Update(course, idCourse);

            return HttpStatusCode.NoContent;
        }

        public HttpStatusCode CreateLinkCourseToStudent(Guid idStudent, Guid idCourse)
        {
            Course courseSelected = _courseRepository.GetById(idCourse);
            Student student = _studentRepository.GetById(idStudent);

            if (courseSelected == null || student == null)
                return HttpStatusCode.NotFound;

            if (student.Courses.Count >= 5)
                return HttpStatusCode.Conflict;

            if (courseSelected.Students.Count >= courseSelected.NumberVacancies)
                return HttpStatusCode.Conflict;

            foreach (var course in student.Courses)
            {
                if (courseSelected.StartDate >= course.StartDate || courseSelected.EndDate <= course.EndDate)
                    return HttpStatusCode.Conflict;
            }

            student.Courses.Add(courseSelected);

            _studentRepository.Update(student, idStudent);

            return HttpStatusCode.NoContent;
        }

        public HttpStatusCode RemoveLinkCourseToStudent(Guid idStudent, Guid idCourse)
        {
            Course course = _courseRepository.GetById(idCourse);
            Student student = _studentRepository.GetById(idStudent);

            if (course == null || student == null)
                return HttpStatusCode.NotFound;

            student.Courses.Remove(course);

            _studentRepository.Update(student, idStudent);

            return HttpStatusCode.NoContent;
        }
    }
}