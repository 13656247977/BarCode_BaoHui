using Smobiler.Core;
using System;

namespace 宝汇条码管理系统.UserContors
{
    partial class Search : Smobiler.Core.Controls.MobileUserControl
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.tx_searchStr = new Smobiler.Core.Controls.TextBox();
            this.ibt_Search = new Smobiler.Core.Controls.ImageButton();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.BorderColor = System.Drawing.Color.LightGray;
            this.label1.BorderRadius = 5;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(75, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            // 
            // tx_searchStr
            // 
            this.tx_searchStr.Dock = System.Windows.Forms.DockStyle.Left;
            this.tx_searchStr.FontSize = 16F;
            this.tx_searchStr.Location = new System.Drawing.Point(35, 8);
            this.tx_searchStr.Margin = new Smobiler.Core.Controls.Margin(20F, 5F, 35F, 2F);
            this.tx_searchStr.Name = "tx_searchStr";
            this.tx_searchStr.Size = new System.Drawing.Size(250, 35);
            // 
            // ibt_Search
            // 
            this.ibt_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibt_Search.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.ibt_Search.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.ibt_Search.Location = new System.Drawing.Point(260, 5);
            this.ibt_Search.Margin = new Smobiler.Core.Controls.Margin(0F, 5F, 5F, 5F);
            this.ibt_Search.Name = "ibt_Search";
            this.ibt_Search.ResourceID = "search";
            this.ibt_Search.Size = new System.Drawing.Size(30, 30);
            this.ibt_Search.Press += new System.EventHandler(this.ibt_Search_Press);
            // 
            // Search
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.tx_searchStr,
            this.ibt_Search});
            this.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Size = new System.Drawing.Size(300, 40);
            this.Name = "Search";

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TextBox tx_searchStr;
        private Smobiler.Core.Controls.ImageButton ibt_Search;
    }
}