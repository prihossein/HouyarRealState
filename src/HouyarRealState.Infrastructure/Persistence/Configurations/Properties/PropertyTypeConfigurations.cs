using HouyarRealState.Domain.Entities.Properties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Properties
{
    public class PropertyTypeConfigurations : IEntityTypeConfiguration<PropertyType>
    {
        public void Configure(EntityTypeBuilder<PropertyType> builder)
        {
            // Table
            builder.ToTable("PropertyTypes");

            // Primary Key
            builder.HasKey(pt => pt.Id);

            // Base Properties
            //builder.Property(pt => pt.Id)
            //    .ValueGeneratedNever();

            builder.Property(pt => pt.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);

            // General Information
            builder.Property(pt => pt.Title)
                .IsRequired()
                .HasMaxLength(100);

            // Dates
            builder.Property(pt => pt.CreateDate)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(pt => pt.ModifyDate)
                .IsRequired();

            // Relationships
            builder.HasMany(pt => pt.Properties)
                .WithOne(p => p.PropertyType)
                .HasForeignKey(p => p.PropertyTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            // Indexes
            builder.HasIndex(pt => pt.Title);

            builder.HasIndex(pt => pt.IsDelete);

            // Composite Index
            builder.HasIndex(pt => new
            {
                pt.IsDelete,
                pt.Title
            });
        }
    }
}