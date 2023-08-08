namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.Exercise;

    public interface IExerciseService
    {
        public Task<ICollection<AllExercisesViewModel>> GetAllExercisesAsync();

        public Task AddExerciseAsync(AddExerciseViewModel model);

        public Task<AddExerciseViewModel> FindExerciseAsync(string exerciseId);

        public Task EditExerciseAsync(string id, AddExerciseViewModel model);

        public Task DeleteExerciseAsync(string id);

        public Task<ExerciseDetailsViewModel> DetailsAsync(string id);
    }
}
