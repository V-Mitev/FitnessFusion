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
            var model = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan");

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

            var sessionTrainingPlan = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan")!;

            sessionTrainingPlan.Name = model.Name;
            sessionTrainingPlan.Image = model.Image;

            if (!ModelState.IsValid)
            {
                HttpContext.Session.SetObject("TrainingPlan", sessionTrainingPlan);
                return View(model);
            }

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
        public async Task<IActionResult> AddExercise(TrainingPlanExercises model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddExercise");
            }

            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan")!;

            if (!string.IsNullOrEmpty(trainingPlan.Id))
            {
                await trainingPlanService.AddExerciseToExistingPlanAsync(model, trainingPlan.Id);

                HttpContext.Session.SetObject("TrainingPlan", trainingPlan);

                return RedirectToAction("EditTrainingPlan", new {trainingPlan.Id});
            }

            trainingPlanService.AddExerciseToPlan(model, trainingPlan);

            HttpContext.Session.SetObject("TrainingPlan", trainingPlan);

            return RedirectToAction("CreateTrainingPlan");
        }

        [HttpGet]
        public async Task<IActionResult> EditTrainingPlan(string id)
        {
            var model = await trainingPlanService.FindTrainingPlanByIdAsync(id);

            HttpContext.Session.SetObject("TrainingPlan", model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditTrainingPlan(TrainingPlanViewModel model, string id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("EditTrainingPlan");
            }

            var exercises = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan")!;

            model.AddedExercises = exercises.AddedExercises;

            await trainingPlanService.EditTrainingPlanAsync(model, id);

            HttpContext.Session.Remove("TrainingPlan");

            return RedirectToAction("All");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTrainingPlan(string id)
        {
            await trainingPlanService.DeleteTrainingPlanAsync(id);

            return RedirectToAction("All");
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var model = await trainingPlanService.DetailsAsync(id);

            return View(model);
        }
    }
}
