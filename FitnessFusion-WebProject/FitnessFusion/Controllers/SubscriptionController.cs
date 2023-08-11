namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.Infastructure.Extensions;
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

            await subscriptionService.AddSubscription(model, User.GetId());

            return RedirectToAction("All");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var model = await subscriptionService.GetSubscription(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit (string id, SubscriptionModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await subscriptionService.Edit(model, id);

            return RedirectToAction("All");
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var model = await subscriptionService.GetSubscription(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            await subscriptionService.DeleteSubscription(id);

            return RedirectToAction("All");
        }
    }
}
