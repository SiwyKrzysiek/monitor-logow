using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace MonitorLogow.Controllers
{
    public class LoggingController : Controller
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateLog()
        {
            _logger.Info("Logg buton has been pressed");

            return RedirectToAction("Index", "Logging");
        }
    }
}