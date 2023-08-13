namespace FitnessFusion.Services.Data.Interfaces
{
    public interface IUserService
    {
        public Task<string> GetFullNameByEmailAsyncAsync(string email);

        public Task<bool> IsUserTrainerAsync(string userId);

        public Task<bool> IsUserExistByIdAsync(string userId);
    }
}
