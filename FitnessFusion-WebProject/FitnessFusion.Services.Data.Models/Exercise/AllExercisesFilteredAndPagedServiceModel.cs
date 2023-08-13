namespace FitnessFusion.Services.Data.Models.Exercise
{
    using FitnessFusion.Web.ViewModels.Exercise;

    public class AllExercisesFilteredAndPagedServiceModel
    {
        public AllExercisesFilteredAndPagedServiceModel()
        {
            Exercises = new HashSet<AllExercisesModel>();   
        }

        public int TotalExerciseCount { get; set; }

        public ICollection<AllExercisesModel> Exercises { get; set; }
    }
}
