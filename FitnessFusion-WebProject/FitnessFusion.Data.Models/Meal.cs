using FitnessFusion.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static FitnessFusion.Common.EntityValidationConstants.Meal;

namespace FitnessFusion.Data.Models
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public double Weight { get; set; }

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;
        
        public double Calories { get; set; }

        public MealType MealType { get; set; }
    }
}
