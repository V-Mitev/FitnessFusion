namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.Exercise;
    using FitnessFusion.Web.ViewModels.TrainingPlan;

    public interface ITrainingPlanService
    {
        public Task<ICollection<AllTrainingPlansModel>> GetAllTrainingPlansAsync();

        public Task AddTrainingPlanAsync(TrainingPlanModel model, string trainerId);

        public Task EditTrainingPlanAsync(TrainingPlanModel model, string trainingPlanId, string userId);

        public Task<TrainingPlanModel> FindTrainingPlanByIdAsync(string id);

        public void AddExerciseToPlan(AddExerciseModel model, TrainingPlanModel trainingPlan);

        public Task AddExerciseToExistingPlanAsync(AddExerciseModel model, string trainingPlanId);

        public Task DeleteTrainingPlanAsync(string id);

        public Task<DetailsTrainingPlanModel> DetailsAsync(string id);

        public Task<bool> IsTrainingPlanExistByIdAsync(string id);

        public Task AddExerciseWhenEditPlan(string trainingPlanId, string exerciseId);

        public Task RemoveExerciseFromPlan(string trainingPlanId, string exerciseId);
    }
}
