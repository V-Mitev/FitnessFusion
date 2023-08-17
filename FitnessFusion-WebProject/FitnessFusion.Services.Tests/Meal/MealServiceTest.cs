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

        public MealServiceTest()
        {

        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<FitnessFusionDbContext>()
                .UseInMemoryDatabase("FitnessFusionInMemory" + Guid.NewGuid().ToString())
                .Options;

            dbContext = new FitnessFusionDbContext(dbOptions);

            mealService = new MealService(dbContext);

            SeedDataBase(dbContext);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task IsMealExistByIdAsyncShouldReturnTrueIfExists()
        {
            string mealId = FirstMeal.Id.ToString();

            var result = await mealService.IsMealExistByIdAsync(mealId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsMealExistByIdAsyncShouldReturnFalseIfDoesntExists()
        {
            string mealId = "";

            var result = await mealService.IsMealExistByIdAsync(mealId);

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
            var mealId = FirstMeal.Id.ToString();

            var mealModel = await mealService.FindMealAsync(mealId);

            Assert.IsInstanceOf<AddMealModel>(mealModel, "Model should be AddMealModel");
        }

        [Test]
        public void FindMealAsyncShouldReturnInvalidOperationException()
        {
            var mealId = "e3bd3a41-5004-40c3-8637-93bc5da460dd";

            Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await mealService.FindMealAsync(mealId);
            }, "Meal should not exists");
        }

        [Test]
        public async Task DeleteMealAsyncShouldDeleteMealSuccessfuly()
        {
            var mealId = SecondMeal.Id.ToString();

            await mealService.DeleteMealAsync(mealId);

            var deletedMeal = await dbContext.Meals
                .Where(m => m.Id.ToString() == mealId)
                .FirstOrDefaultAsync();

            Assert.Null(deletedMeal, "The meal should have been deleted");
        }

        [Test]
        public void DeleteMealAsyncShouldReturnInvalidOperationException()
        {
            var mealId = "e3bd3a41-5004-40c3-8637-93bc5da460dd";

            Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await mealService.DeleteMealAsync(mealId);
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

            await mealService.EditMealAsync(FirstMeal.Id.ToString(), meal);

            var editedMeal = dbContext.Meals.FirstOrDefault(m => m.Id == FirstMeal.Id);

            Assert.That(meal.Name, Is.EqualTo(editedMeal!.Name));
            Assert.That(meal.Calories, Is.EqualTo(editedMeal!.CaloriesPer100g));
            Assert.That(meal.ImageUrl, Is.EqualTo(editedMeal!.ImageUrl));
            Assert.That(meal.MealType, Is.EqualTo(editedMeal!.MealType));
        }

        [Test]
        public void EditMealAsyncShoultThrowNullReferenceExceptionWhenMealDoesntExist()
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