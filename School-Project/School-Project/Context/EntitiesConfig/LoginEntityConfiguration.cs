using School_Project.Entities;
using System.Data.Entity.ModelConfiguration;

namespace School_Project.Context.EntitiesConfig
{
    public class LoginEntityConfiguration : EntityTypeConfiguration<Login>
    {
        public LoginEntityConfiguration()
        {
            ToTable("Login");

            HasKey(s => s.Id);

            Property(p => p.UserName)
                        .IsRequired()
                        .HasMaxLength(40);

            Property(p => p.Password)
                       .IsRequired()
                       .HasMaxLength(40);

            Property(p => p.Type)
                        .IsRequired()
                        .HasColumnOrder(1);
        }
    }
}