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

            switch (log.LogType)
            {
                case LogModel.LogTypes.Trace:
                    _logger.Trace(log.Message);
                    break;
                case LogModel.LogTypes.Debug:
                    _logger.Debug(log.Message);
                    break;
                case LogModel.LogTypes.Info:
                    _logger.Info(log.Message);
                    break;
                case LogModel.LogTypes.Warn:
                    _logger.Warn(log.Message);
                    break;
                case LogModel.LogTypes.Error:
                    _logger.Error(log.Message);
                    break;
                case LogModel.LogTypes.Fatal:
                    _logger.Fatal(log.Message);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return RedirectToAction("Index", "Logging");
        }
    }
}