using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonitorLogow.Models;
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

        [HttpPost]
        public IActionResult CreateLog(LogModel log)
        {
            if (log.Message == null) //TODO: Validate form to check if it's null
                log.Message = "";
            _logger.Info(log.Message);

            return RedirectToAction("Index", "Logging");
        }
    }
}