﻿using Microsoft.AspNetCore.Mvc;

namespace MVCFirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Nya()
        {
            return View();
        }
    }
}
