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
        private readonly IUserService userService;

        public TrainingPlanController(
            ITrainingPlanService trainingPlanService, IUserService userService)
        {
            this.trainingPlanService = trainingPlanService;
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

            if (trainingPlan != null)
            {
                HttpContext.Session.Remove("TrainingPlan");
            }

            var trainingPlans = await trainingPlanService.GetAllTrainingPlansAsync();

            return View(trainingPlans);
        }

        [HttpGet]
        public async Task<IActionResult> CreateTrainingPlanAsync()
        {
            var userExist = await userService.IsUserExistByIdAsync(User.GetId());

            if (!userExist)
            {
                TempData[ErrorMessage] = "User with provided id does not exist! Please try again!"; ;

                return RedirectToAction("CreateTrainingPlan");
            }

            var model = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

            if (model == null)
            {
                model = new TrainingPlanModel();

                HttpContext.Session.SetObject("TrainingPlan", model);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrainingPlan(TrainingPlanModel model)
        {
            var sessionTrainingPlan = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan")!;

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

            var userExist = await userService.IsUserExistByIdAsync(User.GetId());

            if (!userExist)
            {
                TempData[ErrorMessage] = "User with provided id does not exist! Please try again!"; ;

                return RedirectToAction("CreateTrainingPlan");
            }

            try
            {
                var userId = User.GetId();

                model.AddedExercises.AddRange(sessionTrainingPlan.AddedExercises);

                await trainingPlanService.AddTrainingPlanAsync(model, userId);

                HttpContext.Session.Remove("TrainingPlan");

                return RedirectToAction("All");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public IActionResult AddExercise()
        {
            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

            if (trainingPlan == null)
            {
                TempData[ErrorMessage] = "Please create training plan then add exercises!";

                return RedirectToAction("CreateTrainingPlan");
            }

            TrainingPlanExercisesModel model = new TrainingPlanExercisesModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddExercise(TrainingPlanExercisesModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

            if (trainingPlan == null)
            {
                TempData[ErrorMessage] = "Please create training plan then add exercises!";

                return RedirectToAction("All");
            }

            // This check is when training plan is already created to can add exercises.
            if (!string.IsNullOrEmpty(trainingPlan.Id))
            {
                var isExerciseAlreadyCreated = await trainingPlanService.IsExercisesAlreadyCreatedAsync(trainingPlan.Id, model.Name);

                if (isExerciseAlreadyCreated)
                {
                    TempData[ErrorMessage] = "You already create this exercise";

                    return View(model);
                }

                await trainingPlanService.AddExerciseToExistingPlanAsync(model, trainingPlan.Id);

                HttpContext.Session.SetObject("TrainingPlan", trainingPlan);

                return RedirectToAction("EditTrainingPlan", new { trainingPlan.Id });
            }

            try
            {
                trainingPlanService.AddExerciseToPlan(model, trainingPlan);

                HttpContext.Session.SetObject("TrainingPlan", trainingPlan);

                return RedirectToAction("CreateTrainingPlan");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditTrainingPlan(string id)
        {
            var trainingPlanExist = await trainingPlanService.IsTrainingPlanExistByIdAsync(id);

            if (!trainingPlanExist)
            {
                TempData[ErrorMessage] = "Training plan with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                var model = await trainingPlanService.FindTrainingPlanByIdAsync(id);

                HttpContext.Session.SetObject("TrainingPlan", model);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditTrainingPlan(TrainingPlanModel model, string tpId)
        {
            var userExist = await userService.IsUserExistByIdAsync(User.GetId());

            if (!userExist)
            {
                TempData[ErrorMessage] = "User with provided id does not exist! Please try again!"; ;

                return RedirectToAction("CreateTrainingPlan");
            }

            var isTrainingPlanExist = await trainingPlanService.IsTrainingPlanExistByIdAsync(tpId);

            if (!isTrainingPlanExist)
            {
                TempData[ErrorMessage] = "Training plan with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var tpExercisesSession = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan")!;

            model.AddedExercises = tpExercisesSession.AddedExercises;

            var userId = User.GetId();

            try
            {
                await trainingPlanService.EditTrainingPlanAsync(model, tpId, userId);

                HttpContext.Session.Remove("TrainingPlan");

                return RedirectToAction("All");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTrainingPlan(string id)
        {
            var isTrainingPlanExist = await trainingPlanService.IsTrainingPlanExistByIdAsync(id);

            if (!isTrainingPlanExist)
            {
                TempData[ErrorMessage] = "Training plan with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                await trainingPlanService.DeleteTrainingPlanAsync(id);

                return RedirectToAction("All");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var isTrainingPlanExist = await trainingPlanService.IsTrainingPlanExistByIdAsync(id);

            if (!isTrainingPlanExist)
            {
                TempData[ErrorMessage] = "Training plan with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                var model = await trainingPlanService.DetailsAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditExercise(string id)
        {
            var exerciseExistInPlan = 
                await trainingPlanService.IsExerciseExistInTrainingPlanAsync(id);

            if (!exerciseExistInPlan)
            {
                TempData[ErrorMessage] = "Exercise with provided id does not exist! Please try again!";

                return RedirectToAction("EditTrainingPlan");
            }

            try
            {
                var model = await trainingPlanService.FindTrainingPlanExerciseAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditExercise(string id, TrainingPlanExercisesModel exercisesTp)
        {
            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

            if (trainingPlan == null)
            {
                TempData[ErrorMessage] = "Training plan does not exist! Please try again!";

                return RedirectToAction("All");
            }

            var trainingPlanExist = await trainingPlanService.IsTrainingPlanExistByIdAsync(trainingPlan.Id!.ToString());

            if (!trainingPlanExist)
            {
                TempData[ErrorMessage] = "Training plan with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            var exerciseExistInPlan = 
                await trainingPlanService.IsExerciseExistInTrainingPlanAsync(id);

            if (!exerciseExistInPlan)
            {
                TempData[ErrorMessage] = "Exercise with provided id does not exist! Please try again!";

                return RedirectToAction("EditTrainingPlan");
            }

            if (!ModelState.IsValid)
            {
                return View(exercisesTp);
            }

            try
            {
                await trainingPlanService.EditTrainingPlanExerciseAsync(id, exercisesTp);

                return RedirectToAction("EditTrainingPlan", new { trainingPlan.Id });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteExercise(string id)
        {
            var exerciseExistInPlan = 
                await trainingPlanService.IsExerciseExistInTrainingPlanAsync(id);

            if (!exerciseExistInPlan)
            {
                TempData[ErrorMessage] = "Exercise with provided id does not exist! Please try again!";

                return RedirectToAction("EditTrainingPlan");
            }

            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

            if (trainingPlan == null)
            {
                TempData[ErrorMessage] = "Training plan does not exist! Please try again!";

                return RedirectToAction("All");
            }

            var trainingPlanExist = await trainingPlanService.IsTrainingPlanExistByIdAsync(trainingPlan.Id!.ToString());

            if (!trainingPlanExist)
            {
                TempData[ErrorMessage] = "Training plan with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            if (trainingPlan.AddedExercises.Count == 1)
            {
                TempData[ErrorMessage] = "You need to have minimum one exercise in training plan!";

                return RedirectToAction("EditTrainingPlan", new { id = trainingPlan.Id });
            }

            try
            {
                await trainingPlanService.DeleteExerciseInTrainingPlanAsync(id);

                return RedirectToAction("EditTrainingPlan", new { id = trainingPlan.Id });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] =
                "Unexpected error occurred! Please try again later or contact administrator";

            return RedirectToAction("Index", "Home");
        }
    }
}
