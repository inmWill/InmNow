using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class OptionMap : EntityTypeConfiguration<Option>
    {
        public OptionMap()
        {
            // Primary Key
            this.HasKey(t => t.OptionId);

            // Properties
            this.Property(t => t.Question)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Options");
            this.Property(t => t.OptionId).HasColumnName("OptionId");
            this.Property(t => t.Question).HasColumnName("Question");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.QuestionDescription).HasColumnName("QuestionDescription");
            this.Property(t => t.MeetingId).HasColumnName("MeetingId");
            this.Property(t => t.Option_OptionId).HasColumnName("Option_OptionId");

            // Relationships
            this.HasRequired(t => t.Meeting)
                .WithMany(t => t.Options)
                .HasForeignKey(d => d.MeetingId);
            this.HasOptional(t => t.Option1)
                .WithMany(t => t.Options1)
                .HasForeignKey(d => d.Option_OptionId);

        }
    }
}
