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
    partial class frmStockLocSelect : Smobiler.Core.Controls.MobileForm
    {
        public frmStockLocSelect() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        public long stockId {get;set;}
        private void ibt_search_Press(object sender, EventArgs e)
        {
            string stockName = tx_stockName.Text;
            string whereStr = string.Format(" Where FSTOCKID={0}", stockId);
            if (!string.IsNullOrWhiteSpace(stockName))
            {
                whereStr += string.Format(@" AND FSTOCKLOCNAME like '%{0}%'", stockName.Replace(" ", ""));
            }
            string sql = string.Format(@"Select FSTOCKLOCID,FSTOCKLOCNAME FROM V_ZZ_STOCKLOC {0}", whereStr);
            DataTable dt = DbServiceHepler.GetDataTable(sql);
            if(dt.Rows.Count==0)
            {
                Toast("无数据！");
            }
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