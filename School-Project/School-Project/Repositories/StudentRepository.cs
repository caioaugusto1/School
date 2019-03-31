using School_Project.Context;
using School_Project.Entities;
using School_Project.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace School_Project.Repositories
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(SchoolDBContext schoolDBContext) : base(schoolDBContext)
        {
        }

        public List<Student> GetAllAvaliable()
        {
            return (_schoolDBContext.Student.Where(c => c.Courses.Count < 6)).ToList();
        }
    }
}