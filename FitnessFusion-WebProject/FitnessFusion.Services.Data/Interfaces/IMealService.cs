namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.Meal;

    public interface IMealService
    {
        public Task<ICollection<AllMealsViewModel>> AllAsync();

        public Task AddMealAsync(AddMealViewModel meal);
    }
}
