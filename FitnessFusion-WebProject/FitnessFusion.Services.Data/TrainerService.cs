namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Trainer;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class TrainerService : ITrainerService
    {
        private readonly FitnessFusionDbContext dbContext;

        public TrainerService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddTrainerAsync(TrainerViewModel model)
        {
            var newTrainer = new Trainer()
            {
                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.Email,
                Email = model.Email,
                Description = model.Description,
                IsTrainer = true,
                NormalizedEmail = model.Email,
                NormalizedUserName = model.Email,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var hasher = new PasswordHasher<Trainer>();

            newTrainer.PasswordHash = hasher.HashPassword(newTrainer, "123456");

            await dbContext.Trainers.AddAsync(newTrainer);

            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsEmailAlreadyAdded(string email)
        {
            return await dbContext.Trainers
                .AnyAsync(t => t.Email == email);
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

        public async Task RemoveTrainerAsync(string trainerId)
        {
            var trainer = await dbContext.Trainers
                .FirstOrDefaultAsync(t => t.IsTrainer && t.Id.ToString() == trainerId);

            if (trainer == null)
            {
                throw new NullReferenceException("Unexpected error trainer does't exist!");
            }

            dbContext.Trainers.Remove(trainer);

            await dbContext.SaveChangesAsync();
        }
    }
}
