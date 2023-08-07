namespace FitnessFusion.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services.Data.Interfaces;
    using Web.ViewModels.Meal;

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
                return View();
            }

            await mealService.AddMealAsync(model);

            return RedirectToAction("All", "Meal");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            await mealService.DeleteMealAsync(id);

            return RedirectToAction("All", "Meal");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var meal = await mealService.FindMealAsync(id);

            return View(meal);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, AddMealViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await mealService.EditMealAsync(id, model);

            return RedirectToAction("All");
        }
    }
}
