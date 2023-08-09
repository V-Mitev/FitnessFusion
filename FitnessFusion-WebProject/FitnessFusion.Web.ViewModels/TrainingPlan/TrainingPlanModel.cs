namespace FitnessFusion.Web.ViewModels.TrainingPlan
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.TrainingPlan;

    public class TrainingPlanModel
    {
        public TrainingPlanModel()
        {
            AddedExercises = new HashSet<TrainingPlanExercisesModel>();
        }

        public string? Id { get; set; } 

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string Image { get; set; } = null!;

        public ICollection<TrainingPlanExercisesModel> AddedExercises { get; set; }
    }
}
