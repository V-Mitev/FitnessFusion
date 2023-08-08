namespace FitnessFusion.Services.Data.Interfaces
{
    using FitnessFusion.Web.ViewModels.TrainingPlan;

    public interface ITrainingPlanService
    {
        public Task<ICollection<AllTrainingPlansViewModel>> GetAllTrainingPlansAsync();

        public Task AddTrainingPlanAsync(TrainingPlanViewModel model, string trainerId);

        public Task EditTrainingPlanAsync(TrainingPlanViewModel model, string trainingPlanId);

        public Task<TrainingPlanViewModel> FindTrainingPlanByIdAsync(string id);

        public void AddExerciseToPlan(TrainingPlanExercises model, TrainingPlanViewModel trainingPlan);

        public Task AddExerciseToExistingPlanAsync(TrainingPlanExercises model, string trainingPlanId);

        public Task<bool> IsExercisesAlreadyCreated(string trainingPlanId, string exerciseName);

        public Task DeleteTrainingPlanAsync(string id);

        public Task<DetailsTrainingPlanViewModel> DetailsAsync(string id);

        public Task<TrainingPlanExercises> FindTrainingPlanExerciseAsync(string id);

        public Task EditTrainingPlanExerciseAsync(string id, TrainingPlanExercises model);

        public Task DeleteExerciseInTrainingPlanAsync(string id);
    }
}
