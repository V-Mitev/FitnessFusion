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
                Id = 1,
                Name = "TestBreakfast",
                ImageUrl = "aaaaaaaaa",
                Calories = 300,
                MealType = Models.Enums.MealType.Breakfast
            };
            meals.Add(meal);

            meal = new Meal()
            {
                Id = 2,
                Name = "TestLunch",
                ImageUrl = "aaaaaaaaa",
                Calories = 300,
                MealType = Models.Enums.MealType.Lunch
            };
            meals.Add(meal);

            meal = new Meal()
            {
                Id = 3,
                Name = "TestDinner",
                ImageUrl = "aaaaaaaaa",
                Calories = 300,
                MealType = Models.Enums.MealType.Dinner
            };
            meals.Add(meal);

            meal = new Meal()
            {
                Id = 4,
                Name = "TestSnack",
                ImageUrl = "aaaaaaaaa",
                Calories = 300,
                MealType = Models.Enums.MealType.Snack
            };
            meals.Add(meal);

            return meals;
        }
    }
}
