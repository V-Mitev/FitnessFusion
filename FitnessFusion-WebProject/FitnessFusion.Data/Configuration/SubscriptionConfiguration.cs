namespace FitnessFusion.Data.Configuration
{
    using FitnessFusion.Data.Models;
    using FitnessFusion.Data.Models.Enums;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder
               .HasMany(s => s.Users)
               .WithOne(s => s.Subscription)
               .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(t => t.Price)
                .HasPrecision(5, 2);

            builder
                .HasData(GenerateSubscription());
        }

        private static Subscription GenerateSubscription()
        {
            var subscription = new Subscription()
            {
                Id = Guid.Parse("ce8bb39f-685a-4c7f-9ccf-55b627121474"),
                Name = "Test Subscription",
                Description = "Test description to subscription",
                Price = 30M,
                TypeOfSubscription = TypeOfSubscription.Standard,
                Image = "RandomImage"
            };

            return subscription;
        }
    }
}
