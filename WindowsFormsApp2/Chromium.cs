/******************************************************************
* Licensed Materials - Property of HCL
* (c) Copyright HCL Technologies Ltd. 2016, 2021.
* Note to U.S. Government Users Restricted Rights.
******************************************************************/
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Threading;

namespace Chromium
{
    public partial class Chromium : Form
    {

        private string crawlerStopEventId = null;
        public ChromiumWebBrowser browser;

        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("www.google.com");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        public Chromium(string[] args)
        {            
            InitializeComponent();       
            CefSettings settings = new CefSettings();
            CefSharpSettings.FocusedNodeChangedEnabled = true;
            InitBrowser();


        }

        private void Chromium_FormClosed(object sender, FormClosedEventArgs e)
        {
            //close the crawler if the browser was closed by the user
            if (e.CloseReason == CloseReason.UserClosing && !String.IsNullOrEmpty(crawlerStopEventId))
            {
                if (EventWaitHandle.TryOpenExisting(crawlerStopEventId, out EventWaitHandle handle))
                {
                    handle.Set();
                }
            }
        }
    }
}
