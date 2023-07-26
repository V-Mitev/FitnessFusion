namespace FitnessFusion.Web.ViewModels.TrainingPlan
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.TrainingPlan;

    public class TrainingPlanViewModel
    {
        public TrainingPlanViewModel()
        {
            AddedExercises = new HashSet<TrainingPlanExercises>();
        }

        public string? Id { get; set; } 

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string Image { get; set; } = null!;

        public ICollection<TrainingPlanExercises> AddedExercises { get; set; }
    }
}
