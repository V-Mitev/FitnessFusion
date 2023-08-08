namespace FitnessFusion.Web.ViewModels.Exercise
{
    public class ExerciseDetailsViewModel : AllExercisesViewModel
    {
        public string Description { get; set; } = null!;

        public string VideoLink { get; set; } = null!;

        public string Difficulty { get; set; } = null!;
    }
}
