namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.Infastructure.Extensions;
    using FitnessFusion.Web.ViewModels.TrainingPlan;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using NuGet.Packaging;
    using static FitnessFusion.Common.NotificationMessagesConstant;

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
            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan");

            if (trainingPlan != null)
            {
                HttpContext.Session.Remove("TrainingPlan");
            }

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
            var sessionTrainingPlan = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan")!;

            if (!sessionTrainingPlan.AddedExercises.Any())
            {
                TempData[ErrorMessage] = "Please add some exercises then create training plan.";

                sessionTrainingPlan.Name = model.Name;

                HttpContext.Session.SetObject("TrainingPlan", sessionTrainingPlan);

                return RedirectToAction("CreateTrainingPlan");
            }

            if (!ModelState.IsValid)
            {
                HttpContext.Session.SetObject("TrainingPlan", sessionTrainingPlan);
                return View(model);
            }

            var userId = User.GetId();

            model.AddedExercises.AddRange(sessionTrainingPlan.AddedExercises);

            await trainingPlanService.AddTrainingPlanAsync(model, userId);

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
                return View(model);
            }

            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan")!;

            // This check is when training plan is already created to can add exercises.
            if (!string.IsNullOrEmpty(trainingPlan.Id))
            {
                await trainingPlanService.AddExerciseToExistingPlanAsync(model, trainingPlan.Id);

                HttpContext.Session.SetObject("TrainingPlan", trainingPlan);

                return RedirectToAction("EditTrainingPlan", new { trainingPlan.Id });
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
                return View(model);
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

        [HttpGet]
        public async Task<IActionResult> EditExercise(string id)
        {
            var model = await trainingPlanService.FindTrainingPlanExerciseAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditExercise(string id, TrainingPlanExercises exercisesTp)
        {
            if (!ModelState.IsValid)
            {
                return View(exercisesTp);
            }

            await trainingPlanService.EditTrainingPlanExerciseAsync(id, exercisesTp);

            var tpId = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan");

            return RedirectToAction("EditTrainingPlan", new { tpId!.Id });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteExercise(string id)
        {
            var tpId = HttpContext.Session.GetObject<TrainingPlanViewModel>("TrainingPlan");

            if (tpId != null && tpId.AddedExercises.Count == 1)
            {
                TempData[ErrorMessage] = "You need to have minimum one exercise";

                return RedirectToAction("EditTrainingPlan", new { id = tpId!.Id });
            }

            await trainingPlanService.DeleteExerciseInTrainingPlanAsync(id);

            return RedirectToAction("EditTrainingPlan", new { id = tpId!.Id });
        }
    }
}
