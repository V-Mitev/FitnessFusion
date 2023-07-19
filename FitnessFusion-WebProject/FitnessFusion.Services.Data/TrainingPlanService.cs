namespace FitnessFusion.Services.Data
{
    using FitnessFusion.Data;
    using FitnessFusion.Services.Data.Interfaces;

    public class TrainingPlanService : ITrainingPlanService
    {
        private readonly FitnessFusionDbContext dbContext;

        public TrainingPlanService(FitnessFusionDbContext dbContext)
        {
            this.dbContext = dbContext;   
        }


    }
}
