using School_Project.Context;
using School_Project.Entities;
using School_Project.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Project.Repositories
{
    public class CourseStudentRepository : RepositoryBase<CourseStudent>, ICourseStudentRepository
    {
        public CourseStudentRepository(SchoolDBContext schoolDBContext) : base(schoolDBContext)
        {
        }

        public List<CourseStudent> FindByIdStudent(Guid idStudent)
        {
            return _schoolDBContext.CourseStudents.Where(l => l.IdStudent == idStudent).ToList();
        }

        public List<CourseStudent> GetStudentsByIdCourse(Guid idCourse)
        {
            return _schoolDBContext.CourseStudents.Where(l => l.IdCourse == idCourse).ToList();
        }
    }
}