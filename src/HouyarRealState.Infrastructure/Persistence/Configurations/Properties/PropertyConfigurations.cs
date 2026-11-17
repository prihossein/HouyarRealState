
using HouyarRealState.Domain.Entities.Properties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Properties
{
    public class PropertyConfigurations : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            // Table
            builder.ToTable("Properties");

            // Primary Key
            builder.HasKey(p => p.Id);

            // Base Properties
            builder.Property(p => p.Id)
                .ValueGeneratedNever();

            builder.Property(p => p.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);

            // Foreign Keys
            builder.Property(p => p.UserId)
                .IsRequired();

            builder.Property(p => p.PropertyTypeId)
                .IsRequired();

            builder.Property(p => p.TransactionTypeId)
                .IsRequired();

            // General Information
            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Description)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.RenovationCode)
                .HasMaxLength(50);

            builder.Property(p => p.Status)
                .IsRequired()
                .HasMaxLength(30)
                .HasDefaultValue("Draft");

            builder.Property(p => p.IsApproved)
                .IsRequired()
                .HasDefaultValue(false);

            // Dates
            builder.Property(p => p.CreateDate)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(p => p.ModifyDate)
                .IsRequired();

            // Prices
            builder.Property(p => p.MinPricePerMeter);

            builder.Property(p => p.MaxPricePerMeter);

            builder.Property(p => p.MinTotalPrice);

            builder.Property(p => p.MaxTotalPrice);
            builder.Property(p => p.Latitude)
    .HasPrecision(9, 6);

            builder.Property(p => p.Longitude)
                .HasPrecision(9, 6);
            // Area
            builder.Property(p => p.Area)
                .IsRequired()
                .HasPrecision(18, 2);

            builder.Property(p => p.BuiltArea)
                .HasPrecision(18, 2);

            // Relationships

            // User
            builder.HasOne(p => p.Creator)
                .WithMany(u => u.Properties)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // Property Type
            builder.HasOne(p => p.PropertyType)
                .WithMany()
                .HasForeignKey(p => p.PropertyTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            // Indexes
            builder.HasIndex(p => p.UserId);

            builder.HasIndex(p => p.PropertyTypeId);

            builder.HasIndex(p => p.TransactionTypeId);

            builder.HasIndex(p => p.Status);

            builder.HasIndex(p => p.IsApproved);

            builder.HasIndex(p => p.CreateDate);

            builder.HasIndex(p => p.IsDelete);

            // Composite Indexes
            builder.HasIndex(p => new
            {
                p.PropertyTypeId,
                p.TransactionTypeId,
                p.IsApproved,
                p.IsDelete
            });

            builder.HasIndex(p => new
            {
                p.UserId,
                p.IsDelete
            });
        }
    }
}
