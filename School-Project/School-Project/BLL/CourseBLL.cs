using School_Project.Entities;
using School_Project.Enum;
using School_Project.Filters;
using School_Project.Repositories;
using System;
using System.Collections.Generic;

namespace School_Project.BLL
{
    public class CourseBLL
    {
        private CourseRepository _courseRepository;

        public CourseBLL(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void Create(Course course)
        {
            course.Id = new Guid();

            _courseRepository.Insert(course);
        }

        public List<Course> GetAll()
        {
            var session = SessionManager.AccountLogin;

            if (session.Type == LoginType.A.ToString())
                return _courseRepository.GetAll();

            return null;
        }

        public Course GetById(Guid idCourse)
        {
            return _courseRepository.GetById(idCourse);
        }

        public List<Course> GetCoursesAvaliable()
        {
            return _courseRepository.GetAvaliable();
        }
    }
}