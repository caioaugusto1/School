using School_Project.Entities;
using System.Data.Entity.ModelConfiguration;

namespace School_Project.Context.EntitiesConfig
{
    public class StudentEntityConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentEntityConfiguration()
        {
            ToTable("Student");

            HasKey(s => s.Id);

            Property(p => p.FirstName)
                    .HasMaxLength(40);

            Property(p => p.SurName)
                    .HasMaxLength(40);

            Property(p => p.DOB)
                    .HasColumnName("DOB")
                    .HasColumnOrder(3)
                    .HasColumnType("datetime2");

            HasMany<Course>(s => s.Courses)
                .WithMany(c => c.Students)
                .Map(sc =>
                {
                    sc.MapLeftKey("Course_Id");
                    sc.MapRightKey("Student_Id");
                    sc.ToTable("CourseStudents");
                });
        }
    }
}