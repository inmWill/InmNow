using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class InmAbstractAuthorMap : EntityTypeConfiguration<InmAbstractAuthor>
    {
        public InmAbstractAuthorMap()
        {
            // Primary Key
            this.HasKey(t => t.InmAbstractAuthorId);

            // Properties
            this.Property(t => t.UserId)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("InmAbstractAuthor");
            this.Property(t => t.InmAbstractAuthorId).HasColumnName("InmAbstractAuthorId");
            this.Property(t => t.Presenting).HasColumnName("Presenting");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.hasAccount).HasColumnName("hasAccount");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.InmAbstractId).HasColumnName("InmAbstractId");
            this.Property(t => t.UserId).HasColumnName("UserId");
        }
    }
}
