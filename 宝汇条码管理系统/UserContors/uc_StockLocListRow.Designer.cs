using Smobiler.Core;
using System;

namespace 宝汇条码管理系统.UserContors
{
    partial class uc_StockLocListRow : Smobiler.Core.Controls.MobileUserControl
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
            this.tx_stockLocId = new Smobiler.Core.Controls.TextBox();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tx_stockLocId});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 54);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // tx_stockLocId
            // 
            this.tx_stockLocId.BackColor = System.Drawing.Color.Transparent;
            this.tx_stockLocId.DataMember = "FSTOCKLOCID";
            this.tx_stockLocId.DisplayMember = "FSTOCKLOCNAME";
            this.tx_stockLocId.FontSize = 20F;
            this.tx_stockLocId.Location = new System.Drawing.Point(38, 6);
            this.tx_stockLocId.Name = "tx_stockLocId";
            this.tx_stockLocId.ReadOnly = true;
            this.tx_stockLocId.Size = new System.Drawing.Size(186, 40);
            this.tx_stockLocId.TextChanged += new System.EventHandler(this.tx_stockId_TextChanged);
            // 
            // uc_StockLocListRow
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(300, 54);
            this.Name = "uc_StockLocListRow";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.TextBox tx_stockLocId;
    }
}