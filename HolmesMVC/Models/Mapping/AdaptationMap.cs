using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace HolmesMVC.Models.Mapping
{
    public class AdaptationMap : EntityTypeConfiguration<Adaptation>
    {
        public AdaptationMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.Name)
                .HasMaxLength(1000);

            Property(t => t.Company)
                .HasMaxLength(1000);

            Property(t => t.UrlName)
                .IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute() { IsUnique = true }))
                .HasMaxLength(150);

            Property(t => t.Medium)
                .IsRequired();

            // Table & Column Mappings
            ToTable("Adaptations");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Translation).HasColumnName("Translation");
            Property(t => t.Medium).HasColumnName("Medium");
            Property(t => t.Company).HasColumnName("Company");
			Property(t => t.Imdb).HasColumnName("Imdb");
			Property(t => t.Letterboxd).HasColumnName("Letterboxd");
			Property(t => t.UrlName).HasColumnName("UrlName");

        }
    }
}
