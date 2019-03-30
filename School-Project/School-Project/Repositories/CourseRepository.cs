using School_Project.Context;
using School_Project.Entities;
using School_Project.Repositories.Interfaces;

namespace School_Project.Repositories
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(SchoolDBContext schoolDBContext) : base(schoolDBContext)
        {

        }
    }
}