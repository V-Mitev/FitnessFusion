namespace FitnessFusion.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Subscriptions = new List<Subscription>();
            IsTrainer = false;
            IsSubscribeValid = false;
        }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? ImgUrl { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? CurrentCaloriesGoal { get; set; }

        public bool IsTrainer { get; set; }

        public bool IsSubscribeValid { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }
    }
}
