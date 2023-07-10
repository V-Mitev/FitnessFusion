namespace FitnessFusion.Data.Models
{
    using Microsoft.AspNetCore.Identity;

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
