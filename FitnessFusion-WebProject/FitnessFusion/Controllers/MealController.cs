namespace FitnessFusion.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services.Data.Interfaces;
    using Web.ViewModels.Meal;
    using static Common.NotificationMessagesConstant;

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
            AddMealModel model = new AddMealModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddMealModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await mealService.AddMealAsync(model);

                return RedirectToAction("All", "Meal");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var mealExist = await mealService.IsMealExistByIdAsync(id);

            if (!mealExist)
            {
                TempData[ErrorMessage] = "Meal with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                await mealService.DeleteMealAsync(id);

                return RedirectToAction("All", "Meal");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var mealExist = await mealService.IsMealExistByIdAsync(id);

            if (!mealExist)
            {
                TempData[ErrorMessage] = "Meal with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                var meal = await mealService.FindMealAsync(id);

                return View(meal);
            }
            catch (Exception)
            {

                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, AddMealModel model)
        {
            var mealExist = await mealService.IsMealExistByIdAsync(id);

            if (!mealExist)
            {
                TempData[ErrorMessage] = "Meal with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await mealService.EditMealAsync(id, model);

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
