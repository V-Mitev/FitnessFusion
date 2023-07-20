namespace FitnessFusion.Data.Configuration
{
    using FitnessFusion.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TrainerConfiguration : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.HasData(GenerateTraines());
        }

        private ICollection<Trainer> GenerateTraines()
        {
            var users = new List<Trainer>();

            Trainer user;

            user = new Trainer()
            {
                Id = Guid.NewGuid(),
                UserName = "trainer@abv.bg",
                FirstName = "Test",
                LastName = "Trainer",
                IsTrainer = true,
                IsSubscribeValid = true,
                Email = "trainer@abv.bg",
                EmailConfirmed = true,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus.",
                SecurityStamp = Guid.NewGuid().ToString(),
                LockoutEnabled = true,
                NormalizedUserName = "TRAINER@ABV.BG",
                NormalizedEmail= "TRAINER@ABV.BG"
            };

            PasswordHasher<Trainer> ph = new PasswordHasher<Trainer>();

            user.PasswordHash = ph.HashPassword(user, "123456");

            users.Add(user);

            return users;
        }
    }
}
