using School_Project.Entities;
using System.Data.Entity;

namespace School_Project.Context
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext()
            : base("ContextSchoolDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasMany(x => x.Students);
            modelBuilder.Entity<Student>().HasMany(x => x.Courses);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}