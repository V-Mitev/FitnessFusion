namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.Meal;

    public interface IMealService
    {
        public Task<ICollection<AllMealsModel>> AllAsync();

        public Task AddMealAsync(AddMealModel meal);

        public Task DeleteMealAsync(string mealId);

        public Task<AddMealModel> FindMealAsync(string mealId);

        public Task EditMealAsync(string mealId, AddMealModel model);
    }
}
