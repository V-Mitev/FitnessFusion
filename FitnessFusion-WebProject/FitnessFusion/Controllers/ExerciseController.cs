namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Data.Models.Enums;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Services.Data.Interfaces;
    using Web.ViewModels.Exercise;
    using static Common.NotificationMessagesConstant;

    [Authorize]
    public class ExerciseController : Controller
    {
        private readonly IExerciseService exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            this.exerciseService = exerciseService;
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
        public IActionResult Add()
        {
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
            var exerciseExist = await exerciseService.IsExerciseExistByIdAsync(id);

            if (!exerciseExist)
            {
                TempData[ErrorMessage] = "Exercise with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                await exerciseService.DeleteExerciseAsync(id);

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
