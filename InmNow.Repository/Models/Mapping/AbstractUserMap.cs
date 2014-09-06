using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class AbstractUserMap : EntityTypeConfiguration<AbstractUser>
    {
        public AbstractUserMap()
        {
            // Primary Key
            this.HasKey(t => t.AbstractUserId);

            // Properties
            this.Property(t => t.User_Id1)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("AbstractUsers");
            this.Property(t => t.AbstractUserId).HasColumnName("AbstractUserId");
            this.Property(t => t.Presenting).HasColumnName("Presenting");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.hasAccount).HasColumnName("hasAccount");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.AbstractId).HasColumnName("AbstractId");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.User_Id1).HasColumnName("User_Id1");

            // Relationships
            this.HasRequired(t => t.Abstract)
                .WithMany(t => t.AbstractUsers)
                .HasForeignKey(d => d.AbstractId);
            this.HasOptional(t => t.AspNetUser)
                .WithMany(t => t.AbstractUsers)
                .HasForeignKey(d => d.User_Id1);

        }
    }
}
