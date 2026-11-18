
using HouyarRealState.Domain.Entities.Properties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Properties
{
    public class PropertyConfigurations : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            // ==========================================
            // Table
            // ==========================================

            builder.ToTable("Properties");

            // ==========================================
            // Primary Key
            // ==========================================

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedNever();

            // ==========================================
            // Base Properties
            // ==========================================

            builder.Property(p => p.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);

            // ==========================================
            // Foreign Keys
            // ==========================================

            builder.Property(p => p.UserId)
                .IsRequired();

            builder.Property(p => p.PropertyTypeId)
                .IsRequired();

            builder.Property(p => p.TransactionTypeId)
                .IsRequired();

            builder.Property(p => p.PropertyRequestTypeId)
                .IsRequired();

            builder.Property(p => p.PropertyStatusId).IsRequired();

            // ==========================================
            // General Information
            // ==========================================

            builder.Property(p => p.Title)
                .IsRequired(false)
                .HasMaxLength(200);

            builder.Property(p => p.Description)
                .IsRequired(false)
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.RenovationCode)
                .HasMaxLength(50);


            builder.Property(p => p.IsDraft)
                .IsRequired()
                .HasDefaultValue(false);

            // ==========================================
            // Dates
            // ==========================================

            builder.Property(p => p.CreateDate)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(p => p.ModifyDate)
                .IsRequired();

            // ==========================================
            // Prices
            // ==========================================

            builder.Property(p => p.MinPricePerMeter);

            builder.Property(p => p.MaxPricePerMeter);

            builder.Property(p => p.MinTotalPrice);

            builder.Property(p => p.MaxTotalPrice);

            // ==========================================
            // Geographic Information
            // ==========================================

            builder.Property(p => p.Latitude)
                .HasPrecision(9, 6);

            builder.Property(p => p.Longitude)
                .HasPrecision(9, 6);

            // ==========================================
            // Area
            // ==========================================

            builder.Property(p => p.Area)
                .IsRequired(false)
                .HasPrecision(18, 2);

            builder.Property(p => p.BuiltArea)
                .HasPrecision(18, 2);

            // ==========================================
            // Relationships
            // ==========================================


            // Property Status
            builder.HasOne(p => p.PropertyStatus)
                .WithMany(u => u.Properties)
                .HasForeignKey(p => p.PropertyStatusId)
                .OnDelete(DeleteBehavior.NoAction);

            // Creator (ApplicationUser)
            builder.HasOne(p => p.Creator)
                .WithMany(u => u.Properties)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // Property Type
            builder.HasOne(p => p.PropertyType)
                .WithMany(pt => pt.Properties)
                .HasForeignKey(p => p.PropertyTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            // Transaction Type
            builder.HasOne<TransactionType>()
                .WithMany()
                .HasForeignKey(p => p.TransactionTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            // Property Request Type (Offer / Demand)
            builder.HasOne(p => p.PropertyRequestType)
                .WithMany(prt => prt.Properties)
                .HasForeignKey(p => p.PropertyRequestTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            // ==========================================
            // Indexes
            // ==========================================

            builder.HasIndex(p => p.UserId);

            builder.HasIndex(p => p.PropertyTypeId);

            builder.HasIndex(p => p.TransactionTypeId);

            builder.HasIndex(p => p.PropertyRequestTypeId);

            builder.HasIndex(p => p.CreateDate);

            builder.HasIndex(p => p.IsDelete);

            // ==========================================
            // Composite Indexes
            // ==========================================

            // Property Search Index
            builder.HasIndex(p => new
            {
                p.PropertyRequestTypeId,
                p.PropertyTypeId,
                p.TransactionTypeId,
                p.IsDelete
            });

            // User Properties Index
            builder.HasIndex(p => new
            {
                p.UserId,
                p.IsDelete
            });

            // Published Properties Index
            builder.HasIndex(p => new
            {
                p.PropertyStatus,
                p.IsDelete,
                p.CreateDate
            });
        }
    }
}
