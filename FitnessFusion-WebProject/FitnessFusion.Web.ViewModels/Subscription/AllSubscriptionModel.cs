namespace FitnessFusion.Web.ViewModels.Subscription
{
    public class AllSubscriptionModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string TypeOfSubscription { get; set; } = null!;

        public string Image { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
