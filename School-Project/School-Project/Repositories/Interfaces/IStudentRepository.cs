using School_Project.Entities;
using System.Collections.Generic;

namespace School_Project.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAllAvaliable();
    }
}
