using School_Project.Entities;
using System.Collections.Generic;

namespace School_Project.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        List<Course> GetAvaliable();

        List<Course> GetNotAvaliable();
        
    }
}
