namespace FitnessFusion.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Trainer : ApplicationUser
    {
        public Trainer()
        {
            TrainingPlans = new List<TrainingPlan>();
        }

        [Required]
        public string Description { get; set; } = null!;

        public ICollection<TrainingPlan> TrainingPlans { get; set; }
    }
}
