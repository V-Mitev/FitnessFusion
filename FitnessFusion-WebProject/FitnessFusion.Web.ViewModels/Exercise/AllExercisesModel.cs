namespace FitnessFusion.Web.ViewModels.Exercise
{
    public class AllExercisesModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string ImagePath { get; set; } = null!;

        public string MuscleGroup { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string VideoLink { get; set; } = null!;

        public string Difficulty { get; set; } = null!;
    }
}
