﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MonitorLogow.Controllers
{
    public class LoggingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateLog()
        {
            //TODO: Save log

            return RedirectToAction("Index", "Logging");
        }
    }
}