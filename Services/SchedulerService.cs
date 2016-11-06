using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class SchedulerService
    {
        public static string GetAllTaskNames()
        {
            return GetTasksByDirectory();
        }

        // Testing out different ways to get scheduled task names
        private static string GetTasksByDirectory()
        {
            string path = "C:\\Windows\\System32\\Tasks";
            string filenames = string.Empty;

            try
            {
                if (Directory.Exists(path))
                {
                    Directory.GetFiles(path).ToList().ForEach(s => filenames += s + "\n");
                }
            }
            catch (Exception ex)
            {
                filenames = "ERROR trying to read from path: " + path + "\n" + ex.Message;
            }
            return filenames;
        }

        private static string GetTasksByLibrary()
        {
            //TaskScheduler scheduler = TaskScheduler.Current;
            //scheduler.
            return "";
        }
    }
}
