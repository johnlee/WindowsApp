using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static string TestProcess()
        {
            try
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.FileName = "SCHTASKS.exe";
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                //p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
                //p.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);
                string tbl = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                p.Close();
                p.Dispose();


                //p.StartInfo.Arguments = "/query /TN " + taskname;
                //p.StartInfo.Arguments = String.Format(
                //    "/Change /S {0} /TN {1} /RU {2}\\{3} /RP {4}",
                //    MachineName,
                //    ScheduledTaskName,
                //    activeDirectoryDomainName,
                //    userName,
                //    password
                //);

                //p.Start();
                ////Then wait for it to finish
                //p.WaitForExit();

                //// Read the error stream first and then wait.
                //string error = p.StandardError.ReadToEnd();

                ////Read the output string
                //p.StandardOutput.ReadLine();
                //string tbl = p.StandardOutput.ReadToEnd();



                ////Check for an error
                //if (!String.IsNullOrWhiteSpace(error))
                //{
                //    throw new Exception(error);
                //}

                ////return tbl.Split(new String[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries)[1].Trim().EndsWith("Running");
                return tbl;
            }
            catch (Exception ex)
            {
                return "ERROR reading task scheduler! " + ex.Message;
            }
        }
    }
}
