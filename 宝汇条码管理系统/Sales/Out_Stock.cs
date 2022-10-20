using ServiceHelper;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace 宝汇条码管理系统.menu
{
    partial class Out_Stock : Smobiler.Core.Controls.MobileForm
    {
        public Out_Stock() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 点击查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void srcFormSearch_SearchButtonPress(object sender, EventArgs e)
        {
            SetFormData(this.srcFormSearch.SearchText);
        }
        /// <summary>
        /// 传入BarCode 查询数据并刷新界面
        /// </summary>
        /// <param name="barCode"></param>
        private void SetFormData(string searchStr)
        {
            ////清空界面
            if (!string.IsNullOrWhiteSpace(searchStr))
            {
                string sql =
                        string.Format(@"SELECT  *
                                        FROM V_ZZ_TM_SAL_DELINOTICE
                                        WHERE FCUSTNAME like '%{0}%' OR FCZNAME LIKE '%{0}%' 
                                              OR FCUSTNAME  LIKE '%{0}%'", searchStr);
                DataTable dt = DbServiceHepler.GetDataTable(sql);
                billList.DataSource = dt;
                billList.DataBind();
            }
            else
            {
                string sql =
                        string.Format(@"SELECT  *
                                        FROM V_ZZ_TM_SAL_DELINOTICE");
                DataTable dt = DbServiceHepler.GetDataTable(sql);
                billList.DataSource = dt;
                billList.DataBind();
            }
        }
    }
}