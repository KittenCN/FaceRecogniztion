﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecogniztion
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            //System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
            //if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
            //{
            //    Application.Run(new faceDetect());
            //}
            //else
            //{
            //    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //    startInfo.UseShellExecute = true;
            //    startInfo.WorkingDirectory = Environment.CurrentDirectory;
            //    startInfo.FileName = Application.ExecutablePath;
            //    startInfo.Verb = "runas";
            //    try
            //    {
            //        System.Diagnostics.Process.Start(startInfo);
            //    }
            //    catch
            //    {
            //        return;
            //    }
            //    Application.Exit();
            //}

            Application.Run(new faceDetect());
        }
    }
}
