namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Data.Models.Enums;
    using FitnessFusion.Web.Infastructure.Extensions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Services.Data.Interfaces;
    using Web.ViewModels.Exercise;
    using static Common.NotificationMessagesConstant;

    [Authorize]
    public class ExerciseController : Controller
    {
        private readonly IExerciseService exerciseService;
        private readonly ITrainerService trainerService;

        public ExerciseController(IExerciseService exerciseService, ITrainerService trainerService)
        {
            this.exerciseService = exerciseService;
            this.trainerService = trainerService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllExercisesQueryModel queryModel)
        {
            queryModel.MusclesGroups = Enum.GetValues<MuscleGroups>();

            var serviceModel = await exerciseService.AllAsync(queryModel);

            queryModel.Exercises = serviceModel.Exercises;

            queryModel.TotalExercises = serviceModel.TotalExerciseCount;

            return View(queryModel);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if (!User.IsAdmin() && !await trainerService.IsUserTrainerAsync(User.GetId()))
            {
                TempData[ErrorMessage] = "Only trainers and administators can add exercises!";

                return RedirectToAction("Index", "Home");
            }

            AddExerciseModel model = new AddExerciseModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddExerciseModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            try
            {
                await exerciseService.AddExerciseAsync(model);

                TempData[SuccessMessage] = "You have successfully added an exercise";

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
            var exerciseExist = await exerciseService.IsExerciseExistByIdAsync(id);

            if (!exerciseExist)
            {
                TempData[ErrorMessage] = "Exercise with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                var model = await exerciseService.DetailsAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (!User.IsAdmin() && !await trainerService.IsUserTrainerAsync(User.GetId()))
            {
                TempData[ErrorMessage] = "Only trainers and administators can edit exercises!";

                return RedirectToAction("Index", "Home");
            }

            var exerciseExist = await exerciseService.IsExerciseExistByIdAsync(id);

            if (!exerciseExist)
            {
                TempData[ErrorMessage] = "Exercise with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                var exercise = await exerciseService.FindExerciseAsync(id);

                return View(exercise);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, AddExerciseModel model)
        {
            var exerciseExist = await exerciseService.IsExerciseExistByIdAsync(id);

            if (!exerciseExist)
            {
                TempData[ErrorMessage] = "Exercise with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await exerciseService.EditExerciseAsync(id, model);

                TempData[SuccessMessage] = "You have successfully edit an exercise";

                return RedirectToAction("All");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            if (!User.IsAdmin() && !await trainerService.IsUserTrainerAsync(User.GetId()))
            {
                TempData[ErrorMessage] = "Only trainers and administators can delete exercises!";

                return RedirectToAction("Index", "Home");
            }

            var exerciseExist = await exerciseService.IsExerciseExistByIdAsync(id);

            if (!exerciseExist)
            {
                TempData[ErrorMessage] = "Exercise with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                await exerciseService.DeleteExerciseAsync(id);

                TempData[SuccessMessage] = "You have successfully deleted an exercise";

                return RedirectToAction("All");
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
