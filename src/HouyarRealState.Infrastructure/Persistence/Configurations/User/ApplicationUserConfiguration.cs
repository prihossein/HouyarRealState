using HouyarRealState.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.User
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {


            // User Properties
            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Mobile)
                .HasMaxLength(20);

            builder.Property(x => x.FullName)
                .HasMaxLength(150);

            builder.Property(x => x.IsConfirmedMobile)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.IsBan)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.OTPCode)
                .HasMaxLength(10);

            builder.Property(x => x.OTPCodeExpireDateTime)
                .IsRequired();

            builder.Property(x => x.LastLogin)
                .IsRequired();

            builder.Property(x => x.RegisterDate)
                .IsRequired();

            builder.Property(x => x.LastOTPSentDate)
                .IsRequired();


            // Indexes
            builder.HasIndex(x => x.Code)
                .IsUnique();


            builder.HasIndex(x => x.Mobile);

            // Relations
            builder.HasMany(x => x.Blogs)
                .WithOne(x => x.Author)
                .HasForeignKey(x => x.AspNetUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Properties)
                .WithOne(x => x.Author)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
