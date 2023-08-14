namespace FitnessFusion.Web.ViewModels.TrainingPlan
{
    using FitnessFusion.Web.ViewModels.Exercise;
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.TrainingPlan;

    public class TrainingPlanModel
    {
        public TrainingPlanModel()
        {
            AddedExercises = new HashSet<AddExerciseModel>();

            AlreadyCreatedExercises = new Dictionary<Guid, string>();
        }

        public string? Id { get; set; } 

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string Image { get; set; } = null!;

        public ICollection<AddExerciseModel> AddedExercises { get; set; }

        public Dictionary<Guid, string> AlreadyCreatedExercises { get; set; }
    }
}
