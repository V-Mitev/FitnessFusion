namespace FitnessFusion.Services.Tests.Meal
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models.Enums;
    using FitnessFusion.Services.Data;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Meal;
    using Microsoft.EntityFrameworkCore;
    using static FitnessFusion.Services.Tests.TestData.DataSeeder;

    public class MealServiceTest
    {
        private DbContextOptions<FitnessFusionDbContext> dbOptions;
        private FitnessFusionDbContext dbContext;

        private IMealService mealService;

        private string firstMealId;
        private string secondMealId;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<FitnessFusionDbContext>()
               .UseInMemoryDatabase(Guid.NewGuid().ToString())
               .Options;

            dbContext = new FitnessFusionDbContext(dbOptions);

            await SeedMealAsync(dbContext);

            mealService = new MealService(dbContext);
        }

        [SetUp]
        public void Setup()
        {
            firstMealId = "35ea94c3-ed8c-4aba-acc6-f7caaf07560a";
            secondMealId = "9d61e7df-20b6-42af-9137-085b84d507ac";
        }

        [Test]
        public async Task IsMealExistByIdAsyncShouldReturnTrueIfExists()
        {
            var result = await mealService.IsMealExistByIdAsync(firstMealId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsMealExistByIdAsyncShouldReturnFalseIfDoesntExists()
        {
            string id = "InvalidId";

            var result = await mealService.IsMealExistByIdAsync(id);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task AddMealAsyncShouldAddMealSuccesfullyAndCountWillIncreaseWithOne()
        {
            var meal = new AddMealModel()
            {
                Name = "New Meal",
                Calories = 444,
                MealType = MealType.Dinner,
                ImageUrl = "NewMealImage"
            };

            var mealsCountBeforeAdd = dbContext.Meals.Count();

            await mealService.AddMealAsync(meal);

            var mealsCountAfterAdd = dbContext.Meals.Count();

            Assert.That(mealsCountBeforeAdd, Is.LessThan(mealsCountAfterAdd), "The count of meals after adding is not as expected.");
        }

        [Test]
        public async Task AddMealAsyncShouldNotIncreaseCountOfMeals()
        {
            var meal = new AddMealModel();

            var mealsCountBeforeAdd = dbContext.Meals.Count();

            try
            {
                await mealService.AddMealAsync(meal);
            }
            catch
            {
            }

            var mealsCountAfterAdd = dbContext.Meals.Count();

            Assert.That(mealsCountBeforeAdd, Is.EqualTo(mealsCountAfterAdd), "The count of meals should not increase after attempting to add a meal.");
        }

        [Test]
        public async Task FindMealAsyncShouldReturnAddMealModel()
        {
            var mealModel = await mealService.FindMealAsync(firstMealId);

            Assert.IsInstanceOf<AddMealModel>(mealModel, "Model should be AddMealModel");
        }

        [Test]
        public void FindMealAsyncShouldReturnInvalidOperationExceptionAsync()
        {
            string invalidId = "7d64efd8-d576-43d6-bd79-e959f440db95";

            Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await mealService.FindMealAsync(invalidId);
            }, "Meal should not exists");
        }

        [Test]
        public async Task DeleteMealAsyncShouldDeleteMealSuccessfulyAsync()
        {
            await mealService.DeleteMealAsync(secondMealId);

            var deletedMeal = await dbContext.Meals
                .Where(m => m.Id.ToString() == secondMealId)
                .FirstOrDefaultAsync();

            Assert.Null(deletedMeal, "The meal should have been deleted");
        }

        [Test]
        public void DeleteMealAsyncShouldReturnInvalidOperationExceptionAsync()
        {
            string invalidId = "7d64efd8-d576-43d6-bd79-e959f440db95";

            Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await mealService.DeleteMealAsync(invalidId);
            }, "Meal should not exists");
        }

        [Test]
        public void AllAsyncShouldReturnAllMealsInDbAsync()
        {
            var mealsFromDb = dbContext.Meals.Count();

            var mealsFromService = mealService.AllAsync().Result.Count;

            Assert.That(mealsFromService, Is.EqualTo(mealsFromDb), "Number of meals should be equal");

        }

        [Test]
        public async Task EditMealAsyncShouldEditSuccessfully()
        {
            var meal = new AddMealModel()
            {
                Name = "EditMeal",
                Calories = 100,
                ImageUrl = "EditMeal",
                MealType = MealType.Dinner
            };

            await mealService.EditMealAsync(firstMealId, meal);

            var editedMeal = dbContext.Meals.FirstOrDefault(m => m.Id.ToString() == firstMealId);

            Assert.That(meal.Name, Is.EqualTo(editedMeal!.Name));
            Assert.That(meal.Calories, Is.EqualTo(editedMeal!.CaloriesPer100g));
            Assert.That(meal.ImageUrl, Is.EqualTo(editedMeal!.ImageUrl));
            Assert.That(meal.MealType, Is.EqualTo(editedMeal!.MealType));

        }

        [Test]
        public void EditMealAsyncShoultThrowNullReferenceExceptionWhenMealDoesntExistAsync()
        {
            var meal = new AddMealModel()
            {
                Name = "EditMeal",
                Calories = 100,
                ImageUrl = "EditMeal",
                MealType = MealType.Dinner
            };

            var mealId = string.Empty;

            Assert.ThrowsAsync<NullReferenceException>(async () =>
            {
                await mealService.EditMealAsync(mealId, meal);
            }, "Meal should not exists");
        }
    }
}