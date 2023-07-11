namespace FitnessFusion.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Subscriptions = new List<Subscription>();
        }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        [Required]
        public string ImgUrl { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public string? CurrentCaloriesGoal { get; set; }

        public bool IsTrainer { get; set; }

        public bool IsSubscribeValid { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }
    }
}
