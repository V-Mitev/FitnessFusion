namespace FitnessFusion.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.EntityValidationConstants.User;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            IsTrainer = false;
            IsSubscribeValid = false;
        }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public string? CurrentCaloriesGoal { get; set; }

        public bool IsTrainer { get; set; }

        public DateTime? StartSubscription { get; set; }

        public DateTime? EndSubscription { get; set; }

        public bool IsSubscribeValid { get; set; }

        [ForeignKey(nameof(Subscription))]
        public Guid? SubscriptionId { get; set; }

        public Subscription? Subscription { get; set; }
    }
}
