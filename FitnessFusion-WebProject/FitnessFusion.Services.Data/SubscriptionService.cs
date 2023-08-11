namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
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

        public async Task<ICollection<AllSubscriptionModel>> GetAllSubscriptions()
        {
            var subscriptions = await dbContext.Subscriptions
                .Select(s => new AllSubscriptionModel
                {
                    Name = s.Name,
                    Image = s.Image,
                    TypeOfSubscription = s.TypeOfSubscription.ToString(),
                    Price = s.Price
                })
                .ToListAsync();

            return subscriptions;
        }
    }
}
