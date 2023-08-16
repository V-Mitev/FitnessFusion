﻿namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.Subscription;

    public interface ISubscriptionService
    {
        public Task<ICollection<SubscriptionModel>> GetAllSubscriptions();

        public Task AddSubscription(SubscriptionModel model);

        public Task DeleteSubscription(string subscriptionId);

        public Task<SubscriptionModel> GetSubscription(string subscriptionId);

        public Task Edit(SubscriptionModel model, string subscriptionId);

        public Task<bool> IsSubscriptionExistByIdAsync(string id);

        public Task SubscribeAsync(string subscriptionId, string userId);
    }
}
