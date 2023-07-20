namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Exercise;
    using FitnessFusion.Web.ViewModels.TrainingPlan;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;

    [Authorize]
    public class TrainingPlanController : Controller
    {
        private readonly ITrainingPlanService trainingPlanService;
        private readonly IExerciseService exerciseService;

        public TrainingPlanController(ITrainingPlanService trainingPlanService, IExerciseService exerciseService)
        {
            this.trainingPlanService = trainingPlanService;
            this.exerciseService = exerciseService;
        }

        public async Task<IActionResult> All()
        {
            var trainingPlans = await trainingPlanService.GetAllTrainingPlansAsync();

            return View(trainingPlans);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            TrainingPlanViewModel model = new TrainingPlanViewModel();

            model.AvailableExercises = await GetAvailableExercises();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TrainingPlanViewModel model, string Action)
        {
            var trainerId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            model.AvailableExercises = await exerciseService.GetAllExercisesAsyncForTrainingPlan();

            if (Action == "Add Exercise" && !string.IsNullOrEmpty(model.AvailableExerciseId))
            {
                var selectedExercise = model.AvailableExercises.FirstOrDefault(e => e.Id == model.AvailableExerciseId);
                if (selectedExercise != null && !model.AddedExercises.Any(e => e.Id == model.AvailableExerciseId))
                {
                    model.AddedExercises.Add(selectedExercise);
                }

                // Изчистваме стойността на AvailableExerciseId, за да може да се добавят още упражнения
                model.AvailableExerciseId = string.Empty;
            }
            else if (Action == "Save Training Plan")
            {
                if (string.IsNullOrEmpty(model.Name) || string.IsNullOrEmpty(model.DescriptionOfExercises))
                {
                    ModelState.AddModelError(string.Empty, "Name and Description are required.");
                }
                else
                {
                    var addedExerciseIdsSet = new HashSet<string>(model.AddedExercises.Select(e => e.Id));

                    if (addedExerciseIdsSet.Count != model.AddedExercises.Count)
                    {
                        ModelState.AddModelError(string.Empty, "Cannot add duplicate exercises.");
                    }
                    else if (ModelState.IsValid)
                    {
                        await trainingPlanService.AddTrainingPlanAsync(model, trainerId);
                    }
                }
            }

            return View(model);
        }

        private async Task<ICollection<ExerciseViewModel>> GetAvailableExercises()
        {
            var exercises = await exerciseService.GetAllExercisesAsyncForTrainingPlan();

            return exercises;
        }
    }
}
