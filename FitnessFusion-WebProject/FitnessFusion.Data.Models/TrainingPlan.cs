namespace FitnessFusion.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey(nameof(Trainer))]
        public Guid TrainerId { get; set; }

        public Trainer Trainer { get; set; } = null!;

        public ICollection<Exercise> Exercises { get; set; }
    }
}
