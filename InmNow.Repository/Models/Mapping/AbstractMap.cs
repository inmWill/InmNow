using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class AbstractMap : EntityTypeConfiguration<Abstract>
    {
        public AbstractMap()
        {
            // Primary Key
            this.HasKey(t => t.AbstractId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired();

            this.Property(t => t.Results)
                .IsRequired();

            this.Property(t => t.UserId)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Abstracts");
            this.Property(t => t.AbstractId).HasColumnName("AbstractId");
            this.Property(t => t.Lognumber).HasColumnName("Lognumber");
            this.Property(t => t.IsLocked).HasColumnName("IsLocked");
            this.Property(t => t.ActiveUserId).HasColumnName("ActiveUserId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Introduction).HasColumnName("Introduction");
            this.Property(t => t.Methods).HasColumnName("Methods");
            this.Property(t => t.Results).HasColumnName("Results");
            this.Property(t => t.NovelAspect).HasColumnName("NovelAspect");
            this.Property(t => t.PresentationDate).HasColumnName("PresentationDate");
            this.Property(t => t.PublishDate).HasColumnName("PublishDate");
            this.Property(t => t.SubmittedDate).HasColumnName("SubmittedDate");
            this.Property(t => t.PreferredTrackType).HasColumnName("PreferredTrackType");
            this.Property(t => t.AssignedSlot).HasColumnName("AssignedSlot");
            this.Property(t => t.UploadedFile).HasColumnName("UploadedFile");
            this.Property(t => t.UploadedFileStatus).HasColumnName("UploadedFileStatus");
            this.Property(t => t.LastUpdatedUserId).HasColumnName("LastUpdatedUserId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.SessionId).HasColumnName("SessionId");
            this.Property(t => t.Session_SessionId).HasColumnName("Session_SessionId");
            this.Property(t => t.Session_SessionId1).HasColumnName("Session_SessionId1");

            // Relationships
            this.HasOptional(t => t.AspNetUser)
                .WithMany(t => t.Abstracts)
                .HasForeignKey(d => d.UserId);
            this.HasOptional(t => t.Session)
                .WithMany(t => t.Abstracts)
                .HasForeignKey(d => d.Session_SessionId);
            this.HasOptional(t => t.Session1)
                .WithMany(t => t.Abstracts1)
                .HasForeignKey(d => d.Session_SessionId1);

        }
    }
}
