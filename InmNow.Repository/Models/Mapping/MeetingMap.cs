using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class MeetingMap : EntityTypeConfiguration<Meeting>
    {
        public MeetingMap()
        {
            // Primary Key
            this.HasKey(t => t.MeetingId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired();

            this.Property(t => t.UserId)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Meeting");
            this.Property(t => t.MeetingId).HasColumnName("MeetingId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Contact).HasColumnName("Contact");
            this.Property(t => t.OfficeEmail).HasColumnName("OfficeEmail");
            this.Property(t => t.SupportEmail).HasColumnName("SupportEmail");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.UserId).HasColumnName("UserId");
        }
    }
}
