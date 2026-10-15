using System.Reflection;
using HouyarRealState.Domain;
using HouyarRealState.Domain.Entities.Article;
using HouyarRealState.Domain.Entities.Marketing;
using HouyarRealState.Domain.Entities.Pages;
using HouyarRealState.Domain.Entities.Properties;
using HouyarRealState.Domain.Entities.Settings;
using HouyarRealState.Domain.Entities.Settings.Footer;
using HouyarRealState.Domain.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouyarRealState.Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<BlogFAQ> BlogFAQs { get; set; }
        public DbSet<BlogInCategory> BlogInCategories { get; set; }
        public DbSet<BlogInTag> BlogInTags { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<NewsletterSubscriber> NewsletterSubscribers { get; set; }
        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<FooterMenu> FooterMenus { get; set; }
        public DbSet<FooterMenuItem> FooterMenuItems { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<TopBar> TopBars { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyCategory> PropertyCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.HasDefaultSchema(DomainSchema.Schema);
            base.OnModelCreating(modelBuilder);
        }
    }
}
