namespace FitnessFusion.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Services.Data.Interfaces;
    using Web.ViewModels.Exercise;

    [Authorize]
    public class ExerciseController : Controller
    {
        private readonly IExerciseService exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            this.exerciseService = exerciseService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var exercises = await exerciseService.GetAllExercisesAsync();

            return View(exercises);
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

            await exerciseService.AddExerciseAsync(model);

            return RedirectToAction("All");
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var model = await exerciseService.DetailsAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var exercise = await exerciseService.FindExerciseAsync(id);

            return View(exercise);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, AddExerciseModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await exerciseService.EditExerciseAsync(id, model);

            return RedirectToAction("All");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            await exerciseService.DeleteExerciseAsync(id);

            return RedirectToAction("All");
        }
    }
}
