using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class AbstractOptionMap : EntityTypeConfiguration<AbstractOption>
    {
        public AbstractOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.AbstractOptionId);

            // Properties
            // Table & Column Mappings
            this.ToTable("AbstractOptions");
            this.Property(t => t.AbstractOptionId).HasColumnName("AbstractOptionId");
            this.Property(t => t.Answer).HasColumnName("Answer");
            this.Property(t => t.AbstractId).HasColumnName("AbstractId");
            this.Property(t => t.OptionId).HasColumnName("OptionId");

            // Relationships
            this.HasRequired(t => t.Abstract)
                .WithMany(t => t.AbstractOptions)
                .HasForeignKey(d => d.AbstractId);
            this.HasRequired(t => t.Option)
                .WithMany(t => t.AbstractOptions)
                .HasForeignKey(d => d.OptionId);

        }
    }
}
