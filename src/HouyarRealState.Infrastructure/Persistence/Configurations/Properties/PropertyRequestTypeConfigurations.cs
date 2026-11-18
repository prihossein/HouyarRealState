using HouyarRealState.Domain.Entities.Properties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Properties
{
    public class PropertyRequestTypeConfigurations : IEntityTypeConfiguration<PropertyRequestType>
    {
        public void Configure(EntityTypeBuilder<PropertyRequestType> builder)
        {
            builder.ToTable("PropertyRequestTypes");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(x => x.Code)
                .IsUnique();

            builder.HasMany(x => x.Properties)
                .WithOne(x => x.PropertyRequestType)
                .HasForeignKey(x => x.PropertyRequestTypeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
