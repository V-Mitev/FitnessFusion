namespace FitnessFusion.Web.ViewModels.Exercise
{
    using FitnessFusion.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Exercise;

    public class AddExerciseModel
    {
        public string? Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(ImageUrlMaxLength, MinimumLength = ImageUrlMinLength)]
        public string Image { get; set; } = null!;

        [Required]
        [StringLength(VideoUrlMaxLength, MinimumLength = VideoUrlMinLength)]
        public string VideoLink { get; set; } = null!;

        [Required]
        public MuscleGroups? MuscleGroup { get; set; }

        [Required]
        public ExerciseLevelOfDificulty? Dificulty { get; set; }
    }
}
