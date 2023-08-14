namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.Infastructure.Extensions;
    using FitnessFusion.Web.ViewModels.Subscription;
    using Microsoft.AspNetCore.Mvc;
    using static Common.NotificationMessagesConstant;

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

            try
            {
                await subscriptionService.AddSubscription(model, User.GetId());

                return RedirectToAction("All");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var subsciptionExist = await subscriptionService.IsSubscriptionExistByIdAsync(id);

            if (!subsciptionExist)
            {
                TempData[ErrorMessage] = "Subscription with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                var model = await subscriptionService.GetSubscription(id);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit (string id, SubscriptionModel model)
        {
            var subsciptionExist = await subscriptionService.IsSubscriptionExistByIdAsync(id);

            if (!subsciptionExist)
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
                await subscriptionService.Edit(model, id);

                return RedirectToAction("All");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var subsciptionExist = await subscriptionService.IsSubscriptionExistByIdAsync(id);

            if (!subsciptionExist)
            {
                TempData[ErrorMessage] = "Meal with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                var model = await subscriptionService.GetSubscription(id);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var subsciptionExist = await subscriptionService.IsSubscriptionExistByIdAsync(id);

            if (!subsciptionExist)
            {
                TempData[ErrorMessage] = "Meal with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                await subscriptionService.DeleteSubscription(id);

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
