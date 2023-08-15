namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.User;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class UserService : IUserService
    {
        private readonly FitnessFusionDbContext dbContext;

        public UserService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ICollection<UserViewModel>> AllAsync()
        {
            var allUsers = await dbContext.ApplicationUsers
                .Select(u => new UserViewModel()
                {
                    Email = u.Email,
                    FullName = u.FirstName + " " + u.LastName,
                    IsTrainer = u.IsTrainer
                })
                .ToListAsync();

            return allUsers;
        }

        public async Task<string> GetFullNameByEmailAsyncAsync(string email)
        {
            var user = await dbContext
                .Users
                .FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
            {
                return string.Empty;
            }

            return $"{user.FirstName} {user.LastName}";
        }

        public async Task<string> GetFullNameByIdAsync(string userId)
        {
            var user = await dbContext.Users
                .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user == null)
            {
                return string.Empty;
            }

            return $"{user.FirstName} {user.LastName}";
        }

        public async Task<bool> IsUserExistByIdAsync(string userId)
        {
            var result = await dbContext.ApplicationUsers
                .AnyAsync(u => u.Id.ToString() == userId);

            return result;
        }
    }
}
