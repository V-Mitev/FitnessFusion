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
    using static Common.GeneralApplicationConstants;

    public class SubscriptionService : ISubscriptionService
    {
        private readonly FitnessFusionDbContext dbContext;

        public SubscriptionService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddSubscriptionAsync(SubscriptionModel model)
        {
            var subscription = new Subscription()
            {
                Name = model.Name,
                Image = model.Image,
                Price = model.Price,
                Description = model.Description,
                TypeOfSubscription = (TypeOfSubscription)model.TypeOfSubscription!
            };

            await dbContext.Subscriptions.AddAsync(subscription);

            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteSubscriptionAsync(string subscriptionId)
        {
            var subscription = await dbContext.Subscriptions
                .Include(s => s.Users)
                .FirstOrDefaultAsync( s => s.Id.ToString() == subscriptionId);

            if (subscription == null)
            {
                throw new NullReferenceException("Subscription doesn't exists");
            }

            dbContext.Subscriptions.Remove(subscription);

            var users = await dbContext.Users
                .Where(u => u.SubscriptionId.ToString() == subscriptionId)
                .ToListAsync();

            foreach (var user in users)
            {
                user.IsSubscribeValid = false;
                user.StartSubscription = null;
                user.EndSubscription = null;
            }

            await dbContext.SaveChangesAsync();
        }

        public async Task EditAsync(SubscriptionModel model, string subscriptionId)
        {
            var subscription = await dbContext.Subscriptions
                .FindAsync(Guid.Parse(subscriptionId));

            if (subscription == null)
            {
                throw new NullReferenceException("Subscription doesn't exists");
            }

            subscription.Id = Guid.Parse(model.Id!);
            subscription.Name = model.Name;
            subscription.Description = model.Description;
            subscription.Price = model.Price;
            subscription.Image = model.Image;
            subscription.TypeOfSubscription = (TypeOfSubscription)model.TypeOfSubscription!;

            await dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<SubscriptionModel>> GetAllSubscriptionsAsync()
        {
            var subscriptions = await dbContext.Subscriptions
                .Select(s => new SubscriptionModel
                {
                    Id = s.Id.ToString(),
                    Name = s.Name,
                    Description = s.Description,
                    Image = s.Image,
                    TypeOfSubscription = s.TypeOfSubscription,
                    Price = s.Price
                })
                .ToListAsync();

            return subscriptions;
        }

        public async Task<SubscriptionModel> GetSubscriptionAsync(string subscriptionId)
        {
            var subscription = await dbContext.Subscriptions
                .FindAsync(Guid.Parse(subscriptionId));

            if (subscription == null)
            {
                throw new NullReferenceException("Subscription doesn't exists");
            }

            var subscriptionModel = new SubscriptionModel()
            {
                Id = subscriptionId,
                Name = subscription.Name,
                Price = subscription.Price,
                Description = subscription.Description,
                Image = subscription.Image,
                TypeOfSubscription = subscription.TypeOfSubscription
            };

            return subscriptionModel;
        }

        public async Task<bool> IsSubscribeValidAsync(string userId)
        {
            var user = await dbContext.ApplicationUsers
              .FindAsync(Guid.Parse(userId));

            if (user == null)
            {
                throw new NullReferenceException("Unexpected error user doesn't exist!");
            }

            if (user.SubscriptionId == null)
            {
                user.StartSubscription = null;
                user.EndSubscription = null;

                return user.IsSubscribeValid = false;
            }

            if (user.StartSubscription!.Value.Day == user.EndSubscription!.Value.Day &&
                user.StartSubscription.Value.Month < user.EndSubscription.Value.Month ||
                user.StartSubscription.Value.Month == user.EndSubscription.Value.Month)
            {
                 return user.IsSubscribeValid = false;
            }
            else
            {
                return user.IsSubscribeValid = true;
            }
        }

        public async Task<bool> IsSubscriptionExistByIdAsync(string id)
        {
            var resutl = await dbContext.Subscriptions
                .AnyAsync(s => s.Id.ToString() == id);

            return resutl;
        }

        public async Task SubscribeAsync(string subscriptionId, string userId)
        {
            var subscriptionPlan = await dbContext.Subscriptions
                .FindAsync(Guid.Parse(subscriptionId));

            if (subscriptionPlan == null)
            {
                throw new NullReferenceException("Unexpected error subscription plan doesn't exist!");
            }

            var user = await dbContext.ApplicationUsers
               .FindAsync(Guid.Parse(userId));

            if (user == null)
            {
                throw new NullReferenceException("Unexpected error user doesn't exist!");
            }

            var startSubscription = DateTime.UtcNow.ToString("D");

            var endSuscription = DateTime.UtcNow.AddDays(SubscriptionPeriodForAllPlans).ToString("D");

            user.StartSubscription = DateTime.Parse(startSubscription);
            user.EndSubscription = DateTime.Parse(endSuscription);
            
            user.IsSubscribeValid = true;

            user.SubscriptionId = Guid.Parse(subscriptionId);

            await dbContext.SaveChangesAsync(); 
        }
    }
}
