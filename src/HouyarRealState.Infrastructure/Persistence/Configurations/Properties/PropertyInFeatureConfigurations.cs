using HouyarRealState.Domain.Entities.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Properties
{
    public class PropertyInFeatureConfigurations : IEntityTypeConfiguration<PropertyInFeature>
    {
        public void Configure(EntityTypeBuilder<PropertyInFeature> builder)
        {
            // Table
            builder.ToTable("PropertyInFeatures");

            // Primary Key
            builder.HasKey(pif => pif.Id);

            // Base Properties
            //builder.Property(pif => pif.Id)
            //    .ValueGeneratedNever();

            builder.Property(pif => pif.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);

            // Foreign Keys
            builder.Property(pif => pif.PropertyId)
                .IsRequired();

            builder.Property(pif => pif.PropertyFeatureId)
                .IsRequired();

            // Relationships

            // Property
            builder.HasOne(pif => pif.Property)
                .WithMany(p => p.PropertyInFeatures)
                .HasForeignKey(pif => pif.PropertyId)
                .OnDelete(DeleteBehavior.NoAction);

            // PropertyFeature
            builder.HasOne(pif => pif.PropertyFeature)
                .WithMany(pf => pf.PropertyInFeatures)
                .HasForeignKey(pif => pif.PropertyFeatureId)
                .OnDelete(DeleteBehavior.NoAction);

            // Indexes
            builder.HasIndex(pif => pif.PropertyId);

            builder.HasIndex(pif => pif.PropertyFeatureId);

            // Prevent duplicate feature assignment to a property
            builder.HasIndex(pif => new
            {
                pif.PropertyId,
                pif.PropertyFeatureId
            })
            .IsUnique();

            // Soft Delete Index
            builder.HasIndex(pif => pif.IsDelete);
        }
    }
}