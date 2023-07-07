namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.CaloriesCalculator;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;

    [Authorize]
    public class CaloriesCalculatorController : Controller
    {
        private readonly ICaloriesCalculatorService calculatorService;

        public CaloriesCalculatorController(ICaloriesCalculatorService calculatorService)
        {
            this.calculatorService = calculatorService;
        }

        [HttpGet]
        public IActionResult CalculateAsync()
        {
            CaloriesCalculatorViewModel model = new CaloriesCalculatorViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Calculate(CaloriesCalculatorViewModel model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            await calculatorService.CalculateAsync(userId, model);

            return View(model );
        }
    }
}
