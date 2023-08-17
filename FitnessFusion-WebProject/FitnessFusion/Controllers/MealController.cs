namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Web.Infastructure.Extensions;
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
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "Only administators can add meals!";

                return RedirectToAction("Index", "Home");
            }

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

                TempData[SuccessMessage] = "You have successfully add the meal";

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
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "Only administators can delete meals!";

                return RedirectToAction("Index", "Home");
            }

            var mealExist = await mealService.IsMealExistByIdAsync(id);

            if (!mealExist)
            {
                TempData[ErrorMessage] = "Meal with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                await mealService.DeleteMealAsync(id);

                TempData[SuccessMessage] = "You have successfully delete the meal";

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
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "Only administators can edit meals!";

                return RedirectToAction("Index", "Home");
            }

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

                TempData[SuccessMessage] = "You have successfully edit the meal";

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
