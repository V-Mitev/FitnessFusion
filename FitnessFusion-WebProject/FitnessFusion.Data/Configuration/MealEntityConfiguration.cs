namespace FitnessFusion.Data.Configuration
{
    using FitnessFusion.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MealEntityConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(GenerateMeals());
        }

        private ICollection<Meal> GenerateMeals()
        {
            ICollection<Meal> meals = new HashSet<Meal>();

            Meal meal;

            meal = new Meal()
            {
                MealName = "TestBreakfast",
                ImageUrl = "/img/musli.png",
                CaloriesPer100g = 300,
                MealType = Models.Enums.MealType.Breakfast
            };
            meals.Add(meal);

            meal = new Meal()
            {
                MealName = "TestLunch",
                ImageUrl = "aaaaaaaaa",
                CaloriesPer100g = 300,
                MealType = Models.Enums.MealType.Lunch
            };
            meals.Add(meal);

            meal = new Meal()
            {
                MealName = "TestDinner",
                ImageUrl = "aaaaaaaaa",
                CaloriesPer100g = 300,
                MealType = Models.Enums.MealType.Dinner
            };
            meals.Add(meal);

            meal = new Meal()
            {
                MealName = "TestSnack",
                ImageUrl = "aaaaaaaaa",
                CaloriesPer100g = 300,
                MealType = Models.Enums.MealType.Snack
            };
            meals.Add(meal);

            return meals;
        }
    }
}
