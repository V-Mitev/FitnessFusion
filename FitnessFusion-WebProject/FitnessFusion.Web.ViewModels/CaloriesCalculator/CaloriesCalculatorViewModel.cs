namespace FitnessFusion.Web.ViewModels.CaloriesCalculator
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.CaloriesCalculator;

    public class CaloriesCalculatorViewModel
    {
        [Range(MinAgeValue, MaxAgeValue)]
        public int Age { get; set; }

        public string Gender { get; set; } = null!;

        public string ActivityLevel { get; set; } = null!;

        [Range(MinHeightValue, MaxHeightValue)]
        public double Height { get; set; }

        [Range(MinWeightValue, MaxWeightValue)]
        public double Weight { get; set; }

        public string Goal { get; set; } = null!;

        public string? CurrentCaloriesIntake { get; set; }
    }
}
