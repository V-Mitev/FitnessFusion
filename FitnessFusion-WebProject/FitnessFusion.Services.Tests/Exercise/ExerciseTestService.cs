namespace FitnessFusion.Services.Tests.Exercise
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models.Enums;
    using FitnessFusion.Services.Data;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Exercise;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;
    using static FitnessFusion.Services.Tests.TestData.DataSeeder;

    public class ExerciseTestService
    {
        private DbContextOptions<FitnessFusionDbContext> dbOptions;
        private FitnessFusionDbContext dbContext;

        private IExerciseService exerciseService;

        private static string firstExerciseId;
        private static string secondExerciseId;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<FitnessFusionDbContext>()
              .UseInMemoryDatabase(Guid.NewGuid().ToString())
              .Options;

            dbContext = new FitnessFusionDbContext(dbOptions);

            await SeedExerciseAsync(dbContext);

            exerciseService = new ExerciseService(dbContext);

            firstExerciseId = "57fb1075-0c17-41f6-82e1-499c7b18dbf2";
            secondExerciseId = "4297b564-6913-4538-b4e9-ab6f24c3d5ec";
        }

        [Test]
        public async Task IsExerciseExistByIdAsyncShouldReturnTrueIfExistsAsync()
        {
            var result = await exerciseService.IsExerciseExistByIdAsync(firstExerciseId);

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
            var exercise = await exerciseService.FindExerciseAsync(firstExerciseId);

            Assert.IsNotNull(exercise);
        }

        [Test]
        public void FindExerciseAsyncShouldThrowArgumentNullException()
        {
            var wrongId = "2a848c94-b062-431e-944d-f25b3a97b22c";

            Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
                await exerciseService.FindExerciseAsync(wrongId);
            }, "Exercise sould not exists!");
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
            var result = await exerciseService.AddExistingExerciseAsync(firstExerciseId);

            Assert.IsNotNull(result);
        }

        [Test]
        public async Task AddExistingExerciseAsyncShouldReturnNullAsync()
        {
            var existingExercise = "InvalidId";

            var result = await exerciseService.AddExistingExerciseAsync(existingExercise);

            Assert.IsNull(result);
        }

        [Test]
        public void AlreadyCreatedAsyncShouldReturnCollectionOfExercisesAsync()
        {
            var alreadyCreatedExercises = dbContext.Exercises
                .Select(e => new AllExercisesModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    Description = e.Description,
                    ImagePath = e.ImagePath,
                    VideoLink = e.VideoLink,
                    MuscleGroup = e.MuscleGroup.ToString(),
                    Difficulty = e.Difficulty.ToString(),
                })
                .ToList();

            var exercisesFromService = exerciseService.AlreadyCreatedAsync().Result.ToList();

            for (int i = 0; i < alreadyCreatedExercises.Count; i++)
            {
                Assert.IsNotNull(exercisesFromService, "This collection can't be null");
                Assert.That(alreadyCreatedExercises[i].Id, Is.EqualTo(exercisesFromService[i].Id));
                Assert.That(alreadyCreatedExercises[i].Name, Is.EqualTo(exercisesFromService[i].Name));
                Assert.That(alreadyCreatedExercises[i].Description, Is.EqualTo(exercisesFromService[i].Description));
                Assert.That(alreadyCreatedExercises[i].ImagePath, Is.EqualTo(exercisesFromService[i].ImagePath));
                Assert.That(alreadyCreatedExercises[i].VideoLink, Is.EqualTo(exercisesFromService[i].VideoLink));
                Assert.That(alreadyCreatedExercises[i].MuscleGroup, Is.EqualTo(exercisesFromService[i].MuscleGroup));
                Assert.That(alreadyCreatedExercises[i].Difficulty, Is.EqualTo(exercisesFromService[i].Difficulty));
            }
        }

        [Test]
        public void DeleteExerciseAsyncShouldDeleteItSuccssessfullyAsync()
        {
            var isCompleted = exerciseService.DeleteExerciseAsync(secondExerciseId);

            Assert.IsTrue(isCompleted.IsCompleted);
        }

        [Test]
        public void DeleteExerciseAsyncShouldThrowArgumentNullException()
        {
            var wrongId = "2a848c94-b062-431e-944d-f25b3a97b22c";

            Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
                await exerciseService.DeleteExerciseAsync(wrongId);
            }, "Exercise sould not exists!");
        }

        [Test]
        public async Task DetailsAsyncShouldReturnEqualExercises()
        {
            var exercise = await dbContext.Exercises
                .Select(e => new AllExercisesModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    Description = e.Description,
                    Difficulty = e.Difficulty.ToString(),
                    ImagePath = e.ImagePath,
                    VideoLink = e.VideoLink,
                    MuscleGroup = e.MuscleGroup.ToString()
                })
                .FirstOrDefaultAsync(e => e.Id.ToString() == firstExerciseId);

            var eexrciseDetail = await exerciseService.DetailsAsync(firstExerciseId);

            Assert.That(exercise!.Id, Is.EqualTo(eexrciseDetail.Id));
            Assert.That(exercise!.Name, Is.EqualTo(eexrciseDetail.Name));
            Assert.That(exercise!.Description, Is.EqualTo(eexrciseDetail.Description));
            Assert.That(exercise!.Difficulty, Is.EqualTo(eexrciseDetail.Difficulty));
            Assert.That(exercise!.ImagePath, Is.EqualTo(eexrciseDetail.ImagePath));
            Assert.That(exercise!.VideoLink, Is.EqualTo(eexrciseDetail.VideoLink));
            Assert.That(exercise!.MuscleGroup, Is.EqualTo(eexrciseDetail.MuscleGroup));
        }

        [Test]
        public void DetailsAsyncShouldThrowNullReferenceException()
        {
            var wrongId = "2a848c94-b062-431e-944d-f25b3a97b22c";

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await exerciseService.DetailsAsync(wrongId);
            }, "Exercise sould not exists!");
        }

        [Test]
        public async Task EditExerciseAsyncShouldEditExerciseSuccssessfully()
        {
            var exerciseWithNewParams = new AddExerciseModel()
            {
                Name = "NewName",
                Description = "New description for this exercise",
                Dificulty = ExerciseLevelOfDificulty.Beginner,
                MuscleGroup = MuscleGroups.Тrapezius,
                Image = "NewImage",
                VideoLink = "NewVideoLink"
            };

            await exerciseService.EditExerciseAsync(firstExerciseId, exerciseWithNewParams);

            var exerciseToEdit = await dbContext.Exercises
                .Where(e => e.Id.ToString() == firstExerciseId)
                .Select(e => new AddExerciseModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    Description = e.Description,
                    Dificulty = e.Difficulty,
                    Image = e.ImagePath,
                    VideoLink = e.VideoLink,
                    MuscleGroup = e.MuscleGroup
                })
                .FirstOrDefaultAsync();

            Assert.That(exerciseToEdit!.Id, Is.EqualTo(firstExerciseId));
            Assert.That(exerciseToEdit.Name, Is.EqualTo(exerciseWithNewParams.Name));
            Assert.That(exerciseToEdit.Description, Is.EqualTo(exerciseWithNewParams.Description));
            Assert.That(exerciseToEdit.Dificulty, Is.EqualTo(exerciseWithNewParams.Dificulty));
            Assert.That(exerciseToEdit.Image, Is.EqualTo(exerciseWithNewParams.Image));
            Assert.That(exerciseToEdit.VideoLink, Is.EqualTo(exerciseWithNewParams.VideoLink));
            Assert.That(exerciseToEdit.MuscleGroup, Is.EqualTo(exerciseWithNewParams.MuscleGroup));
        }

        [Test]
        public void EditExerciseAsyncShouldThrowArgumentNullException()
        {
            var wrongId = "2a848c94-b062-431e-944d-f25b3a97b22c";

            var model = new AddExerciseModel();

            Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
                await exerciseService.EditExerciseAsync(wrongId, model);
            }, "Exercise sould not exists!");
        }

        [Test]
        public async Task AllAsyncQueryModelMuscleGroupShouldHaveValueAsync()
        {
            var queryModel = new AllExercisesQueryModel()
            {
                MuscleGroup = MuscleGroups.Chest
            };

            var result = await exerciseService.AllAsync(queryModel);

            Assert.IsTrue(result.Exercises.Any(e => e.MuscleGroup == queryModel.MuscleGroup.ToString()));
        }

        [Test]
        public async Task AllAsyncQueryModelSearchStringShouldHaveValueAndReturnExercisesIfExistsAsync()
        {
            var queryModel = new AllExercisesQueryModel()
            {
                SearchString = "Pull Up",
            };

            var result = await exerciseService.AllAsync(queryModel);

            Assert.IsTrue(result.Exercises.Any(e => e.Name == queryModel.SearchString));
        }
    }
}
