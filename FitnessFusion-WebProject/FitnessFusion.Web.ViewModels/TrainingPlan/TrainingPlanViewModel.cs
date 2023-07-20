namespace FitnessFusion.Web.ViewModels.TrainingPlan
{
    using FitnessFusion.Web.ViewModels.Exercise;
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.TrainingPlan;

    public class TrainingPlanViewModel
    {
        public TrainingPlanViewModel()
        {
            AvailableExercises = new List<ExerciseViewModel>();
            AddedExercises = new List<ExerciseViewModel>();
        }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string DescriptionOfExercises { get; set; } = null!;

        public ICollection<ExerciseViewModel> AvailableExercises { get; set; }

        public ICollection<ExerciseViewModel> AddedExercises { get; set; }

        public string AvailableExerciseId { get; set; } = null!;
    }
}
