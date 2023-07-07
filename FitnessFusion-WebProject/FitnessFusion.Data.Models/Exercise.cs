namespace FitnessFusion.Data.Models
{
    using FitnessFusion.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Exercise;

    public class Exercise
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(VideoUrlMaxLength)]
        public string VideoLink { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public ExerciseLevelOfDificulty Difficulty { get; set; }

        public MuscleGroups MuscleGroup { get; set; }
    }
}
