using ServiceHelper;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace 宝汇条码管理系统.Inventory
{
    partial class frmStockSelect : Smobiler.Core.Controls.MobileForm
    {
        public frmStockSelect() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private void ibt_search_Press(object sender, EventArgs e)
        {
            string stockName = tx_stockName.Text;
            string whereStr = "Where FLOCALEID = 2052";
            if (!string.IsNullOrWhiteSpace(stockName))
            {
                whereStr += string.Format(@" AND FNAME like '%{0}%'", stockName.Replace(" ", ""));
            }
            string sql = string.Format(@"Select FSTOCKID,FNAME FSTOCKNAME FROM T_BD_STOCK_L {0}", whereStr);
            DataTable dt = DbServiceHepler.GetDataTable(sql);
            ls_Stock.DataSource = dt;
            ls_Stock.DataBind();
        }

        private void tb_tools_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            if (e.Name == "reBack")
            {
                this.Close();
            }
        }

        private void panel2_Press(object sender, EventArgs e)
        {
        }

        private void panel1_Press(object sender, EventArgs e)
        {
           

        }
    }
}