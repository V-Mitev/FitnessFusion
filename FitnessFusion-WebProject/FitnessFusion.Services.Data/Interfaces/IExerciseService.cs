namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.Exercise;

    public interface IExerciseService
    {
        public Task<ICollection<AllExercisesViewModel>> GetAllExercisesAsync();
    }
}
