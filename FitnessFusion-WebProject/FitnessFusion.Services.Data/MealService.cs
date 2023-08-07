namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models;
    using FitnessFusion.Data.Models.Enums;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Meal;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class MealService : IMealService
    {
        private readonly FitnessFusionDbContext dbContext;

        public MealService(FitnessFusionDbContext data)
        {
            this.dbContext = data;
        }

        public async Task AddMealAsync(AddMealViewModel meal)
        {
            Meal newMeal = new Meal()
            {
                Name = meal.Name,
                ImageUrl = meal.ImageUrl,
                CaloriesPer100g = meal.Calories,
                MealType = (MealType)meal.MealType!,
            };

            await dbContext.Meals.AddAsync(newMeal);
            await dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<AllMealsViewModel>> AllAsync()
        {
            var meals = await dbContext.Meals
                .Select(m => new AllMealsViewModel()
                {
                    Id = m.Id.ToString(),
                    Name = m.Name,
                    Calories = m.CaloriesPer100g,
                    MealType = m.MealType.ToString(),
                    Image = m.ImageUrl
                })
                .ToListAsync();

            return meals;
        }

        public async Task DeleteMealAsync(string mealId)
        {
            var meal = await dbContext.Meals.FindAsync(Guid.Parse(mealId));

            if (meal == null)
            {
                throw new InvalidOperationException("This meal doesn't exist");
            }

            dbContext.Meals.Remove(meal);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditMealAsync(string mealId, AddMealViewModel model)
        {
            var mealToEdit = await dbContext.Meals.FirstOrDefaultAsync(m => m.Id.ToString() == mealId);

            if (mealToEdit == null)
            {
                throw new NullReferenceException("This meal doesn't exists");
            }

            mealToEdit.Id = Guid.Parse(mealId);
            mealToEdit.Name = model.Name;
            mealToEdit.CaloriesPer100g = model.Calories;
            mealToEdit.MealType = (MealType)model.MealType!;
            mealToEdit.ImageUrl = model.ImageUrl;

            await dbContext.SaveChangesAsync();
        }

        public async Task<AddMealViewModel> FindMealAsync(string mealId)
        {
            var meal = await dbContext.Meals.FindAsync(Guid.Parse(mealId));

            if (meal == null)
            {
                throw new InvalidOperationException("This meal doesn't exists");
            }

            AddMealViewModel mealViewModel = new AddMealViewModel()
            {
                Name = meal.Name,
                Calories = meal.CaloriesPer100g,
                MealType = meal.MealType,
                ImageUrl = meal.ImageUrl
            };

            return mealViewModel;
        }
    }
}