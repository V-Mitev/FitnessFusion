namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Services.Data.Models.Exercise;
    using FitnessFusion.Web.ViewModels.Exercise;

    public interface IExerciseService
    {
        public Task AddExerciseAsync(AddExerciseModel model);

        public Task<AddExerciseModel> FindExerciseAsync(string exerciseId);

        public Task EditExerciseAsync(string id, AddExerciseModel model);

        public Task DeleteExerciseAsync(string id);

        public Task<AllExercisesModel> DetailsAsync(string id);

        public Task<bool> IsExerciseExistByIdAsync(string id);

        public Task<AllExercisesFilteredAndPagedServiceModel> AllAsync(AllExercisesQueryModel queryModel);

        public Task<ICollection<AllExercisesModel>> AlreadyCreatedAsync();

        public Task<AddExerciseModel?> AddExistingExerciseAsync(string id);
    }
}
