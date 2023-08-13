namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.TrainingPlan;

    public interface ITrainingPlanService
    {
        public Task<ICollection<AllTrainingPlansModel>> GetAllTrainingPlansAsync();

        public Task AddTrainingPlanAsync(TrainingPlanModel model, string trainerId);

        public Task EditTrainingPlanAsync(TrainingPlanModel model, string trainingPlanId, string userId);

        public Task<TrainingPlanModel> FindTrainingPlanByIdAsync(string id);

        public void AddExerciseToPlan(TrainingPlanExercisesModel model, TrainingPlanModel trainingPlan);

        public Task AddExerciseToExistingPlanAsync(TrainingPlanExercisesModel model, string trainingPlanId);

        public Task<bool> IsExercisesAlreadyCreatedAsync(string trainingPlanId, string exerciseName);

        public Task DeleteTrainingPlanAsync(string id);

        public Task<DetailsTrainingPlanModel> DetailsAsync(string id);

        public Task<TrainingPlanExercisesModel> FindTrainingPlanExerciseAsync(string id);

        public Task EditTrainingPlanExerciseAsync(string id, TrainingPlanExercisesModel model);

        public Task DeleteExerciseInTrainingPlanAsync(string id);

        public Task<bool> IsTrainingPlanExistByIdAsync(string id);

        public Task<bool> IsExerciseExistInTrainingPlanAsync(string id);
    }
}
