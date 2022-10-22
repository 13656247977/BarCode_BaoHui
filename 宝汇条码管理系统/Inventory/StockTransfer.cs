using Newtonsoft.Json;
using ServiceHelper;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using 宝汇条码管理系统.UserContors;

namespace 宝汇条码管理系统.Inventory
{
    partial class StocklocTransfer : Smobiler.Core.Controls.MobileForm
    {

        public StocklocTransfer() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        /// <summary>
        /// 条形码点击事件，打开扫描摄像头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_Barcode_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            txt_Barcode.Text = "";
            txt_Barcode.Text = e.Value;
            string barCode = txt_Barcode.Text;
            SetFormData(barCode);
        }
        /// <summary>
        /// 条形码值更新事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Barcode_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_Barcode_TouchEnter(object sender, EventArgs e)
        {
            //txt_Barcode.Text = string.Empty;
        }
        private void txt_Barcode_TouchLeave(object sender, EventArgs e)
        {
            string barCode = txt_Barcode.Text;
            SetFormData(barCode);
        }
        /// <summary>
        /// 传入BarCode 查询数据并刷新界面
        /// </summary>
        /// <param name="barCode"></param>
        private void SetFormData(string barCode)
        {
            if (!string.IsNullOrWhiteSpace(barCode))
            {
                SetViewData();
                DataTable dt = DbServiceHepler.GetDataTable(
                    string.Format(@"SELECT * FROM V_ZZ_TM_MATERIAL
                                    WHERE FNUMBER='{0}'", barCode));
                if (dt==null || dt.Rows.Count<=0)
                {
                    Toast("未找到对应的数据！");
                    return;
                }
                DataRow dr = dt.Rows[0];
                //if (Convert.ToDecimal(dr["FQTY"]) <= 0 || Convert.ToDecimal(dr["FAUXQTY"]) <= 0)
                //{
                //    Toast("当前物料无库存，无需调拨！");
                //    return;
                //}
                SetViewData(dr);
            }
            else
            {
                SetViewData();
            }
        }
        /// <summary>
        /// 设置页面数据
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="type"></param>
        private void SetViewData(DataRow dr)
        {
            //dr.Read();
            MobileControlCollection controls = this.Controls as MobileControlCollection;
            foreach (MobileControl control in controls)
            {
                if (control.Name != "materialPanel")
                {
                    continue;
                }
                MobileControlCollection textBoxs = (control as Panel).Controls as MobileControlCollection;
                foreach (MobileControl textBox in textBoxs)
                {
                    if (textBox is TextBox)
                    {
                        TextBox field = textBox as TextBox;
                        if (!string.IsNullOrWhiteSpace(field.DataMember))
                        {
                            field.BindDataValue = dr[field.DataMember.ToString()].ToString();
                        }
                        if (!string.IsNullOrWhiteSpace(field.DisplayMember))
                        {
                            field.BindDisplayValue = dr[field.DisplayMember.ToString()].ToString();
                        }
                        //field.Text = dr[field.DisplayMember.ToString()].ToString();
                    }
                }
            }
            //dr.Close();
        }
        /// <summary>
        /// 设置页面数据
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="type"></param>
        private void SetViewData()
        {
            MobileControlCollection controls = this.Controls as MobileControlCollection;
            foreach (MobileControl control in controls)
            {
                if (control.Name != "materialPanel")
                {
                    continue;
                }
                MobileControlCollection textBoxs = (control as Panel).Controls as MobileControlCollection;
                foreach (MobileControl textBox in textBoxs)
                {
                    if (textBox is TextBox)
                    {
                        TextBox field = textBox as TextBox;
                        if (!string.IsNullOrWhiteSpace(field.DataMember))
                        {

                            field.BindDataValue = string.Empty;
                        }
                        if (!string.IsNullOrWhiteSpace(field.DisplayMember))
                        {
                            field.BindDisplayValue = string.Empty;
                        }
                        //field.Text = dr[field.DisplayMember.ToString()].ToString();
                    }
                }
            }
        }
        /// <summary>
        /// 加载辅助属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibt_flex_Press(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 加载调出仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibt_stock_src_Press(object sender, EventArgs e)
        {
            frmStockSelect frm = new frmStockSelect();
            Show(frm, true, (MobileForm sender1, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    if (this.Session.ContainsKey("stockId") && !string.IsNullOrWhiteSpace(this.Session["stockId"] as string))
                    {
                        tx_stockLocId.BindDataValue = 0;
                        tx_stockLocId.BindDisplayValue = "";
                        tx_stockId.BindDataValue = this.Session["stockId"] as string;
                        this.Session.Remove("stockId");
                    }
                    if (this.Session.ContainsKey("stockName") && !string.IsNullOrWhiteSpace(this.Session["stockName"] as string))
                    {
                        tx_stockId.BindDisplayValue = this.Session["stockName"] as string;
                        this.Session.Remove("stockName");
                    }
                }
            });
        }
        /// <summary>
        /// 加载调出仓位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibt_stockLoc_src_Press_1(object sender, EventArgs e)
        {
            long stockId = 0L;
            long.TryParse(tx_stockId.BindDataValue as string, out stockId);
            if (stockId == 0)
            {
                Toast("请先输入仓库！");
                return;
            }
            frmStockLocSelect frm = new frmStockLocSelect();
            frm.stockId = stockId;
            Show(frm, true, (MobileForm sender1, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    if (this.Session.ContainsKey("stockLocId") && !string.IsNullOrWhiteSpace(this.Session["stockLocId"] as string))
                    {
                        tx_stockLocId.BindDataValue = this.Session["stockLocId"] as string;
                        this.Session.Remove("stockLocId");
                    }
                    if (this.Session.ContainsKey("stockLocName") && !string.IsNullOrWhiteSpace(this.Session["stockLocName"] as string))
                    {
                        tx_stockLocId.BindDisplayValue = this.Session["stockLocName"] as string;
                        this.Session.Remove("stockLocName");
                    }
                }
            });
        }
        /// <summary>
        /// 加载调入仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibt_stock_Press(object sender, EventArgs e)
        {
            frmStockSelect frm = new frmStockSelect();
            Show(frm, true, (MobileForm sender1, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    if (this.Session.ContainsKey("stockId") && !string.IsNullOrWhiteSpace(this.Session["stockId"] as string))
                    {
                        tx_stockLocId_desc.BindDataValue = 0;
                        tx_stockLocId_desc.BindDisplayValue = "";
                        tx_stockId_desc.BindDataValue = this.Session["stockId"] as string;
                        this.Session.Remove("stockId");
                    }
                    if (this.Session.ContainsKey("stockName") && !string.IsNullOrWhiteSpace(this.Session["stockName"] as string))
                    {
                        tx_stockId_desc.BindDisplayValue = this.Session["stockName"] as string;
                        this.Session.Remove("stockName");
                    }
                }
            });
        }
        /// <summary>
        /// 加载调入仓位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibt_stockLoc_Press(object sender, EventArgs e)
        {
            long stockId = 0L;
            long.TryParse(tx_stockId_desc.BindDataValue as string, out stockId);
            if (stockId == 0)
            {
                Toast("请先输入仓库！");
                return;
            }
            frmStockLocSelect frm = new frmStockLocSelect();
            frm.stockId = stockId;
            Show(frm, true, (MobileForm sender1, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    if (this.Session.ContainsKey("stockLocId") && !string.IsNullOrWhiteSpace(this.Session["stockLocId"] as string))
                    {
                        tx_stockLocId_desc.BindDataValue = this.Session["stockLocId"] as string;
                        this.Session.Remove("stockLocId");
                    }
                    if (this.Session.ContainsKey("stockLocName") && !string.IsNullOrWhiteSpace(this.Session["stockLocName"] as string))
                    {
                        tx_stockLocId_desc.BindDisplayValue = this.Session["stockLocName"] as string;
                        this.Session.Remove("stockLocName");
                    }
                }
            });
        }

        private void StocklocTransfer_Load(object sender, EventArgs e)
        {
            //tx_stockId.BindDataValue = stockId;
            //tx_stockId.BindDisplayValue = stockName;
        }

        /// <summary>
        /// toolBar事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
           switch(e.Name)
            {
                case "reBack":
                    this.Close();
                    break;
                case "submit":
                    long materialId=SParse.ToLong(tx_MaterialId.BindDataValue);
                    if (materialId<=0)
                    {
                        Toast("物料编码空或不正确，请重新扫码！");
                        return;
                    }
                    long auxpropId = SParse.ToLong(tx_AuxpropId.BindDataValue);
                    if (auxpropId<=0)
                    {
                        Toast("辅助属性空或不正确，请重新扫码！");
                        return;
                    }
                    long lotId = SParse.ToLong(tx_lotId.BindDataValue);
                    string lot_txt = SParse.ToString(tx_lotId.BindDisplayValue);
                    if (lotId <= 0)
                    {
                        Toast("批号空或不正确，请重新扫码！");
                        return;
                    }
                    long stockId = SParse.ToLong(tx_stockId.BindDataValue);
                    if (stockId <= 0)
                    {
                        Toast("调出仓库空或不正确，请重新扫码！");
                        return;
                    }
                    long stockId_desc = SParse.ToLong(tx_stockId_desc.BindDataValue);
                    if (stockId_desc <= 0)
                    {
                        Toast("调入仓库空或不正确，请重新扫码！");
                        return;
                    }
                    long unitId = SParse.ToLong(tx_UnitId.BindDataValue);
                    if (unitId <= 0)
                    {
                        Toast("主单位空或不正确，请重新扫码！");
                        return;
                    }
                    long auxUnitId = SParse.ToLong(tx_auxUnitId.BindDataValue);
                    if (auxUnitId <= 0)
                    {
                        Toast("辅单位空或不正确，请重新扫码！");
                        return;
                    }
                    decimal qty = SParse.ToDecimal(tx_qty.BindDisplayValue);
                    if (qty <= 0)
                    {
                        Toast("主数量空或不正确，请重新输入！");
                        return;
                    }
                    decimal auxQty = SParse.ToDecimal(tx_auxQty.BindDisplayValue);
                    if (auxQty <= 0)
                    {
                        Toast("辅数量空或不正确，请重新输入！");
                        return;
                    }
                    if(string.IsNullOrWhiteSpace(txt_Barcode.Text))
                    {
                        Toast("条码为空请重新扫描！");
                        return;
                    }
                    try
                    {
                        string stockLocId_desc = SParse.ToString(tx_stockLocId_desc.BindDisplayValue);
                        ScanInfo scanInfo = new ScanInfo();
                        scanInfo.barCode = SParse.ToBarCode(txt_Barcode.Text);
                        scanInfo.qty = qty;
                        scanInfo.auxQty = auxQty;
                        scanInfo.stockId = stockId_desc;
                        scanInfo.stockLocId = stockLocId_desc;
                        string result = ServiceHelper.CreateErpStkTransfer.CreateForm(scanInfo);
                        Toast(result);
                    }
                    catch(Exception ex)
                    {
                        Toast(ex.Message);
                    }
                    break;
            }
        }
    }
}