using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class InmUserMap : EntityTypeConfiguration<InmUser>
    {
        public InmUserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.FirstName)
                .HasMaxLength(150);

            this.Property(t => t.LastName)
                .HasMaxLength(150);

            this.Property(t => t.UserName)
                .HasMaxLength(150);

            this.Property(t => t.Password)
                .HasMaxLength(150);

            this.Property(t => t.Email)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("InmUser");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Email).HasColumnName("Email");
        }
    }
}
