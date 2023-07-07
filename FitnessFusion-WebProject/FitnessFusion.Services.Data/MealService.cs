namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Meal;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class MealService : IMealService
    {
        private readonly FitnessFusionDbContext data;

        public MealService(FitnessFusionDbContext data)
        {
            this.data = data;
        }

        public async Task AddMealAsync(AddMealViewModel meal)
        {
            Meal newMeal = new Meal()
            {
                MealName = meal.Name,
                ImageUrl = meal.ImageUrl,
                CaloriesPer100g = meal.Calories,
                MealType = meal.MealType
            };

            await data.Meals.AddAsync(newMeal);
            await data.SaveChangesAsync();
        }

        public async Task<ICollection<AllMealsViewModel>> AllAsync()
        {
            var meals = await data.Meals
                .Select(m => new AllMealsViewModel()
                {
                    Name = m.MealName,
                    Calories = m.CaloriesPer100g,
                    MealType = m.MealType.ToString(),
                })
                .ToListAsync();

            return meals;
        }
    }
}