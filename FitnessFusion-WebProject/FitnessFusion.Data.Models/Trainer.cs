namespace FitnessFusion.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Trainer
    {
        public Trainer()
        {
            Id = Guid.NewGuid();
            MealPlans = new List<MealPlan>();
            TrainingPlans = new List<TrainingPlan>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string ImgUrl { get; set; } = null!;

        [Required]
        public int YearsExpririence { get; set; }

        [Required]
        public string Description { get; set; } = null!;

        public ICollection<MealPlan> MealPlans { get; set; }

        public ICollection<TrainingPlan> TrainingPlans { get; set; }
    }
}
