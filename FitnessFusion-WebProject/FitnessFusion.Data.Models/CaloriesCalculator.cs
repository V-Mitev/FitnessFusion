namespace FitnessFusion.Data.Models
{
    using FitnessFusion.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    public class CaloriesCalculator
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        public int Age { get; set; }

        public GenderType Gender { get; set; }

        public ActivityLevelType ActivityLevel { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public GoalType Goal { get; set; }

        public double? CaloriesIntake { get; set; }
    }
}
