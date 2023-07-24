namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.Infastructure.Extensions;
    using FitnessFusion.Web.ViewModels.TrainingPlan;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;


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
            TrainingPlanViewModel? model = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan");

            if (model == null)
            {
                model = new TrainingPlanViewModel();

                HttpContext.Session.SetObject("TrainingPlan", model);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrainingPlan(TrainingPlanViewModel model)
        {
            var userId = User.GetId();

            if (!ModelState.IsValid)
            {
                HttpContext.Session.SetObject("TrainingPlan", model);
                return View(model);
            }

            var sessionTrainingPlan = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan")!;

            sessionTrainingPlan.Name = model.Name;
            sessionTrainingPlan.Image = model.Image;

            await trainingPlanService.AddTrainingPlanAsync(sessionTrainingPlan, userId);

            HttpContext.Session.Remove("TrainingPlan");

            return RedirectToAction("All");
        }

        [HttpGet]
        public IActionResult AddExercise()
        {
            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan");

            if (trainingPlan == null)
            {
                return RedirectToAction("CreateTrainingPlan");
            }

            TrainingPlanExercises model = new TrainingPlanExercises();

            return View(model);
        }

        [HttpPost]
        public IActionResult AddExercise(TrainingPlanExercises model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddExercise");
            }

            TrainingPlanViewModel trainingPlan = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan")!;

            trainingPlan.AddedExercises!.Add(model);

            HttpContext.Session.SetObject("TrainingPlan", trainingPlan);

            return RedirectToAction("CreateTrainingPlan");
        }
    }
}
