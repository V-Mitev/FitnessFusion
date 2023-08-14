namespace FitnessFusion.Web.ViewModels.TrainingPlan
{
    using FitnessFusion.Web.ViewModels.Exercise;

    public class DetailsTrainingPlanModel : AllTrainingPlansModel
    {
        public DetailsTrainingPlanModel()
        {
            Exercises = new HashSet<AddExerciseModel>();
        }

        public ICollection<AddExerciseModel> Exercises { get; set; }
    }
}
