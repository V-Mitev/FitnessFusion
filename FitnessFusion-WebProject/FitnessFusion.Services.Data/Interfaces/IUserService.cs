namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.User;

    public interface IUserService
    {
        public Task<string> GetFullNameByEmailAsync(string email);

        public Task<bool> IsUserExistByIdAsync(string userId);

        public Task<ICollection<UserViewModel>> AllAsync();

        public Task DeleteAsync(string userId);

        public Task<ICollection<UserViewModel>> AllSubscribers();
    }
}
