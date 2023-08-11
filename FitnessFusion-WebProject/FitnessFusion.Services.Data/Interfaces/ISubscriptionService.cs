namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.Subscription;

    public interface ISubscriptionService
    {
        Task<ICollection<AllSubscriptionModel>> GetAllSubscriptions();
    }
}
