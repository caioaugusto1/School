using School_Project.Context.EntitiesConfig;
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
            modelBuilder.Configurations.Add(new LoginEntityConfiguration());
            modelBuilder.Entity<Course>().HasMany(x => x.Students);
            //modelBuilder.Configurations.Add(new StudentEntityConfiguration());
            modelBuilder.Entity<Student>().HasMany(x => x.Courses);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Student> Student { get; set; }

        public virtual DbSet<CourseStudent> CourseStudents { get; set; }

        public virtual DbSet<Course> Course { get; set; }

        public virtual DbSet<Login> Login { get; set; }

    }
}