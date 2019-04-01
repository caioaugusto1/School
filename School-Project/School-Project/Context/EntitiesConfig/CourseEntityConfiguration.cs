using School_Project.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace School_Project.Context.EntitiesConfig
{
    public class CourseEntityConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseEntityConfiguration()
        {
            ToTable("Courses");

            HasKey(s => s.Id);

            Property(p => p.Name)
                    .HasMaxLength(40)
                    .HasColumnType("varchar");

            Property(p => p.TeacherName)
                    .HasMaxLength(40)
                    .HasColumnType("varchar");

            HasMany<Student>(s => s.Students)
                .WithMany(c => c.Courses)
                .Map(sc =>
                {
                    sc.MapLeftKey("Student_Id");
                    sc.MapRightKey("Course_Id");
                    sc.ToTable("CourseStudents");
                });
        }
    }
}