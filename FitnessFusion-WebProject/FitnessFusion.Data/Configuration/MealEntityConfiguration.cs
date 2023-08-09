namespace FitnessFusion.Data.Configuration
{
    using FitnessFusion.Data.Models;
    using FitnessFusion.Data.Models.Enums;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MealEntityConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(GenerateMeals());
        }

        private static ICollection<Meal> GenerateMeals()
        {
            ICollection<Meal> meals = new HashSet<Meal>();

            Meal meal;

            meal = new Meal()
            {
                Name = "TestBreakfast",
                ImageUrl = "Musli.png",
                CaloriesPer100g = 300,
                MealType = MealType.Breakfast
            };
            meals.Add(meal);

            meal = new Meal()
            {
                Name = "TestLunch",
                ImageUrl = "Egg.png",
                CaloriesPer100g = 300,
                MealType = MealType.Lunch
            };
            meals.Add(meal);

            meal = new Meal()
            {
                Name = "TestDinner",
                ImageUrl = "Egg.png",
                CaloriesPer100g = 300,
                MealType = MealType.Dinner
            };
            meals.Add(meal);

            meal = new Meal()
            {
                Name = "TestSnack",
                ImageUrl = "Egg.png",
                CaloriesPer100g = 300,
                MealType = MealType.Snack
            };
            meals.Add(meal);

            return meals;
        }
    }
}
