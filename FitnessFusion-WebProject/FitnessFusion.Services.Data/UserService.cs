namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Services.Data.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class UserService : IUserService
    {
        private readonly FitnessFusionDbContext dbContext;

        public UserService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;
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

        public async Task<bool> IsUserTrainerAsync(string userId)
        {
            var trainer = await dbContext.Trainers
                .FirstOrDefaultAsync(t => t.IsTrainer && t.Id.ToString() == userId);

            if (trainer == null)
            {
                return false;
            }

            return trainer!.IsTrainer;
        }
    }
}
