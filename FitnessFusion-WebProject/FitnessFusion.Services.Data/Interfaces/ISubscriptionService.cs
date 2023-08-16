namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.Subscription;

    public interface ISubscriptionService
    {
        public Task<ICollection<SubscriptionModel>> GetAllSubscriptionsAsync();

        public Task AddSubscriptionAsync(SubscriptionModel model);

        public Task DeleteSubscriptionAsync(string subscriptionId);

        public Task<SubscriptionModel> GetSubscriptionAsync(string subscriptionId);

        public Task EditAsync(SubscriptionModel model, string subscriptionId);

        public Task<bool> IsSubscriptionExistByIdAsync(string id);

        public Task SubscribeAsync(string subscriptionId, string userId);

        public Task<bool> IsSubscribeValidAsync(string userId);
    }
}
