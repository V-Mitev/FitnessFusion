namespace FitnessFusion.Web.Controllers
{
    using Infastructure.Extensions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Services.Data.Interfaces;
    using ViewModels.CaloriesCalculator;

    [Authorize]
    public class CaloriesCalculatorController : Controller
    {
        private readonly ICaloriesCalculatorService calculatorService;

        public CaloriesCalculatorController(ICaloriesCalculatorService calculatorService)
        {
            this.calculatorService = calculatorService;
        }

        [HttpGet]
        public IActionResult Calculate()
        {
            CaloriesCalculatorViewModel model = new CaloriesCalculatorViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Calculate(CaloriesCalculatorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = User.GetId();

            await calculatorService.CalculateAsync(userId, model);

            return View(model);
        }
    }
}
