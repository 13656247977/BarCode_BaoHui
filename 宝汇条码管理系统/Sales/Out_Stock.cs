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
        /// <summary>
        /// 已办列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search1_SearchButtonPress(object sender, EventArgs e)
        {

        }

        private void Bind()
        {
            try
            {
                tv_finishList.Nodes.Clear();
                string sql =
                        string.Format(@"SELECT  *
                                        FROM V_ZZ_TM_SAL_DELINOTICE");
                DataTable dt = DbServiceHepler.GetDataTable(sql);
                IEnumerable<DataRow> drs = dt.Select("FCUSTID>0").Distinct();
                foreach (DataRow dr in drs)
                {
                    TreeViewNode Node = new TreeViewNode();
                    Node.Checked = false;
                    Node.Text = dr["FCUSTNAME"].ToString();
                    Node.Value = dr["FCUSTID"].ToString();
                    IEnumerable<DataRow> drBills =
                        dt.Select(
                                   string.Format("FCUSTID='{0}'", dr["FCUSTID"])
                                 ).Distinct();
                    foreach (DataRow drr in drBills)
                    {
                        TreeViewNode child = new TreeViewNode();
                        child.Checked = false;
                        child.Text = drr["FBILLNO"].ToString();
                        child.Value = drr["FID"].ToString();

                        IEnumerable<DataRow> drEntrys =
                        dt.Select(
                                   string.Format("FCUSTID={0} AND FID={1}", dr["FCUSTID"], drr["FID"])
                                 ).Distinct();
                        foreach (DataRow drr1 in drBills)
                        {
                            //行号
                            TreeViewNode child1 = new TreeViewNode();
                            child1.Checked = false;
                            child1.Text = drr1["FSEQ"].ToString();
                            child1.Value = drr1["FENTRYID"].ToString();
                            child.Nodes.Add(child1);
                            //卷号
                            TreeViewNode child2 = new TreeViewNode();
                            child2.Checked = false;
                            child2.Text = drr1["FZZ_JH"].ToString();
                            child2.Value = drr1["FZZ_JH"].ToString();
                            child.Nodes.Add(child2);
                            //物料
                            TreeViewNode child3 = new TreeViewNode();
                            child3.Checked = false;
                            child3.Text = drr1["FMATERIALNUMBER"].ToString();
                            child3.Value = drr1["FMATERIALID"].ToString();
                            child.Nodes.Add(child3);
                            //辅助属性
                            TreeViewNode child4 = new TreeViewNode();
                            child4.Checked = false;
                            child4.Text = drr1["FAUXPROPNAME"].ToString();
                            child4.Value = drr1["FAUXPROPID"].ToString();
                            child.Nodes.Add(child4);
                            //单位
                            TreeViewNode child5 = new TreeViewNode();
                            child5.Checked = false;
                            child5.Text = drr1["FUNITNAME"].ToString();
                            child5.Value = drr1["FUNITID"].ToString();
                            child.Nodes.Add(child5);
                            //数量
                            TreeViewNode child6 = new TreeViewNode();
                            child6.Checked = false;
                            child6.Text = drr1["FQTY"].ToString();
                            child6.Value = drr1["FQTY"].ToString();
                            child.Nodes.Add(child6);
                        }
                        Node.Nodes.Add(child);
                    }
                    tv_finishList.Nodes.Add(Node);
                }
                tv_finishList.CollapseAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void billList_TemplateItemEvent(object sender, TemplateItemEventArgs e)
        {
            string evClName = e.EventControl.Name;
            DataRowView activeRowView = billList.ActiveRow.Data as DataRowView;
            if (evClName == "bl_panel" && activeRowView != null)
            {
                DataRow activeRow = activeRowView.Row;
                decimal srcQty = SParse.ToDecimal(activeRow["FQTY"]);
                tp_View.PageIndex = 1;
                Toast(srcQty.ToString());
            }
        }
    }
}