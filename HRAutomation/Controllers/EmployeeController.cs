﻿using Microsoft.AspNetCore.Mvc;

namespace HRAutomation.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
