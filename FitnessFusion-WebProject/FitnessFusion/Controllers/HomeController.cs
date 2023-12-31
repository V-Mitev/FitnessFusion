﻿namespace FitnessFusion.Controllers
{
    using FitnessFusion.Web.Infastructure.Extensions;
    using Microsoft.AspNetCore.Mvc;
    using static Common.GeneralApplicationConstants;

    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            if (User.IsAdmin())
            {
                return RedirectToAction("Index", "Home", new { Area = AdminAreaName });
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400 || statusCode == 404)
            {
                return View("Error404");
            }

            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View();
        }
    }
}