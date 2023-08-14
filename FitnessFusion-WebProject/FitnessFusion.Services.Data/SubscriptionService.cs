﻿namespace FitnessFusion.Services.Data
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
            var subscription = new Subscription()
            {
                Name = model.Name,
                Image = model.Image,
                Price = model.Price,
                Description = model.Description,
                TypeOfSubscription = (TypeOfSubscription)model.TypeOfSubscription!
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

        public async Task DeleteSubscription(string subscriptionId)
        {
            var subscription = await dbContext.Subscriptions
                .FindAsync(Guid.Parse(subscriptionId));

            if (subscription == null)
            {
                throw new NullReferenceException("Subscription doesn't exists");
            }

            dbContext.Subscriptions.Remove(subscription);

            await dbContext.SaveChangesAsync();
        }

        public async Task Edit(SubscriptionModel model, string subscriptionId)
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

        public async Task<ICollection<SubscriptionModel>> GetAllSubscriptions()
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

        public async Task<SubscriptionModel> GetSubscription(string subscriptionId)
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

        public async Task<bool> IsSubscriptionExistByIdAsync(string id)
        {
            var resutl = await dbContext.Subscriptions
                .AnyAsync(s => s.Id.ToString() == id);

            return resutl;
        }
    }
}
