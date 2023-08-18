namespace FitnessFusion.Services.Tests.Trainer
{
    using FitnessFusion.Data;
    using FitnessFusion.Services.Data;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Trainer;
    using Microsoft.EntityFrameworkCore;
    using static FitnessFusion.Services.Tests.TestData.DataSeeder;

    public class TrainerServiceTest
    {
        private FitnessFusionDbContext dbContext;
        private DbContextOptions<FitnessFusionDbContext> dbOptions;

        private ITrainerService trainerService;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<FitnessFusionDbContext>()
               .UseInMemoryDatabase(Guid.NewGuid().ToString())
               .Options;

            dbContext = new FitnessFusionDbContext(dbOptions);

            await SeedTrainersAsync(dbContext);

            trainerService = new TrainerService(dbContext);
        }

        [Test]
        public async Task IsUserTrainerAsyncShouldReturnTrue()
        {
            var trainerId = "a19a795b-b45f-4c53-9958-d8fd71e1212a";

            var result = await trainerService.IsUserTrainerAsync(trainerId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsUserTrainerAsyncShouldReturnFalseWhenTrainerIdIsWrong()
        {
            var trainerId = "a19a795b-b45f-a48r-958-d8fd71e1212a";

            var result = await trainerService.IsUserTrainerAsync(trainerId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsEmailAlreadyAddedShouldReturnTrue()
        {
            var email = "ivan@abv.bg";

            var result = await trainerService.IsEmailAlreadyAdded(email);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsEmailAlreadyAddedShouldReturnFalse()
        {
            var email = "iva@abv.bg";

            var result = await trainerService.IsEmailAlreadyAdded(email);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task AddTrainerAsyncShouldIncreaseCountOfTrainers()
        {
            var trainersBeforeAdd = dbContext.Trainers.Count();

            var trainerToAdd = new TrainerViewModel()
            {
                FirstName ="Cvetan",
                LastName = "Dimitrov",
                Email = "cvetan@abv.bg",
                Description = "Test description about Cvetan"
            };

            await trainerService.AddTrainerAsync(trainerToAdd);

            var trainersAfterAdd = dbContext.Trainers.Count();

            Assert.That(trainersBeforeAdd, Is.LessThan(trainersAfterAdd));
        }

        [Test]
        public async Task RemoveTrainerAsyncShouldDecreaseCountOfTrainers()
        {
            var trainerId = "f2ab1a33-7228-4667-9267-b9c5568a31d5";

            var trainersBeforeRemove = dbContext.Trainers.Count();

            await trainerService.RemoveTrainerAsync(trainerId);

            var trainersAfterRemove = dbContext.Trainers.Count();

            Assert.That(trainersBeforeRemove, Is.GreaterThan(trainersAfterRemove));
        }

        [Test]
        public void RemoveTrainerAsyncShouldThrowNullReferenceException()
        {
            var trainerId = "bb9fdea9-67b1-4f87-985b-f24df6eba7e0";

            var trainersBeforeRemove = dbContext.Trainers.Count();

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await trainerService.RemoveTrainerAsync(trainerId);
            }, "Trainer id doesnt exists should throw exception");
        }
    }
}
