namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.TrainingPlan;

    public interface ITrainingPlanService
    {
        public Task<ICollection<AllTrainingPlansViewModel>> GetAllTrainingPlansAsync();

        public Task AddTrainingPlanAsync(TrainingPlanViewModel model, string trainerId);
    }
}
