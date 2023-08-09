namespace FitnessFusion.Web.ViewModels.TrainingPlan
{
    public class DetailsTrainingPlanModel : AllTrainingPlansModel
    {
        public DetailsTrainingPlanModel()
        {
            Exercises = new HashSet<TrainingPlanExercisesModel>();
        }

        public ICollection<TrainingPlanExercisesModel> Exercises { get; set; }
    }
}
