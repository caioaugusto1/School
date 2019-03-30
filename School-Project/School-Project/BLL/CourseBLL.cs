﻿using School_Project.Entities;
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

        public List<Course> ListAll()
        {
            var sss = _courseRepository.GetAll();
            
            return _courseRepository.GetAll();
        }
    }
}