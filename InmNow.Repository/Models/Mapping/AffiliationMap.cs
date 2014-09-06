using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InmNow.Repository.Models.Mapping
{
    public class AffiliationMap : EntityTypeConfiguration<Affiliation>
    {
        public AffiliationMap()
        {
            // Primary Key
            this.HasKey(t => t.AffiliationId);

            // Properties
            this.Property(t => t.User_Id)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Affiliations");
            this.Property(t => t.AffiliationId).HasColumnName("AffiliationId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.User_Id).HasColumnName("User_Id");

            // Relationships
            this.HasOptional(t => t.AspNetUser)
                .WithMany(t => t.Affiliations)
                .HasForeignKey(d => d.User_Id);

        }
    }
}
