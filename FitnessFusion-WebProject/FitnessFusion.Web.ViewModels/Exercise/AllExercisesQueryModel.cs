namespace FitnessFusion.Web.ViewModels.Exercise
{
    using FitnessFusion.Data.Models.Enums;
    using System.ComponentModel;
    using static Common.GeneralApplicationConstants;

    public class AllExercisesQueryModel
    {
        public AllExercisesQueryModel()
        {
            CurrentPage = DefaultPage;
            ExercisesPerPage = EntitiesPerPage;

            MusclesGroups = new HashSet<MuscleGroups>();
            Exercises = new HashSet<AllExercisesModel>();
        }

        [DisplayName("Muscles Groups")]
        public MuscleGroups? MuscleGroup { get; set; }
        
        [DisplayName("Search by word")]
        public string? SearchString { get; set; }

        public int CurrentPage { get; set; }

        [DisplayName("Show Exercises On Page")]
        public int ExercisesPerPage { get; set; }

        public int TotalExercises { get; set; }

        public ICollection<MuscleGroups> MusclesGroups { get; set; }

        public ICollection<AllExercisesModel> Exercises { get; set; }
    }
}
