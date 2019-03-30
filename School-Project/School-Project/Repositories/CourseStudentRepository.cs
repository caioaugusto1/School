using School_Project.Context;
using School_Project.Entities;
using School_Project.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace School_Project.Repositories
{
    public class CourseStudentRepository : RepositoryBase<CourseStudent>, ICourseStudentRepository
    {
        public CourseStudentRepository(SchoolDBContext schoolDBContext) : base(schoolDBContext)
        {
        }

        public List<CourseStudent> FindByIdStudent(Guid idStudent)
        {
            throw new System.NotImplementedException();
        }
    }
}