﻿using Microsoft.AspNetCore.Mvc;

namespace BarRating.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
