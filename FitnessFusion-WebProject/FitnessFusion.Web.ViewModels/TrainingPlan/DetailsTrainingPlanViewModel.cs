namespace FitnessFusion.Web.ViewModels.TrainingPlan
{
    public class DetailsTrainingPlanViewModel : AllTrainingPlansViewModel
    {
        public DetailsTrainingPlanViewModel()
        {
            Exercises = new HashSet<TrainingPlanExercises>();
        }

        public ICollection<TrainingPlanExercises> Exercises { get; set; }
    }
}
