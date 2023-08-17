namespace FitnessFusion.Services.Tests.Exercise
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models.Enums;
    using FitnessFusion.Services.Data;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Exercise;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    using static FitnessFusion.Services.Tests.TestData.DataSeeder;

    public class ExerciseTestService
    {
        private DbContextOptions<FitnessFusionDbContext> dbOptions;
        private FitnessFusionDbContext dbContext;

        private IExerciseService exerciseService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<FitnessFusionDbContext>()
              .UseInMemoryDatabase(Guid.NewGuid().ToString())
              .Options;

            dbContext = new FitnessFusionDbContext(dbOptions);

            SeedExercise(dbContext);

            exerciseService = new ExerciseService(dbContext);
        }

        [Test]
        public async Task IsExerciseExistByIdAsyncShouldReturnTrueIfExistsAsync()
        {
            string id = "57fb1075-0c17-41f6-82e1-499c7b18dbf2";

            var result = await exerciseService.IsExerciseExistByIdAsync(id);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsExerciseExistByIdAsyncShouldReturnFalseAsync()
        {
            string id = "bd85113c-899f-4b0c-990d-d15f3cd3fb79";

            var result = await exerciseService.IsExerciseExistByIdAsync(id);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task FindExerciseAsyncShoulReturnAddExerciseModelAsync()
        {
            var exerciseId = "57fb1075-0c17-41f6-82e1-499c7b18dbf2";

            var exercise = await exerciseService.FindExerciseAsync(exerciseId);

            Assert.IsNotNull(exercise);
        }

        [Test]
        public void AddExerciseAsyncShouldIncreaseCountOfExerciseInDbAsync()
        {
            var model = new AddExerciseModel()
            {
                Name = "Test",
                Description = "Test description about exercise",
                Dificulty = ExerciseLevelOfDificulty.Beginner,
                Image = "Test",
                MuscleGroup = MuscleGroups.Abs,
                VideoLink = "Test"
            };

            var result = exerciseService.AddExerciseAsync(model);

            Assert.IsTrue(result.IsCompleted, "Exercise should be added successfully");
        }

        [Test]
        public void AddExerciseAsyncShouldNotCompleteWithNullModelAsync()
        {
            var model = new AddExerciseModel();

            var result = exerciseService.AddExerciseAsync(model).IsCanceled;

            Assert.IsFalse(result);
        }

        [Test]
        public async Task AddExistingExerciseAsyncShouldReturnAddExerciseModelAsync()
        {
            var existingExercise = "57fb1075-0c17-41f6-82e1-499c7b18dbf2";

            var result = await exerciseService.AddExistingExerciseAsync(existingExercise);

            Assert.IsNotNull(result);
        }

        [Test]
        public async Task AddExistingExerciseAsyncShouldReturnNullAsync()
        {
            var existingExercise = "InvalidId";

            var result = await exerciseService.AddExistingExerciseAsync(existingExercise);

            Assert.IsNull(result);
        }
    }
}
