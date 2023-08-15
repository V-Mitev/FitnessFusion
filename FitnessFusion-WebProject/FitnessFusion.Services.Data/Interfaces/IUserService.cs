namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.User;

    public interface IUserService
    {
        public Task<string> GetFullNameByEmailAsyncAsync(string email);

        public Task<bool> IsUserExistByIdAsync(string userId);

        public Task<string> GetFullNameByIdAsync(string userId);

        public Task<ICollection<UserViewModel>> AllAsync();
    }
}
