namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Subscription;
    using Microsoft.AspNetCore.Mvc;

    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionService subscriptionService;

        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            this.subscriptionService = subscriptionService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var subscriptions = await subscriptionService.GetAllSubscriptions();

            return View(subscriptions);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new SubscriptionModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SubscriptionModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("All");
        }
    }
}
