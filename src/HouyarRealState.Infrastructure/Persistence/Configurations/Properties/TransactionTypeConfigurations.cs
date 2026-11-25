using HouyarRealState.Domain.Entities.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Properties
{
    public class TransactionTypeConfigurations : IEntityTypeConfiguration<TransactionType>
    {
        public void Configure(EntityTypeBuilder<TransactionType> builder)
        {
            // Table
            builder.ToTable("TransactionTypes");

            // Primary Key
            builder.HasKey(tt => tt.Id);

            // Base Properties
            //builder.Property(tt => tt.Id)
            //    .ValueGeneratedNever();

            builder.Property(tt => tt.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);

            // General Information
            builder.Property(tt => tt.Title)
                .IsRequired()
                .HasMaxLength(100);

            // Indexes
            builder.HasIndex(tt => tt.Title);

            builder.HasIndex(tt => tt.IsDelete);

            // Composite Index
            builder.HasIndex(tt => new
            {
                tt.IsDelete,
                tt.Title
            });
        }
    }
}