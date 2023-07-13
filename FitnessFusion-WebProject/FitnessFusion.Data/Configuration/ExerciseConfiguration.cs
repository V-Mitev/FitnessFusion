namespace FitnessFusion.Data.Configuration
{
    using FitnessFusion.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.HasData(GenerateExercise());
        }

        private ICollection<Exercise> GenerateExercise()
        {
            ICollection<Exercise> exercises = new HashSet<Exercise>();

            Exercise exercise;

            exercise = new Exercise()
            {
                Id = Guid.NewGuid(),
                Name = "Bench press",
                Description = "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.",
                Difficulty = Models.Enums.ExerciseLevelOfDificulty.Intermediate,
                MuscleGroup = Models.Enums.MuscleGroups.Chest,
                VideoLink = "https://youtu.be/gRVjAtPip0Y",
                ImagePath = "BenchPress.jfif"
            };
            exercises.Add(exercise);

            exercise = new Exercise()
            {
                Id = Guid.NewGuid(),
                Name = "Squat",
                Description = "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.",
                Difficulty = Models.Enums.ExerciseLevelOfDificulty.Intermediate,
                MuscleGroup = Models.Enums.MuscleGroups.Legs,
                VideoLink = "https://youtu.be/MVMNk0HiTMg",
                ImagePath = "Squat.jfif"
            };
            exercises.Add(exercise);

            exercise = new Exercise()
            {
                Id = Guid.NewGuid(),
                Name = "Pull Up",
                Description = "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.",
                Difficulty = Models.Enums.ExerciseLevelOfDificulty.Intermediate,
                MuscleGroup = Models.Enums.MuscleGroups.Back,
                VideoLink = "https://youtu.be/poyr8KenUfc",
                ImagePath = "PullUp.jfif"
            };
            exercises.Add(exercise);

            return exercises;
        }
    }
}
