namespace FitnessFusion.Web.ViewModels.Meal
{
    using FitnessFusion.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Meal;

    public class AddMealModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(ImageUrlMaxLength, MinimumLength = ImageUrlMinLength)]
        public string ImageUrl { get; set; } = null!;

        [Range(CaloriesMinValue, CaloriesMaxValue)]
        public double Calories { get; set; }

        [Required]
        public MealType? MealType { get; set; }
    }
}
