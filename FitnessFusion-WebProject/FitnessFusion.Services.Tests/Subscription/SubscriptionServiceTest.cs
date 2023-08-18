namespace FitnessFusion.Services.Tests.Subscription
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models.Enums;
    using FitnessFusion.Services.Data;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Subscription;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    using static FitnessFusion.Services.Tests.TestData.DataSeeder;

    public class SubscriptionServiceTest
    {
        private FitnessFusionDbContext dbContext;
        private DbContextOptions<FitnessFusionDbContext> dbOptions;

        private ISubscriptionService subscriptionService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            dbOptions = new DbContextOptionsBuilder<FitnessFusionDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            dbContext = new FitnessFusionDbContext(dbOptions);

            await SeedSubscriptions(dbContext);

            await SeedUsersAsync(dbContext);

            subscriptionService = new SubscriptionService(dbContext);
        }

        [Test]
        public async Task IsSubscriptionExistByIdAsyncShouldReturnTrue()
        {
            string subscriptionId = "aa9ba662-a330-43a4-a4fa-5dc0233ac34b";

            var result = await subscriptionService.IsSubscriptionExistByIdAsync(subscriptionId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsSubscriptionExistByIdAsyncShouldReturnFalseWhenIdIsInvalid()
        {
            string subscriptionId = "aa9bas7662-a330-43a4-a4fa-5dc0233ac34b";

            var result = await subscriptionService.IsSubscriptionExistByIdAsync(subscriptionId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsSubscribeValidAsyncShouldReturnTrue()
        {
            var userId = "b7dc9a5e-80d2-49e0-9047-5c42a7a2a2a6";

            var result = await subscriptionService.IsSubscribeValidAsync(userId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsSubscribeValidAsyncShouldReturnTrueWhenPeriodIsNotExpeired()
        {
            var userId = "b7dc9a5e-80d2-49e0-9047-5c42a7a2a2a6";

            var result = await subscriptionService.IsSubscribeValidAsync(userId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsSubscribeValidAsyncShouldReturnFalseWhenIdIsInvalid()
        {
            var userId = "9f11de4f-ca0b-4405-8daf-6e01e4647042";

            var result = await subscriptionService.IsSubscribeValidAsync(userId);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsSubscribeValidAsyncShouldThrowNullReferenceExceptionWhenIdIsInvalid()
        {
            var userId = "9e8f79e0-ab66-4429-a0c6-e7e057802166";

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await subscriptionService.IsSubscribeValidAsync(userId);
            }, "Subscription doesn't exists");
        }

        [Test]
        public async Task GetSubscriptionAsyncShouldReturnSubscriptionWhenExists()
        {
            string subscriptionId = "aa9ba662-a330-43a4-a4fa-5dc0233ac34b";

            var subscription = await subscriptionService.GetSubscriptionAsync(subscriptionId);

            Assert.IsInstanceOf(typeof(SubscriptionModel), subscription);
        }

        [Test]
        public void GetSubscriptionAsyncShouldThrowNullReferenceExceptionWhenIdIsInvalid()
        {
            string id = "37740030-713f-4526-847e-d2c18d49b2a2";

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await subscriptionService.GetSubscriptionAsync(id);
            }, "Subscribption doesn't exist");
        }

        [Test]
        public void SubscribeAsyncShouldThrowNullReferenceExceptionWhenUserIsInvalid()
        {
            string subscriptionId = "37740030-713f-4526-847e-d2c18d49b2a2";

            var userId = "9f11de4f-ca0b-4405-8daf-6e01e4647042";

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await subscriptionService.SubscribeAsync(subscriptionId, userId);
            }, "Subscribption doesn't exist");
        }

        [Test]
        public void SubscribeAsyncShouldThrowNullReferenceExceptionWhenSubscriptionDoesntExists()
        {
            string subscriptionId = "aa9ba662-a330-43a4-a4fa-5dc0233ac34b";

            var userId = "6ee03f84-bd9e-4d95-875f-c6f077fd019c";

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await subscriptionService.SubscribeAsync(subscriptionId, userId);
            }, "User doesn't exist");
        }

        [Test]
        public async Task SubscribeAsyncShouldSubscribeUser()
        {
            string subscriptionId = "aa9ba662-a330-43a4-a4fa-5dc0233ac34b";

            var userId = "b7dc9a5e-80d2-49e0-9047-5c42a7a2a2a6";

            await subscriptionService.SubscribeAsync(subscriptionId, userId);

            var user = await dbContext.ApplicationUsers
                .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            Assert.That(user, Is.Not.Null);
            Assert.That(user.IsSubscribeValid, Is.True);
        }

        [Test]
        public async Task GetAllSubscriptionsAsyncShouldReturnSubscriptions()
        {
            var subscriptions = await subscriptionService.GetAllSubscriptionsAsync();

            Assert.IsNotNull(subscriptions);
        }

        [Test]
        public async Task DeleteSubscriptionAsyncShouldDecreaseCountOfSubscriptions()
        {
            var subscriptionId = "d28d8986-4b44-4a0c-958f-13b21e7775ab";

            var subscriptionsBeforeRemove = dbContext.Subscriptions.Count();

            await subscriptionService.DeleteSubscriptionAsync(subscriptionId);

            var subscriptionsAfterRemove = dbContext.Subscriptions.Count();

            Assert.That(subscriptionsBeforeRemove, Is.GreaterThan(subscriptionsAfterRemove));
        }

        [Test]
        public void DeleteSubscriptionAsyncThrowNullReferenceExceptionWhenSubscriptionDoesntExists()
        {
            string subscriptionId = "2253ef22-6f25-4365-a545-225df71bb7df";

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await subscriptionService.DeleteSubscriptionAsync(subscriptionId);
            }, "Subscription doesn't exist");
        }

        [Test]
        public async Task AddSubscriptionAsyncShouldIncreaseCountOfSubscriptions()
        {
            var subscriptionModel = new SubscriptionModel()
            {
                Id = "52993cb7-bf48-42ca-b7dd-eb4a68d448a5",
                Name = "New sub",
                TypeOfSubscription = TypeOfSubscription.Premium,
                Description = "Description about this sub",
                Image = "DescriptionImage",
                Price = 55M
            };

            var subscriptionsBeforeAdd = dbContext.Subscriptions.Count();

            await subscriptionService.AddSubscriptionAsync(subscriptionModel);

            var subscriptionsAfterAdd = dbContext.Subscriptions.Count();

            Assert.That(subscriptionsBeforeAdd, Is.LessThan(subscriptionsAfterAdd));
        }

        [Test]
        public async Task EditAsyncShouldBeSuccessfullyWhenSubscriptionExist()
        {
            string subscriptionId = "aa9ba662-a330-43a4-a4fa-5dc0233ac34b";

            var subscriptionModel = new SubscriptionModel()
            {
                Id = subscriptionId,
                Name = "New sub name",
                Description = "New subscription description",
                Image = "NewSubImage",
                TypeOfSubscription = TypeOfSubscription.Basic,
                Price = 34.5M
            };

            await subscriptionService.EditAsync(subscriptionModel, subscriptionId);

            var editedSubscription =
                await dbContext.Subscriptions.FirstOrDefaultAsync(s => s.Id.ToString() == subscriptionId);

            Assert.That(editedSubscription!.Id.ToString(), Is.EqualTo(subscriptionId));
            Assert.That(editedSubscription.Name, Is.EqualTo(subscriptionModel.Name));
            Assert.That(editedSubscription.TypeOfSubscription, Is.EqualTo(subscriptionModel.TypeOfSubscription));
            Assert.That(editedSubscription.Price, Is.EqualTo(subscriptionModel.Price));
            Assert.That(editedSubscription.Image, Is.EqualTo(subscriptionModel.Image));
            Assert.That(editedSubscription.Description, Is.EqualTo(subscriptionModel.Description));
        }

        [Test]
        public void EditAsyncShouldThrowNullReferenceExceptionWhenSubscriptionDoesntExists()
        {
            string subscriptionId = "f7817332-47ce-400e-82a1-a5074193fbab";

            var subscriptionModel = new SubscriptionModel();

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await subscriptionService.EditAsync(subscriptionModel, subscriptionId);
            }, "Subscription doesn't exist");
        }
    }
}
