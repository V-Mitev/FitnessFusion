namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models;
    using FitnessFusion.Data.Models.Enums;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Subscription;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class SubscriptionService : ISubscriptionService
    {
        private readonly FitnessFusionDbContext dbContext;

        public SubscriptionService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddSubscription(SubscriptionModel model, string userId)
        {
            var daysInMonth = DateTime.DaysInMonth(DateTime.UtcNow.Year, DateTime.UtcNow.Month);

            var subscription = new Subscription()
            {
                Name = model.Name,
                Image = model.Image,
                Price = model.Price,
                Description = model.Description,
                TypeOfSubscription = (TypeOfSubscription)model.TypeOfSubscription!,
                StartSubscription = DateTime.UtcNow,
                EndSubscription = DateTime.UtcNow.AddDays(daysInMonth)
            };

            var user = await dbContext.ApplicationUsers
                .FindAsync(Guid.Parse(userId));

            if (user == null)
            {
                throw new NullReferenceException("User doesn't exists");
            }

            subscription.Users.Add(user);

            await dbContext.Subscriptions.AddAsync(subscription);

            await dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<SubscriptionModel>> GetAllSubscriptions()
        {
            var subscriptions = await dbContext.Subscriptions
                .Select(s => new SubscriptionModel
                {
                    Name = s.Name,
                    Image = s.Image,
                    TypeOfSubscription = s.TypeOfSubscription,
                    Price = s.Price
                })
                .ToListAsync();

            return subscriptions;
        }
    }
}
