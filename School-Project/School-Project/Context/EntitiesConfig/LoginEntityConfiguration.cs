using School_Project.Entities;
using System.Data.Entity.ModelConfiguration;

namespace School_Project.Context.EntitiesConfig
{
    public class LoginEntityConfiguration : EntityTypeConfiguration<Login>
    {
        public LoginEntityConfiguration()
        {
            ToTable("Login");

            HasKey(l => l.Id);

            Property(l => l.UserName)
                        .IsRequired()
                        .HasMaxLength(40);

            Property(l => l.Password)
                       .IsRequired()
                       .HasMaxLength(100);

            Property(l => l.Type)
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnOrder(1);
        }
    }
}