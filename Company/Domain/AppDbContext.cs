using Company.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Company.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole 
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelbuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName= "admin",
                NormalizedUserName = "ADMIN",
                Email = "krit@email.com",
                NormalizedEmail = "KRIT@email.COM",
                EmailConfirmed= true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> 
            {
               RoleId = "8af10569-b018-4fe7-a380-7d6a14c70b7a",
               UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"),
                CodeWord = "PageIndex",
                Title = "Main",
            });

            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("936DA01F-9ABD-4d9d-80C7-02AF85C822A8"),
                CodeWord = "PageServices",
                Title = "Our services",
            });

            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                CodeWord = "PageContacts",
                Title = "Contacts"
            });

        }
    }
}
