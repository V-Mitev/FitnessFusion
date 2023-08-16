namespace FitnessFusion.Web.Areas.Admin.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using FitnessFusion.Web.ViewModels.Trainer;
    using Microsoft.AspNetCore.Mvc;
    using static Common.GeneralApplicationConstants;
    using static Common.NotificationMessagesConstant;

    public class TrainerController : BaseAdminController
    {
        private readonly ITrainerService trainerService;

        public TrainerController(ITrainerService trainerService)
        {
            this.trainerService = trainerService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new TrainerViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TrainerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await trainerService.IsEmailAlreadyAdded(model.Email))
            {
                TempData[ErrorMessage] = "This email is already used! Please enter onother email adress!";

                return View(model);
            }

            try
            {
                await trainerService.AddTrainerAsync(model);

                return RedirectToAction("All", "User", new { Area = AdminAreaName });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            if (!await trainerService.IsUserTrainerAsync(id))
            {
                TempData[ErrorMessage] = "Trainer with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                await trainerService.RemoveTrainerAsync(id);

                return RedirectToAction("All", "User");
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
