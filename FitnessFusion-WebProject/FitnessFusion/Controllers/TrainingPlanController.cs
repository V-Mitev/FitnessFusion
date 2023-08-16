namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.Infastructure.Extensions;
    using FitnessFusion.Web.ViewModels.Exercise;
    using FitnessFusion.Web.ViewModels.TrainingPlan;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using NuGet.Packaging;
    using static FitnessFusion.Common.NotificationMessagesConstant;

    [Authorize]
    public class TrainingPlanController : Controller
    {
        private readonly ITrainingPlanService trainingPlanService;
        private readonly IExerciseService exerciseService;
        private readonly ITrainerService trainingerService;
        private readonly ISubscriptionService subscriptionService;

        public TrainingPlanController(
            ITrainingPlanService trainingPlanService,
            IExerciseService exerciseService,
            ITrainerService trainingerService,
            ISubscriptionService subscriptionService)
        {
            this.trainingPlanService = trainingPlanService;
            this.exerciseService = exerciseService;
            this.trainingerService = trainingerService;
            this.subscriptionService = subscriptionService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var a = await subscriptionService.IsSubscribeValidAsync(User.GetId());

            if (!await subscriptionService.IsSubscribeValidAsync(User.GetId()) &&
                !await trainingerService.IsUserTrainerAsync(User.GetId()) &&
                !User.IsAdmin())
            {
                TempData[ErrorMessage] = "You need to be trainer or subscriber to can see training plans!";

                return RedirectToAction("Index", "Home");
            }

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
            if (!await trainingerService.IsUserTrainerAsync(User.GetId()))
            {
                TempData[ErrorMessage] = "Only trainers can add training plan!";

                return RedirectToAction("Index", "Home");
            }

            var model = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

            var alreadyCreatedExercises = await exerciseService.AlreadyCreatedAsync();

            if (model == null)
            {
                model = new TrainingPlanModel();

                foreach (var exercise in await exerciseService.AlreadyCreatedAsync())
                {
                    model.AlreadyCreatedExercises.Add(Guid.Parse(exercise.Id), exercise.Name);
                }

                HttpContext.Session.SetObject("TrainingPlan", model);
            }

            // If new exercise is added in database to update collection to can't add it twice
            if (alreadyCreatedExercises.Count > model.AlreadyCreatedExercises.Count)
            {
                foreach (var exercise in await exerciseService.AlreadyCreatedAsync())
                {
                    model.AlreadyCreatedExercises.Add(Guid.Parse(exercise.Id), exercise.Name);
                }

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

        [HttpPost]
        public async Task<IActionResult> AddExistingExercise(string exerciseKey)
        {
            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

            var exercise = await exerciseService.AddExistingExerciseAsync(exerciseKey);

            if (exercise == null)
            {
                TempData[ErrorMessage] = "Exercise with provided id does not exist! Please try again!";

                return RedirectToAction("CreateTrainingPlan");
            }

            if (trainingPlan!.AddedExercises
                .Any(e => e.Id == exercise.Id && e.Name == exercise.Name))
            {
                TempData[ErrorMessage] = $"You already added {exercise.Name} in training plan!";

                return RedirectToAction("CreateTrainingPlan");
            }

            trainingPlan!.AddedExercises.Add(exercise);

            HttpContext.Session.SetObject("TrainingPlan", trainingPlan);

            return RedirectToAction("CreateTrainingPlan");
        }

        [HttpGet]
        public async Task<IActionResult> AddExerciseAsync()
        {
            if (!await trainingerService.IsUserTrainerAsync(User.GetId()))
            {
                TempData[ErrorMessage] = "Only trainers can add exercises to training plan!";

                return RedirectToAction("Index", "Home");
            }

            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

            if (trainingPlan == null)
            {
                TempData[ErrorMessage] = "Please create training plan then add exercises!";

                return RedirectToAction("CreateTrainingPlan");
            }

            var model = new AddExerciseModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddExercise(AddExerciseModel model)
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

            var alreadyCreatedExercises = await exerciseService.AlreadyCreatedAsync();

            // This check is when training plan is already created to can add exercises.
            if (!string.IsNullOrWhiteSpace(trainingPlan.Id))
            {
                if (alreadyCreatedExercises
                    .Any(e => e.Name == model.Name && e.MuscleGroup == model.MuscleGroup.ToString()))
                {
                    TempData[ErrorMessage] = $"You already created {model.Name} for this muscle group!";

                    return View(model);
                }

                await trainingPlanService.AddExerciseToExistingPlanAsync(model, trainingPlan.Id);

                HttpContext.Session.SetObject("TrainingPlan", trainingPlan);

                return RedirectToAction("EditTrainingPlan", new { trainingPlan.Id });
            }


            if (alreadyCreatedExercises
                .Any(e => e.Name == model.Name && e.MuscleGroup == model.MuscleGroup.ToString()))
            {
                TempData[ErrorMessage] = $"You already created {model.Name} for this muscle group!";

                return RedirectToAction("CreateTrainingPlan");
            }

            if (trainingPlan.AddedExercises
                .Any(e => e.Name == model.Name && e.MuscleGroup == model.MuscleGroup))
            {
                TempData[ErrorMessage] = $"You already added this {model.Name} for this muscle group!";

                return RedirectToAction("CreateTrainingPlan");
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
            if (!await trainingerService.IsUserTrainerAsync(User.GetId()))
            {
                TempData[ErrorMessage] = "Only trainers can edit training plan!";

                return RedirectToAction("Index", "Home");
            }

            var trainingPlanExist = await trainingPlanService.IsTrainingPlanExistByIdAsync(id);

            if (!trainingPlanExist)
            {
                TempData[ErrorMessage] = "Training plan with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                var model = await trainingPlanService.FindTrainingPlanByIdAsync(id);

                foreach (var exercise in await exerciseService.AlreadyCreatedAsync())
                {
                    model.AlreadyCreatedExercises.Add(Guid.Parse(exercise.Id), exercise.Name);
                }

                HttpContext.Session.SetObject("TrainingPlan", model);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditTrainingPlan(TrainingPlanModel model, string id)
        {
            var isTrainingPlanExist = await trainingPlanService.IsTrainingPlanExistByIdAsync(id);

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
                await trainingPlanService.EditTrainingPlanAsync(model, id, userId);

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
            if (!await trainingerService.IsUserTrainerAsync(User.GetId()))
            {
                TempData[ErrorMessage] = "Only trainers can edit exercises in training plan!";

                return RedirectToAction("Index", "Home");
            }

            var exerciseExistInPlan =
                await exerciseService.IsExerciseExistByIdAsync(id);

            if (!exerciseExistInPlan)
            {
                var trainingPlan = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

                TempData[ErrorMessage] = "Exercise with provided id does not exist! Please try again!";

                return RedirectToAction("EditTrainingPlan", new { trainingPlan!.Id });
            }

            try
            {
                var model = await exerciseService.FindExerciseAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditExercise(string id, AddExerciseModel exercisesTp)
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

            var isExerciseExist =
                await exerciseService.IsExerciseExistByIdAsync(id);

            if (!isExerciseExist)
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
                await exerciseService.EditExerciseAsync(id, exercisesTp);

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
            if (!await trainingerService.IsUserTrainerAsync(User.GetId()))
            {
                TempData[ErrorMessage] = "Only trainers can delete exercises in training plan!";

                return RedirectToAction("Index", "Home");
            }

            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

            var isExerciseExist =
                await exerciseService.IsExerciseExistByIdAsync(id);

            if (!isExerciseExist)
            {
                TempData[ErrorMessage] = "Exercise with provided id does not exist! Please try again!";

                return RedirectToAction("EditTrainingPlan", new { trainingPlan!.Id });
            }

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
                var exerciseToDelete = await exerciseService.FindExerciseAsync(id);

                await trainingPlanService.RemoveExerciseFromPlan(trainingPlan.Id, id);

                return RedirectToAction("EditTrainingPlan", new { id = trainingPlan.Id });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddExistingExerciseInEditAction(string exerciseKey)
        {
            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

            var exercise = await exerciseService.AddExistingExerciseAsync(exerciseKey);

            if (exercise == null)
            {
                TempData[ErrorMessage] = "Exercise with provided id does not exist! Please try again!";

                return RedirectToAction("CreateTrainingPlan");
            }

            if (trainingPlan!.AddedExercises
                .Any(e => e.Id!.ToLower() == exercise.Id!.ToLower() && 
                e.Name.ToLower() == exercise.Name.ToLower()))
            {
                TempData[ErrorMessage] = $"You already added {exercise.Name} in training plan!";

                return RedirectToAction("CreateTrainingPlan");
            }

            await trainingPlanService.AddExerciseWhenEditPlan(trainingPlan.Id!, exerciseKey);

            HttpContext.Session.SetObject("TrainingPlan", trainingPlan);

            return RedirectToAction("EditTrainingPlan", new { trainingPlan.Id });
        }

        [HttpPost]
        public IActionResult RemoveExerciseFromPlan(string exerciseName)
        {
            var trainingPlan = HttpContext.Session.GetObject<TrainingPlanModel>("TrainingPlan");

            if (trainingPlan == null)
            {
                TempData[ErrorMessage] = "Training plan does't exist!";

                return RedirectToAction("All");
            }

            var exercise = trainingPlan.AddedExercises
                .FirstOrDefault(e => e.Name == exerciseName);

            if (exercise == null)
            {
                TempData[ErrorMessage] = "Exercise is not added in plan!";

                return RedirectToAction("CreateTrainingPlan");
            }

            trainingPlan.AddedExercises.Remove(exercise);

            if (trainingPlan.AddedExercises.Count == 0)
            {
                TempData[WarningMessage] = "If you want to create training plan you need to have 1 exercise minimum!";
            }

            HttpContext.Session.SetObject("TrainingPlan", trainingPlan);

            return RedirectToAction("CreateTrainingPlan");
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] =
                "Unexpected error occurred! Please try again later or contact administrator";

            return RedirectToAction("Index", "Home");
        }
    }
}
