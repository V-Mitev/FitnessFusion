namespace FitnessFusion.Services.Data.Interfaces
{
    public interface IUserService
    {
        public Task<string> GetFullNameByEmailAsyncAsync(string email);

        public Task<bool> IsUserTrainer(string userId);
    }
}
