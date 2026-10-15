using System;
using System.Collections.Generic;
using System.Text;
using HouyarRealState.Domain.Entities.User;
using HouyarRealState.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace HouyarRealState.Infrastructure.Persistence
{
    public static class DbInitilizer
    {
        public static async Task Seed(this ApplicationDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();

            if (dbContext.Roles.Any())
            {
                return;
            }

            using var transaction = dbContext.Database.BeginTransaction();

            var ownerRole = new IdentityRole<Guid>
            {
                Name = UserRoleNames.Owner,
                NormalizedName = UserRoleNames.Owner.ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };

            var admininstratorRole = new IdentityRole<Guid>
            {
                Name = UserRoleNames.Administrator,
                NormalizedName = UserRoleNames.Administrator.ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };

            var userRole = new IdentityRole<Guid>
            {
                Name = UserRoleNames.User,
                NormalizedName = UserRoleNames.User.ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };

            dbContext.Roles.AddRange(ownerRole, admininstratorRole, userRole);
            dbContext.SaveChanges();

            ApplicationUser ownerUser = new ApplicationUser
            {
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = "prihossein",
                NormalizedUserName = "prihossein".ToUpper(),
                Code = "420",
                FullName = "Hossein Bazrafkan",
                Email = "prihossein@gmail.com",
                NormalizedEmail = "prihossein@gmail.com".ToUpper(),
                PhoneNumber = "09372632804",
                Mobile = "09372632804",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            ApplicationUser adminUser = new ApplicationUser
            {
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = "admin",
                NormalizedUserName = "admin".ToUpper(),
                FullName = "Hossein Bazrafkan",
                Code = "520",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com".ToUpper(),
                PhoneNumber = "09387030183",
                Mobile = "09387030183",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            ApplicationUser user = new ApplicationUser
            {
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = "user",
                NormalizedUserName = "user".ToUpper(),
                FullName = "Hossein Bazrafkan",
                Code = "620",
                Email = "user@gmail.com",
                NormalizedEmail = "user@gmail.com".ToUpper(),
                PhoneNumber = "09171110000",
                Mobile = "09171110000",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,

            };

            PasswordHasher<ApplicationUser> passwordHasher = new();
            ownerUser.PasswordHash = passwordHasher.HashPassword(ownerUser, "Owner@123456");
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Admin@123456");
            user.PasswordHash = passwordHasher.HashPassword(user, "User@123456");
            dbContext.AddRange(ownerUser, adminUser, user);
            dbContext.SaveChanges();

            await dbContext.UserRoles.AddAsync(new IdentityUserRole<Guid>
            {
                UserId = ownerUser.Id,
                RoleId = ownerRole.Id
            });

            await dbContext.UserRoles.AddAsync(new IdentityUserRole<Guid>
            {
                UserId = adminUser.Id,
                RoleId = admininstratorRole.Id
            });

            await dbContext.UserRoles.AddAsync(new IdentityUserRole<Guid>
            {
                UserId = user.Id,
                RoleId = userRole.Id
            });

            dbContext.SaveChanges();
            transaction.Commit();
        }
    }
}
