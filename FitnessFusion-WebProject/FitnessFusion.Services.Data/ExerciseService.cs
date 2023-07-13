namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Exercise;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ExerciseService : IExerciseService
    {
        private readonly FitnessFusionDbContext dbContext;

        public ExerciseService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ICollection<AllExercisesViewModel>> GetAllExercisesAsync()
        {
            var exercises = await dbContext.Exercises
                .Select(e => new AllExercisesViewModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    Description = e.Description,
                    VideoUrl = e.VideoLink,
                    MuscleGroup = e.MuscleGroup.ToString()
                })
                .ToListAsync();

            return exercises;
        }
    }
}
