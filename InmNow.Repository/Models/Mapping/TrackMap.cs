using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class TrackMap : EntityTypeConfiguration<Track>
    {
        public TrackMap()
        {
            // Primary Key
            this.HasKey(t => t.TrackId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Tracks");
            this.Property(t => t.TrackId).HasColumnName("TrackId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.MeetingId).HasColumnName("MeetingId");

            // Relationships
            this.HasRequired(t => t.Meeting)
                .WithMany(t => t.Tracks)
                .HasForeignKey(d => d.MeetingId);

        }
    }
}
