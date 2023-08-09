namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.Exercise;

    public interface IExerciseService
    {
        public Task<ICollection<AllExercisesModel>> GetAllExercisesAsync();

        public Task AddExerciseAsync(AddExerciseModel model);

        public Task<AddExerciseModel> FindExerciseAsync(string exerciseId);

        public Task EditExerciseAsync(string id, AddExerciseModel model);

        public Task DeleteExerciseAsync(string id);

        public Task<ExerciseDetailsModel> DetailsAsync(string id);
    }
}
