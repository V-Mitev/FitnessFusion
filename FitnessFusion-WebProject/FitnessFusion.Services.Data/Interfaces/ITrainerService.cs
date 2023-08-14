namespace FitnessFusion.Services.Data.Interfaces
{
    public interface ITrainerService
    {
        public Task<bool> IsUserTrainerAsync(string userId);
    }
}
