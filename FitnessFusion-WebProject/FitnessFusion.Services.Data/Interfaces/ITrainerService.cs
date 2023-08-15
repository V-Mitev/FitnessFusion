namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.Trainer;

    public interface ITrainerService
    {
        public Task<bool> IsUserTrainerAsync(string userId);

        public Task AddTrainerAsync(TrainerViewModel model);

        public Task<bool> IsEmailAlreadyAdded(string email);
    }
}
