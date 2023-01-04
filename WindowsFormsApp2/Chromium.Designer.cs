/******************************************************************
* Licensed Materials - Property of HCL
* (c) Copyright HCL Technologies Ltd. 2016, 2021.
* Note to U.S. Government Users Restricted Rights.
******************************************************************/
namespace Chromium
{
    partial class Chromium
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chromium));
            this.SuspendLayout();
            // 
            // AppScanChromium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppScanChromium";
            this.Text = "Chromium-Based Browser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chromium_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

