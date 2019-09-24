﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DigitalLibraryApplication.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData ["Message"] = "Welcome to Digital Library!";
            return View();
        }

        public string Description()
        {
            return "This is the application for managing digital books!";
        }
    }
}