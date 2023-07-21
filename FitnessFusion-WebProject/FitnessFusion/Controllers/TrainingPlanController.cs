namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.TrainingPlan;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;

    [Authorize]
    public class TrainingPlanController : Controller
    {
        private readonly ITrainingPlanService trainingPlanService;

        public TrainingPlanController(ITrainingPlanService trainingPlanService)
        {
            this.trainingPlanService = trainingPlanService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var trainingPlans = await trainingPlanService.GetAllTrainingPlansAsync();

            return View(trainingPlans);
        }

        [HttpGet]
        public IActionResult CreateTrainingPlan()
        {
            TrainingPlanViewModel model = new TrainingPlanViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrainingPlan(TrainingPlanViewModel model)
        {
            var trainerId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!ModelState.IsValid)
            {

            }

            await trainingPlanService.AddTrainingPlanAsync(model, trainerId);

            return RedirectToAction("All");
        }

        [HttpGet]
        public IActionResult AddExercise()
        {
            TrainingPlanExercises model = new TrainingPlanExercises();

            return View(model);
        }

        [HttpPost]
        public IActionResult AddExercise(TrainingPlanExercises model, TrainingPlanViewModel trainingPlan)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddExercise");
            }

            trainingPlanService.AddExerciseToTrainingPlan(model, trainingPlan);

            return RedirectToAction("Add");
        }
    }
}
