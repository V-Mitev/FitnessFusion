namespace FitnessFusion.Services.Tests.User
{
    using FitnessFusion.Data;
    using FitnessFusion.Services.Data;
    using FitnessFusion.Services.Data.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using static FitnessFusion.Services.Tests.TestData.DataSeeder;

    public class UserServiceTest
    {
        private DbContextOptions<FitnessFusionDbContext> dbOptions;
        private FitnessFusionDbContext dbContext;

        private IUserService userService;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<FitnessFusionDbContext>()
               .UseInMemoryDatabase(Guid.NewGuid().ToString())
               .Options;
            dbContext = new FitnessFusionDbContext(dbOptions);

            await SeedUsersAsync(dbContext);

            userService = new UserService(dbContext);
        }

        [Test]
        public async Task AllAsync()
        {
            var users = await userService.AllAsync();

            Assert.IsNotNull(users, "This collection can't be null, beacuse seed one user");
        }

        [Test]
        public async Task AllSubscribers()
        {
            var users = await userService.AllSubscribers();

            Assert.IsNotNull(users, "This collection can't be null, beacuse seed one user");
        }

        [Test]
        public async Task GetFullNameByEmailAsync()
        {
            var userFullName = "Gosho Goshov";
            var userEmail = "gosho@abv.bg";

            var userFullNameResult = await userService.GetFullNameByEmailAsync(userEmail);

            Assert.That(userFullName, Is.EqualTo(userFullNameResult));
        }

        [Test]
        public async Task GetFullNameByEmailAsyncWhenEmailIsNotValidShouldReturnEmptyString()
        {
            var userEmail = "wrongemail@abv.bg";

            var userFullNameResult = await userService.GetFullNameByEmailAsync(userEmail);

            Assert.IsEmpty(userFullNameResult);
        }

        [Test]
        public async Task IsUserExistByIdAsyncShouldReturnTrue()
        {
            string userId = "b7dc9a5e-80d2-49e0-9047-5c42a7a2a2a6";

            var result = await userService.IsUserExistByIdAsync(userId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsUserExistByIdAsyncShouldReturnFalseWhenIdIsWrong()
        {
            string userId = "b7dca5e-a80d2-49e0-9047-5c42a7a2a2a6";

            var result = await userService.IsUserExistByIdAsync(userId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task DeleteAsyncShouldDeleteUser()
        {
            string userId = "9f11de4f-ca0b-4405-8daf-6e01e4647042";

            var usersBeforeDelete = dbContext.ApplicationUsers.Count();

            await userService.DeleteAsync(userId);

            var usersAfterDelete = dbContext.ApplicationUsers.Count();

            Assert.That(usersBeforeDelete, Is.GreaterThan(usersAfterDelete));
        }

        [Test]
        public void DeleteAsyncShouldThrowNullReferenceExceptionWhenIdIsInvalid()
        {
            string invalidId = "f81a837a-762d-4602-81a6-cdbb46b3d0fd";

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await userService.DeleteAsync(invalidId);
            });
        }
    }
}
