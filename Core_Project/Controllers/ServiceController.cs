﻿using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
