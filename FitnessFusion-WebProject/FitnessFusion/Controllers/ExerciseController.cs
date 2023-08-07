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
            AddExerciseViewModel model = new AddExerciseViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddExerciseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await exerciseService.AddExerciseAsync(model);

            return RedirectToAction("All");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var exercise = await exerciseService.FindExerciseAsync(id);

            return View(exercise);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, AddExerciseViewModel model)
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
