using HouyarRealState.Domain.Entities.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Properties
{
    public class PropertyFeatureConfigurations : IEntityTypeConfiguration<PropertyFeature>
    {
        public void Configure(EntityTypeBuilder<PropertyFeature> builder)
        {
            // Table
            builder.ToTable("PropertyFeatures");

            // Primary Key
            builder.HasKey(pf => pf.Id);

            // Base Properties
            builder.Property(pf => pf.Id)
                .ValueGeneratedNever();

            builder.Property(pf => pf.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);

            // General Information
            builder.Property(pf => pf.Title)
                .IsRequired()
                .HasMaxLength(150);

            // Relationships
            builder.HasMany(pf => pf.PropertyInFeatures)
                .WithOne(pif => pif.PropertyFeature)
                .HasForeignKey(pif => pif.PropertyFeatureId)
                .OnDelete(DeleteBehavior.NoAction);

            // Indexes
            builder.HasIndex(pf => pf.Title);

            builder.HasIndex(pf => pf.IsDelete);
        }
    }
}
