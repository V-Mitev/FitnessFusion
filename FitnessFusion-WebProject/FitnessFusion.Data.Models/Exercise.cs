namespace FitnessFusion.Data.Models
{
    using FitnessFusion.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Exercise;

    public class Exercise
    {
        public Exercise()
        {
            Id = Guid.NewGuid();
            TrainingPlans =  new List<TrainingPlan>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(VideoUrlMaxLength)]
        public string VideoLink { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImagePath { get; set; } = null!;

        public ExerciseLevelOfDificulty Difficulty { get; set; }

        public MuscleGroups MuscleGroup { get; set; }

        public bool IsInPlan { get; set; }

        public ICollection<TrainingPlan> TrainingPlans { get; set; }
    }
}
