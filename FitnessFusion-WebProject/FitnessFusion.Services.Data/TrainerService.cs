namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Services.Data.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class TrainerService : ITrainerService
    {
        private readonly FitnessFusionDbContext dbContext;

        public TrainerService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;
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
