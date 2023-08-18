namespace FitnessFusion.Services.Tests.TrainingPlan
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models.Enums;
    using FitnessFusion.Services.Data;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Exercise;
    using FitnessFusion.Web.ViewModels.TrainingPlan;
    using Microsoft.EntityFrameworkCore;
    using static FitnessFusion.Services.Tests.TestData.DataSeeder;

    public class TrainingPlanServiceTest
    {
        private FitnessFusionDbContext dbContext;
        private DbContextOptions<FitnessFusionDbContext> dbOptions;

        private ITrainingPlanService trainingPlanService;

        private const string correctId = "d6c89f41-9ea4-4ed3-a585-7b3650c04d8f";
        private const string invalidId = "d3fc486a-658f-4957-9b7f-9c705e450582";

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            dbOptions = new DbContextOptionsBuilder<FitnessFusionDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            dbContext = new FitnessFusionDbContext(dbOptions);

            await SeedTrainingPlanAsync(dbContext);
            await SeedTrainersAsync(dbContext);

            trainingPlanService = new TrainingPlanService(dbContext);
        }

        [Test]
        public async Task IsTrainingPlanExistByIdAsyncShouldReturnTrue()
        {
            var result = await trainingPlanService.IsTrainingPlanExistByIdAsync(correctId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsTrainingPlanExistByIdAsyncShouldReturnFalseWhenIdIsInvalid()
        {
            var result = await trainingPlanService.IsTrainingPlanExistByIdAsync(invalidId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetAllTrainingPlansAsyncShouldReturnOne()
        {
            var trainingPlansCount = dbContext.TrainingPlans.Count();

            var plansFromService = await trainingPlanService.GetAllTrainingPlansAsync();

            Assert.That(plansFromService.Count, Is.EqualTo(trainingPlansCount));
        }

        [Test]
        public async Task FindTrainingPlanByIdAsyncShouldReturnCorrectTrainingPlan()
        {
            var trainingPlan =
                await dbContext.TrainingPlans.FirstOrDefaultAsync(tp => tp.Id.ToString() == correctId);

            var result = await trainingPlanService.FindTrainingPlanByIdAsync(correctId);

            Assert.That(trainingPlan!.Id.ToString(), Is.EqualTo(result.Id));
        }

        [Test]
        public async Task FindTrainingPlanByIdAsyncShouldThrowNullReferenceException()
        {
            await trainingPlanService.FindTrainingPlanByIdAsync(correctId);

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await trainingPlanService.FindTrainingPlanByIdAsync(invalidId);
            }, "Training plan doesn't exist");
        }

        [Test]
        public async Task AddExerciseToExistingPlanAsyncShouldIncreaseExercises()
        {
            var trainingPlan =
                await dbContext.TrainingPlans.FirstOrDefaultAsync(tp => tp.Id.ToString() == correctId);

            var exercisesBeforeAdd = trainingPlan!.Exercises.Count();

            var model = new AddExerciseModel()
            {
                Name = "Test exercise name",
                Description = "Description about test exercise",
                Image = "ExerciseImage",
                VideoLink = "ExerciseVideoLink",
                MuscleGroup = MuscleGroups.Shoulders,
                Dificulty = ExerciseLevelOfDificulty.Advanced
            };

            await trainingPlanService.AddExerciseToExistingPlanAsync(model, correctId);

            var exercisesAfterAdd = trainingPlan.Exercises.Count();

            Assert.That(exercisesBeforeAdd, Is.LessThan(exercisesAfterAdd));
        }

        [Test]
        public void AddExerciseToExistingPlanAsyncShouldThrowNullReferenceException()
        {
            var model = new AddExerciseModel();

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await trainingPlanService.AddExerciseToExistingPlanAsync(model, invalidId);
            });
        }

        [Test]
        public async Task AddExerciseWhenEditPlanShouldIncreaseCountOfExercises()
        {
            var trainingPlan =
                await dbContext.TrainingPlans.FirstOrDefaultAsync(tp => tp.Id.ToString() == correctId);

            var exercisesBeforeAdd = trainingPlan!.Exercises.Count();

            var exerciseId = "57fb1075-0c17-41f6-82e1-499c7b18dbf2";

            await trainingPlanService.AddExerciseWhenEditPlan(correctId, exerciseId);

            var exercisesAfterAdd = trainingPlan.Exercises.Count();

            Assert.That(exercisesBeforeAdd, Is.LessThan(exercisesAfterAdd));
        }

        [Test]
        public async Task AddTrainingPlanAsyncShouldAddTrainingPlanInDb()
        {
            var exerciseId = "4297b564-6913-4538-b4e9-ab6f24c3d5ec";
            var trainerId = "a19a795b-b45f-4c53-9958-d8fd71e1212a";

            var trainingPlan = new TrainingPlanModel()
            {
                Name = "Test training plan",
                Description = "Description about training plan",
                Image = "TrainingPlanImage"
            };

            var exercise = await dbContext.Exercises
                .Where(e => e.Id.ToString() == exerciseId)
                .Select(e => new AddExerciseModel()
                {
                    Name = e.Name,
                    Description = e.Description,
                    Image = e.ImagePath,
                    Dificulty = e.Difficulty,
                    MuscleGroup = e.MuscleGroup,
                    VideoLink = e.VideoLink
                })
                .FirstOrDefaultAsync();

            trainingPlan.AddedExercises.Add(exercise!);

            var isAddedSuccssessfully = trainingPlanService.AddTrainingPlanAsync(trainingPlan, trainerId);

            Assert.That(isAddedSuccssessfully.IsCompleted);
        }

        [Test]
        public void AddTrainingPlanAsyncShouldThrowNullReferenceException()
        {
            var invalidTrainerId = "";

            var model = new TrainingPlanModel();

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await trainingPlanService.AddTrainingPlanAsync(model, invalidTrainerId);
            });
        }

        [Test]
        public void DeleteTrainingPlanAsyncShouldCompleteTaskWhenIdIsCorrect()
        {
            var trainingPlanId = "89996373-6df1-4d81-a982-b78c8b188ae8";

            var result = trainingPlanService.DeleteTrainingPlanAsync(trainingPlanId);

            Assert.That(result.IsCompleted);
        }

        [Test]
        public void DeleteTrainingPlanAsyncShouldThrowNullreferenceException()
        {
            var trainingPlanId = "1adc0782-7255-4ad6-98ad-bdc3d5f8eb21";

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await trainingPlanService.DeleteTrainingPlanAsync(trainingPlanId);
            });
        }

        [Test]
        public void RemoveExerciseFromPlanShouldDecreaseExercisesAsync()
        {
            var trainingPlanId = "d6c89f41-9ea4-4ed3-a585-7b3650c04d8f";

            var exerciseId = "4297b564-6913-4538-b4e9-ab6f24c3d5ec";

            var isTaskComplete = trainingPlanService.RemoveExerciseFromPlan(trainingPlanId, exerciseId);

            Assert.That(isTaskComplete.IsCompleted);
        }

        [Test]
        public void DetailsAsyncShouldThrowNullReferenceExceptionWhenTpIdIsInvalid()
        {
            var trainingPlanId = "";

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await trainingPlanService.DetailsAsync(trainingPlanId);
            });
        }

        [Test]
        public async Task DetailsAsyncShouldThrowNullReferenceExceptionWhenTrainerDoesntExist()
        {
            var trainingPlanId = "d6c89f41-9ea4-4ed3-a585-7b3650c04d8f";

            var trainerId = "e4ff3bae-e07a-4266-baf8-bb167884beef";

            var trainingPlan = await dbContext.TrainingPlans.FindAsync(Guid.Parse(trainingPlanId));

            trainingPlan!.TrainerId = Guid.Parse(trainerId);

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await trainingPlanService.DetailsAsync(trainingPlanId);
            });
        }

        [Test]
        public async Task DetailsAsyncShouldCompleteIfIdIsCorrect()
        {
            var trainingPlanId = "d6c89f41-9ea4-4ed3-a585-7b3650c04d8f";

            var trainingPlan = await dbContext.TrainingPlans.FindAsync(Guid.Parse(trainingPlanId));

            var result = await trainingPlanService.DetailsAsync(trainingPlanId);

            var trainer = trainingPlan!.Trainer.FirstName + " " + trainingPlan.Trainer.LastName;

            Assert.That(trainingPlan!.Name, Is.EqualTo(result.Name));
            Assert.That(trainer, Is.EqualTo(result.Trainer));
            Assert.That(trainingPlan!.Exercises.Count, Is.EqualTo(result.Exercises.Count));
            Assert.That(trainingPlan!.Description, Is.EqualTo(result.Description));
        }

        [Test]
        public async Task EditTrainingPlanAsync()
        {
            var trainingPlanId = "d6c89f41-9ea4-4ed3-a585-7b3650c04d8f";
            var trainerId = "a19a795b-b45f-4c53-9958-d8fd71e1212a";

            var trainingPlan = await dbContext.TrainingPlans.FindAsync(Guid.Parse(trainingPlanId));
            trainingPlan!.TrainerId = Guid.Parse(trainerId);

            var trainingPlanModel = new TrainingPlanModel()
            {
                Name = "NewName",
                Image = "NewImage",
                Description = "New trainingPlanDescription"
            };

            await trainingPlanService.EditTrainingPlanAsync(trainingPlanModel, trainingPlanId, trainerId);
            
            Assert.That(trainingPlan!.Name, Is.EqualTo(trainingPlanModel.Name));
            Assert.That(trainingPlan!.Description, Is.EqualTo(trainingPlanModel.Description));
            Assert.That(trainingPlan!.Image, Is.EqualTo(trainingPlanModel.Image));
        }

        [Test]
        public void EditTrainingPlanAsyncThrowInvalidOperationExceptionWhenTrainerDoesntExist()
        {
            var trainingPlanModel = new TrainingPlanModel();
            var trainingPlanId = "d6c89f41-9ea4-4ed3-a585-7b3650c04d8f";
            var trainerId = "1994b57c-8269-4511-8740-6c8b191063de";

            Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await trainingPlanService.EditTrainingPlanAsync(trainingPlanModel, trainingPlanId, trainerId);
            });
        }

        [Test]
        public void EditTrainingPlanAsyncThrowNullReferenceExceptionWhenTrainingPlanDoesntExist()
        {
            var trainingPlanModel = new TrainingPlanModel();
            var trainingPlanId = "5e650dac-ca5e-4d01-9b1c-2db4b44234d8";
            var trainerId = "a19a795b-b45f-4c53-9958-d8fd71e1212a";

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await trainingPlanService.EditTrainingPlanAsync(trainingPlanModel, trainingPlanId, trainerId);
            });
        }
    }
}
