using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class InmAbstractMap : EntityTypeConfiguration<InmAbstract>
    {
        public InmAbstractMap()
        {
            // Primary Key
            this.HasKey(t => t.InmAbstractId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired();

            this.Property(t => t.Results)
                .IsRequired();

            this.Property(t => t.UserId)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("InmAbstract");
            this.Property(t => t.InmAbstractId).HasColumnName("InmAbstractId");
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
        }
    }
}
