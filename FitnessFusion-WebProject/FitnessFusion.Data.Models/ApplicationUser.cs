namespace FitnessFusion.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.EntityValidationConstants.ApplicationUser;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            TrainingPlans = new List<TrainingPlan>();
            MealPlans = new List<MealPlan>();
        }

        public string? Calories { get; set; }

        public ICollection<TrainingPlan> TrainingPlans { get; set; }

        public ICollection<MealPlan> MealPlans { get; set; }
    }
}
