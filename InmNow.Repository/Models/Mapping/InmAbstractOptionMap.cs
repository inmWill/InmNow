using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class InmAbstractOptionMap : EntityTypeConfiguration<InmAbstractOption>
    {
        public InmAbstractOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.InmAbstractOptionId);

            // Properties
            // Table & Column Mappings
            this.ToTable("InmAbstractOption");
            this.Property(t => t.InmAbstractOptionId).HasColumnName("InmAbstractOptionId");
            this.Property(t => t.TextAnswer).HasColumnName("TextAnswer");
            this.Property(t => t.BoolAnswer).HasColumnName("BoolAnswer");
            this.Property(t => t.MultiAnswerId).HasColumnName("MultiAnswerId");
            this.Property(t => t.InmAbstractId).HasColumnName("InmAbstractId");
            this.Property(t => t.OptionId).HasColumnName("OptionId");
        }
    }
}
