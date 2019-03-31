using School_Project.Entities;
using System;
using System.Collections.Generic;

namespace School_Project.Repositories.Interfaces
{
    public interface ICourseStudentRepository
    {
        List<CourseStudent> FindByIdStudent(Guid idStudent);

        List<CourseStudent> GetStudentsByIdCourse(Guid idCourse);
    }
}
