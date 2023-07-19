namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    public class TrainingPlanController : Controller
    {
        private readonly ITrainingPlanService trainingPlanService;
        
        public TrainingPlanController(ITrainingPlanService trainingPlanService)
        {
            this.trainingPlanService = trainingPlanService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
