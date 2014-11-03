using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class AffiliationMap : EntityTypeConfiguration<Affiliation>
    {
        public AffiliationMap()
        {
            // Primary Key
            this.HasKey(t => t.AffiliationId);

            // Table & Column Mappings
            this.ToTable("Affiliation");
            this.Property(t => t.AffiliationId).HasColumnName("AffiliationId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Street).HasColumnName("Street");
            this.Property(t => t.Street).HasColumnName("Unit");
            this.Property(t => t.Street).HasColumnName("Region");
            this.Property(t => t.Street).HasColumnName("Postal");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Website).HasColumnName("Website");
        }
    }
}
