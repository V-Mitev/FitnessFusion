namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.CaloriesCalculator;

    public interface ICaloriesCalculatorService
    {
        public Task CalculateAsync(string userId, CaloriesCalculatorViewModel model);
    }
}
