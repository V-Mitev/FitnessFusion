﻿namespace FitnessFusion.Web.ViewModels.Meal
{
    public class AllMealsModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public double Calories { get; set; }

        public string MealType { get; set; } = null!;

        public string Image { get; set; } = null!;
    }
}
