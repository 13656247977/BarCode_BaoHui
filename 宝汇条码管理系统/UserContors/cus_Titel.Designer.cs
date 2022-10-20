using Smobiler.Core;
using System;

namespace 宝汇条码管理系统.UserContors
{
    partial class cus_Titel : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.reBack = new Smobiler.Core.Controls.ImageButton();
            this.more = new Smobiler.Core.Controls.ImageButton();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.reBack,
            this.more});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Bold = true;
            this.label1.FontSize = 24F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(30, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 30);
            this.label1.Text = "label1";
            // 
            // reBack
            // 
            this.reBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reBack.ForeColor = System.Drawing.Color.White;
            this.reBack.IconColor = System.Drawing.Color.White;
            this.reBack.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.reBack.Location = new System.Drawing.Point(0, 2);
            this.reBack.Name = "reBack";
            this.reBack.ResourceID = "angle-left";
            this.reBack.Size = new System.Drawing.Size(30, 30);
            this.reBack.Press += new System.EventHandler(this.reBack_Press);
            // 
            // more
            // 
            this.more.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.more.ForeColor = System.Drawing.Color.White;
            this.more.IconColor = System.Drawing.Color.White;
            this.more.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.more.Location = new System.Drawing.Point(270, 2);
            this.more.Name = "more";
            this.more.ResourceID = "th-large";
            this.more.Size = new System.Drawing.Size(30, 30);
            this.more.Press += new System.EventHandler(this.more_Press);
            // 
            // cus_Titel
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 35);
            this.Name = "cus_Titel";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ImageButton reBack;
        private Smobiler.Core.Controls.ImageButton more;
    }
}