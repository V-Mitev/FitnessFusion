namespace FitnessFusion.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.EntityValidationConstants.TrainingPlan;

    public class TrainingPlan
    {
        public TrainingPlan()
        {
            Id = Guid.NewGuid();
            Exercises = new List<Exercise>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public Guid ClientId { get; set; }

        public ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Trainer))]
        public Guid TrainerId { get; set; }

        public Trainer Trainer { get; set; } = null!;

        public ICollection<Exercise> Exercises { get; set; }

        [Range(TrainingDayMinValue, TrainingDayMaxValue)]
        public int TrainingDays { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsValid { get; set; }
    }
}
