namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Meal;
    using Microsoft.AspNetCore.Mvc;

    public class MealController : Controller
    {
        private readonly IMealService mealService;

        public MealController(IMealService mealService)
        {
            this.mealService = mealService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var meals = await mealService.AllAsync();

            return View(meals);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddMealViewModel model = new AddMealViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddMealViewModel model)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Unexpected error");
                return RedirectToAction("Add");
            }

            await mealService.AddMealAsync(model);

            return RedirectToAction("All", "Meal");
        }
    }
}
