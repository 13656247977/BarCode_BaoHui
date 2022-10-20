using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 宝汇条码管理系统.Inventory;

namespace 宝汇条码管理系统.UserContors
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class uc_StockListRow : Smobiler.Core.Controls.MobileUserControl
    {
        public uc_StockListRow() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        private void panel1_Press(object sender, EventArgs e)
        {
            this.Form.Session.Add("stockId", tx_stockLocId.BindDataValue);
            this.Form.Session.Add("stockName", tx_stockLocId.BindDisplayValue);
            this.Form.ShowResult = ShowResult.Yes;
            this.Form.Close();
        }

        private void tx_stockId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}