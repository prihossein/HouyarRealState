using System;
using System.Collections.Generic;
using System.Text;
using HouyarRealState.Domain.Entities.Pages;
using HouyarRealState.Domain.Entities.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Properies
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            // Table
            builder.ToTable("Properties");

            // Primary Key
            builder.HasKey(p => p.Id);

            // Required Properties
            builder.Property(p => p.UserId)
                .IsRequired();

            builder.Property(p => p.LanguageId)
                .IsRequired();

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Description)
                .IsRequired();

            builder.Property(p => p.PropertyCode)
                .HasMaxLength(50);

            builder.Property(p => p.Status)
                .IsRequired()
                .HasMaxLength(30)
                .HasDefaultValue("Draft");

            builder.Property(p => p.Currency)
                .IsRequired()
                .HasMaxLength(3)
                .HasDefaultValue("IRR");

            // Address
            builder.Property(p => p.Province)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.City)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.District)
                .HasMaxLength(100);

            builder.Property(p => p.Neighborhood)
                .HasMaxLength(150);

            builder.Property(p => p.Street)
                .HasMaxLength(200);

            builder.Property(p => p.SideStreet)
                .HasMaxLength(200);

            builder.Property(p => p.Alley)
                .HasMaxLength(200);

            builder.Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(p => p.PostalCode)
                .HasMaxLength(20);

            // Property Information
            builder.Property(p => p.Direction)
                .HasMaxLength(30);

            builder.Property(p => p.WindowDirection)
                .HasMaxLength(30);

            builder.Property(p => p.HeatingSystem)
                .HasMaxLength(100);

            builder.Property(p => p.CoolingSystem)
                .HasMaxLength(100);

            builder.Property(p => p.HotWaterSystem)
                .HasMaxLength(100);

            builder.Property(p => p.FlooringType)
                .HasMaxLength(100);

            builder.Property(p => p.WallCovering)
                .HasMaxLength(100);

            builder.Property(p => p.CeilingType)
                .HasMaxLength(100);

            builder.Property(p => p.FacadeType)
                .HasMaxLength(100);

            builder.Property(p => p.CabinetType)
                .HasMaxLength(100);

            builder.Property(p => p.CountertopType)
                .HasMaxLength(100);

            builder.Property(p => p.WindowType)
                .HasMaxLength(100);

            builder.Property(p => p.WindowFrameMaterial)
                .HasMaxLength(100);

            builder.Property(p => p.InteriorDoorType)
                .HasMaxLength(100);

            builder.Property(p => p.DeedType)
                .HasMaxLength(100);

            builder.Property(p => p.LandUseType)
                .HasMaxLength(100);

            builder.Property(p => p.StructureType)
                .HasMaxLength(100);

            builder.Property(p => p.ConstructionMaterial)
                .HasMaxLength(150);

            builder.Property(p => p.OccupancyStatus)
                .HasMaxLength(50);

            builder.Property(p => p.CommercialActivityType)
                .HasMaxLength(150);

            builder.Property(p => p.BuilderName)
                .HasMaxLength(200);

            builder.Property(p => p.ProjectName)
                .HasMaxLength(200);

            builder.Property(p => p.OwnerName)
                .HasMaxLength(200);

            // Descriptions
            builder.Property(p => p.ShortDescription)
                .HasMaxLength(500);

            builder.Property(p => p.PaymentTerms)
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.LocationDescription)
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.InteriorDescription)
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.AppliancesDescription)
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.LegalDescription)
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.LandDescription)
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.StructureDescription)
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.OccupancyDescription)
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.CommercialDescription)
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.NeighborhoodDescription)
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.ViewDescription)
                .HasColumnType("nvarchar(max)");

            builder.Property(p => p.VisitDescription)
                .HasMaxLength(1000);

            builder.Property(p => p.InternalNotes)
                .HasColumnType("nvarchar(max)");

            // Decimal Precision
            foreach (var property in builder.Metadata.GetProperties()
                         .Where(p => (Nullable.GetUnderlyingType(p.ClrType)
                                      ?? p.ClrType) == typeof(decimal)))
            {
                builder.Property(property.Name)
                    .HasPrecision(18, 2);
            }

            // Geographic Coordinates
            builder.Property(p => p.Latitude)
                .HasPrecision(9, 6);

            builder.Property(p => p.Longitude)
                .HasPrecision(9, 6);

            // Date Properties
            builder.Property(p => p.CreatedAt)
                .IsRequired();

            builder.Property(p => p.PublishedAt);

            builder.Property(p => p.ExpiresAt);

            builder.Property(p => p.UpdatedAt);

            // Default Values
            builder.Property(p => p.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(p => p.ViewCount)
                .HasDefaultValue(0);

            builder.Property(p => p.AllowsInPersonVisit)
                .HasDefaultValue(true);

            builder.Property(p => p.IsPriceNegotiable)
                .HasDefaultValue(false);

            builder.Property(p => p.IsApproved)
                .HasDefaultValue(false);

            builder.Property(p => p.IsFeatured)
                .HasDefaultValue(false);

            builder.Property(p => p.IsHighlighted)
                .HasDefaultValue(false);

            // Relationships
            builder.HasOne(p => p.Author)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Language)
                .WithMany()
                .HasForeignKey(p => p.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);

            // Indexes
            builder.HasIndex(p => p.UserId);

            builder.HasIndex(p => p.LanguageId);

            builder.HasIndex(p => p.PropertyTypeId);

            builder.HasIndex(p => p.TransactionTypeId);

            builder.HasIndex(p => p.Status);

            builder.HasIndex(p => p.IsApproved);

            builder.HasIndex(p => p.IsFeatured);

            builder.HasIndex(p => p.PublishedAt);

            builder.HasIndex(p => p.ExpiresAt);

            builder.HasIndex(p => p.PropertyCode)
                .IsUnique()
                .HasFilter("[PropertyCode] IS NOT NULL");

            builder.HasIndex(p => new
            {
                p.City,
                p.PropertyTypeId,
                p.TransactionTypeId
            });

            builder.HasIndex(p => new
            {
                p.IsApproved,
                p.Status,
                p.PublishedAt
            });
        }
    }
}
