namespace FitnessFusion.Web.Areas.Admin.Controllers
{
    using FitnessFusion.Services.Data.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    public class UserController : BaseAdminController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<IActionResult> All()
        {
            var allUsers = await userService.AllAsync();

            return View(allUsers);
        }
    }
}
