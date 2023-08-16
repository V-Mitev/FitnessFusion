namespace FitnessFusion.Web.ViewModels.User
{
    public class UserViewModel
    {
        public string Id { get; set; } = null!;
        
        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public bool IsTrainer { get; set; }

        public bool IsSubscribed { get; set; }

        public string? StartSubscription { get; set; }

        public string? EndSubscription { get; set; }

        public string? SubscriptionPlan { get; set; }
    }
}
