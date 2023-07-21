namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Data.Models;
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.TrainingPlan;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class TrainingPlanService : ITrainingPlanService
    {
        private readonly FitnessFusionDbContext dbContext;

        public TrainingPlanService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddExerciseToTrainingPlan(TrainingPlanExercises model, TrainingPlanViewModel trainingPlan)
        {
            trainingPlan.AddedExercises.Add(model);
        }

        public async Task AddTrainingPlanAsync(TrainingPlanViewModel model, string trainerId)
        {
            var exercisesToAdd = model.AddedExercises
                .Select(e => new Exercise()
                {
                    Name = e.Name,
                    Description = e.Description,
                    VideoLink = e.VideoLink,
                    MuscleGroup = e.MuscleGroup
                })
                .ToList();

            TrainingPlan trainingPlan = new TrainingPlan()
            {
                Name = model.Name,
                TrainerId = Guid.Parse(trainerId),
                Exercises =  exercisesToAdd
            };

            await dbContext.TrainingPlans.AddAsync(trainingPlan);

            await dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<AllTrainingPlansViewModel>> GetAllTrainingPlansAsync()
        {
            var trainingPlans = await dbContext.TrainingPlans
                .Select(tp => new AllTrainingPlansViewModel()
                {
                    Id = tp.Id.ToString(),
                    Name = tp.Name,
                    Trainer = $"{tp.Trainer.FirstName} {tp.Trainer.LastName}",
                    Image = tp.Image
                })
                .ToListAsync();

            return trainingPlans;
        }
    }
}
