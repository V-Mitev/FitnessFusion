namespace FitnessFusion.Data.Configuration
{
    using FitnessFusion.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using static Common.GeneralApplicationConstants;

    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
               .HasOne(u => u.Subscription)
               .WithMany(u => u.Users)
               .HasForeignKey(s => s.SubscriptionId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(SeedAdministrator());
        }

        private static ApplicationUser SeedAdministrator()
        {
            var administrator = new ApplicationUser()
            {
                Id = Guid.Parse("8b31291b-0f00-49aa-964d-e3242a0fd13e"),
                FirstName = "Admin",
                LastName = "Admin",
                Email = AdminEmail,
                NormalizedEmail = AdminEmail,
                UserName = AdminEmail,
                NormalizedUserName = AdminEmail,
                SecurityStamp = "4086a2a8-4ccc-430e-916b-ceda5be3ab94",
                SubscriptionId = Guid.Parse("ce8bb39f-685a-4c7f-9ccf-55b627121474")
            };

            var hasher = new PasswordHasher<ApplicationUser>();

            administrator.PasswordHash = hasher.HashPassword(administrator, "123456");

            return administrator;
        }
    }
}
