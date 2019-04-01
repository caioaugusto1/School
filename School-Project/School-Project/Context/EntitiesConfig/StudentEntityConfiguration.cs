using School_Project.Entities;
using System.Data.Entity.ModelConfiguration;

namespace School_Project.Context.EntitiesConfig
{
    public class StudentEntityConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentEntityConfiguration()
        {
            ToTable("Students");

            HasKey(s => s.Id);

            Property(p => p.FirstName)
                    .HasMaxLength(40)
                    .HasColumnType("varchar");

            Property(p => p.SurName)
                    .HasMaxLength(40)
                    .HasColumnType("varchar");

            Property(p => p.Address1)
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

            Property(p => p.Address2)
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

            Property(p => p.Address3)
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

            Property(p => p.DOB)
                    .HasColumnName("DOB")
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