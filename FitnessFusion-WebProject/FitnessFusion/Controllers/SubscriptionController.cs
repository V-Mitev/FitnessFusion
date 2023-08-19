namespace FitnessFusion.Web.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.Infastructure.Extensions;
    using FitnessFusion.Web.ViewModels.Subscription;
    using Microsoft.AspNetCore.Authorization;
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
            var subscriptions = await subscriptionService.GetAllSubscriptionsAsync();

            return View(subscriptions);
        }

        [HttpGet]
        public IActionResult Add()
        {
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "Only administators can add subscriptions!";

                return RedirectToAction("Index", "Home");
            }

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
                await subscriptionService.AddSubscriptionAsync(model);

                TempData[SuccessMessage] = "You have successfully added the subscription";

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
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "Only administators can edit subscriptions!";

                return RedirectToAction("Index", "Home");
            }

            var subsciptionExist = await subscriptionService.IsSubscriptionExistByIdAsync(id);

            if (!subsciptionExist)
            {
                TempData[ErrorMessage] = "Subscription with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                var model = await subscriptionService.GetSubscriptionAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, SubscriptionModel model)
        {
            var subsciptionExist = await subscriptionService.IsSubscriptionExistByIdAsync(id);

            if (!subsciptionExist)
            {
                TempData[ErrorMessage] = "Subscription with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await subscriptionService.EditAsync(model, id);

                TempData[SuccessMessage] = "You have successfully edit the subscription";

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
                TempData[ErrorMessage] = "Subscription with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                var model = await subscriptionService.GetSubscriptionAsync(id);

                TempData["SubscriptionId"] = id;

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
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "Only administators can delete subscriptions!";

                return RedirectToAction("Index", "Home");
            }

            var subsciptionExist = await subscriptionService.IsSubscriptionExistByIdAsync(id);

            if (!subsciptionExist)
            {
                TempData[ErrorMessage] = "Subscription with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                await subscriptionService.DeleteSubscriptionAsync(id);

                TempData[SuccessMessage] = "You have successfully delete the subscription";

                return RedirectToAction("All");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Subscribe()
        {
            if (await subscriptionService.IsSubscribeValidAsync(User.GetId()))
            {
                TempData[ErrorMessage] = "You are already subscribed, when the subscription expires, try again!";

                return RedirectToAction("Index", "Home");
            }

            var model = new SubscribeViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe(SubscribeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (TempData.TryGetValue("SubscriptionId", out object? subscriptionId) && subscriptionId != null)
            {
                string id = subscriptionId.ToString() ?? string.Empty;

                await subscriptionService.SubscribeAsync(id, User.GetId());

                TempData[SuccessMessage] = "You have successfully subscribed!";

                TempData.Remove("SubscriptionId");

                return RedirectToAction("Index", "Home");
            }

            return GeneralError();
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] =
                "Unexpected error occurred! Please try again later or contact administrator";

            return RedirectToAction("Index", "Home");
        }
    }
}
