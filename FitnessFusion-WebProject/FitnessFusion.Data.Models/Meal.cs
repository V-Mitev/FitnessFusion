namespace FitnessFusion.Data.Models
{
    using FitnessFusion.Data.Models.Enums;
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;
    using static FitnessFusion.Common.EntityValidationConstants.Meal;

    public class Meal
    {
        public Meal()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string MealName { get; set; } = null!;

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Range(CaloriesMinValue, CaloriesMaxValue)]
        public double CaloriesPer100g { get; set; }

        public MealType MealType { get; set; }
    }
}
