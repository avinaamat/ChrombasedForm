/******************************************************************
* Licensed Materials - Property of HCL
* (c) Copyright HCL Technologies Ltd. 2016, 2016.
* Note to U.S. Government Users Restricted Rights.
******************************************************************/
using System;
using System.Windows.Forms;

namespace Chromium
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Chromium(args));

        }
    }

}