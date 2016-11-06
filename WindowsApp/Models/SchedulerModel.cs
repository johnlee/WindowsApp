using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Models
{
    public class SchedulerModel
    {
        public SchedulerModel()
        {
            TaskNames = SchedulerService.GetAllTaskNames();
        }

        public string TaskNames { get; set; }
    }
}
