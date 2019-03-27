using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorLogow.Models
{
    public class LogModel
    {
        [Display(Name = "Log message")]
        public string Message { get; set; }
        [Display(Name = "Log type")]
        public LogTypes LogType { get; set; }

        public enum LogTypes
        {
            Trace,
            Debug,
            Info,
            Warn,
            Error,
            Fatal
        }
    }
}
