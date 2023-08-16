namespace FitnessFusion.Web.Areas.Admin.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using static Common.NotificationMessagesConstant;

    public class UserController : BaseAdminController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var allUsers = await userService.AllAsync();

            return View(allUsers);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            if (!await userService.IsUserExistByIdAsync(id))
            {
                TempData[ErrorMessage] = "User with provided id does not exist! Please try again!";

                return RedirectToAction("All");
            }

            try
            {
                await userService.DeleteAsync(id);

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
