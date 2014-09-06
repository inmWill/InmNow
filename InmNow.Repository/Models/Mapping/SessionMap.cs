using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class SessionMap : EntityTypeConfiguration<Session>
    {
        public SessionMap()
        {
            // Primary Key
            this.HasKey(t => t.SessionId);

            // Properties
            this.Property(t => t.Code)
                .IsRequired();

            this.Property(t => t.SessionTitle)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Sessions");
            this.Property(t => t.SessionId).HasColumnName("SessionId");
            this.Property(t => t.Phase).HasColumnName("Phase");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.SessionTitle).HasColumnName("SessionTitle");
            this.Property(t => t.Contact).HasColumnName("Contact");
            this.Property(t => t.ContactEmail).HasColumnName("ContactEmail");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.TrackId).HasColumnName("TrackId");
            this.Property(t => t.Abstract_AbstractId).HasColumnName("Abstract_AbstractId");

            // Relationships
            this.HasOptional(t => t.Abstract)
                .WithMany(t => t.Sessions)
                .HasForeignKey(d => d.Abstract_AbstractId);
            this.HasRequired(t => t.Track)
                .WithMany(t => t.Sessions)
                .HasForeignKey(d => d.TrackId);

        }
    }
}
