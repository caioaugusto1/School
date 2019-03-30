using School_Project.Context;
using School_Project.Entities;
using School_Project.Repositories.Interfaces;

namespace School_Project.Repositories
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(SchoolDBContext schoolDBContext) : base(schoolDBContext)
        {
        }
    }
}