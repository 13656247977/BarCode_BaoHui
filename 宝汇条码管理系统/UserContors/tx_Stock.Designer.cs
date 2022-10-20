using Smobiler.Core;
using System;

namespace 宝汇条码管理系统.UserContors
{
    partial class tx_Stock : Smobiler.Core.Controls.MobileUserControl
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
            this.lbNameTxt = new Smobiler.Core.Controls.Label();
            this.tx_stockId = new Smobiler.Core.Controls.TextBox();
            this.ibt_stock_src = new Smobiler.Core.Controls.ImageButton();
            // 
            // lbNameTxt
            // 
            this.lbNameTxt.Bold = true;
            this.lbNameTxt.Flex = 15;
            this.lbNameTxt.FontSize = 16F;
            this.lbNameTxt.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbNameTxt.Location = new System.Drawing.Point(4, 1);
            this.lbNameTxt.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.lbNameTxt.Name = "lbNameTxt";
            this.lbNameTxt.Size = new System.Drawing.Size(65, 28);
            this.lbNameTxt.Text = "调出仓库";
            // 
            // tx_stockId
            // 
            this.tx_stockId.DataMember = "FSTOCKID";
            this.tx_stockId.DisplayMember = "FSTOCKNAME";
            this.tx_stockId.Flex = 85;
            this.tx_stockId.FontSize = 16F;
            this.tx_stockId.Location = new System.Drawing.Point(72, 1);
            this.tx_stockId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_stockId.Name = "tx_stockId";
            this.tx_stockId.ReadOnly = true;
            this.tx_stockId.Size = new System.Drawing.Size(185, 28);
            // 
            // ibt_stock_src
            // 
            this.ibt_stock_src.BackColor = System.Drawing.Color.SteelBlue;
            this.ibt_stock_src.Location = new System.Drawing.Point(257, 4);
            this.ibt_stock_src.Name = "ibt_stock_src";
            this.ibt_stock_src.ResourceID = "search3.jpeg";
            this.ibt_stock_src.Size = new System.Drawing.Size(33, 28);
            this.ibt_stock_src.Press += new System.EventHandler(this.ibt_stock_src_Press);
            // 
            // tx_Stock
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lbNameTxt,
            this.tx_stockId,
            this.ibt_stock_src});
            this.Size = new System.Drawing.Size(300, 33);
            this.Name = "tx_Stock";

        }
        #endregion

        private Smobiler.Core.Controls.Label lbNameTxt;
        private Smobiler.Core.Controls.TextBox tx_stockId;
        private Smobiler.Core.Controls.ImageButton ibt_stock_src;
    }
}