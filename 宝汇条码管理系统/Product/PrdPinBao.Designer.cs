using Smobiler.Core;
using System;

namespace 宝汇条码管理系统.Product
{
    partial class PrdPinBao : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.materialPanel = new Smobiler.Core.Controls.Panel();
            this.lb_MaterialNumber = new Smobiler.Core.Controls.Label();
            this.tx_MaterialId = new Smobiler.Core.Controls.TextBox();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.tx_MaterialName = new Smobiler.Core.Controls.TextBox();
            this.tx_MaterialModel = new Smobiler.Core.Controls.TextBox();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.tx_AuxpropId = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.tx_lotId = new Smobiler.Core.Controls.TextBox();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.tx_stockId = new Smobiler.Core.Controls.TextBox();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.tx_stockLocId = new Smobiler.Core.Controls.TextBox();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.tx_stockId_desc = new Smobiler.Core.Controls.TextBox();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.tx_stockLocId_desc = new Smobiler.Core.Controls.TextBox();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.tx_UnitId = new Smobiler.Core.Controls.TextBox();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.tx_qty = new Smobiler.Core.Controls.TextBox();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.tx_auxUnitId = new Smobiler.Core.Controls.TextBox();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.tx_auxQty = new Smobiler.Core.Controls.TextBox();
            this.label14 = new Smobiler.Core.Controls.Label();
            this.textBox14 = new Smobiler.Core.Controls.TextBox();
            this.ibt_flex = new Smobiler.Core.Controls.ImageButton();
            this.ibt_stockLoc = new Smobiler.Core.Controls.ImageButton();
            this.ibt_stock = new Smobiler.Core.Controls.ImageButton();
            this.ibt_stock_src = new Smobiler.Core.Controls.ImageButton();
            this.ibt_stockLoc_src = new Smobiler.Core.Controls.ImageButton();
            this.cus_Titel1 = new 宝汇条码管理系统.UserContors.cus_Titel();
            this.cus_BarCodeScan1 = new 宝汇条码管理系统.UserContors.cus_BarCodeScan();
            // 
            // materialPanel
            // 
            this.materialPanel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lb_MaterialNumber,
            this.tx_MaterialId,
            this.label2,
            this.tx_MaterialName,
            this.tx_MaterialModel,
            this.label4,
            this.tx_AuxpropId,
            this.label3,
            this.label5,
            this.tx_lotId,
            this.label6,
            this.tx_stockId,
            this.label7,
            this.tx_stockLocId,
            this.label8,
            this.tx_stockId_desc,
            this.label9,
            this.tx_stockLocId_desc,
            this.label10,
            this.tx_UnitId,
            this.label11,
            this.tx_qty,
            this.label12,
            this.tx_auxUnitId,
            this.label13,
            this.tx_auxQty,
            this.label14,
            this.textBox14,
            this.ibt_flex,
            this.ibt_stockLoc,
            this.ibt_stock,
            this.ibt_stock_src,
            this.ibt_stockLoc_src});
            this.materialPanel.Flex = 70;
            this.materialPanel.Location = new System.Drawing.Point(0, 70);
            this.materialPanel.Name = "materialPanel";
            this.materialPanel.Scrollable = true;
            this.materialPanel.Size = new System.Drawing.Size(300, 685);
            // 
            // lb_MaterialNumber
            // 
            this.lb_MaterialNumber.Bold = true;
            this.lb_MaterialNumber.Flex = 15;
            this.lb_MaterialNumber.FontSize = 16F;
            this.lb_MaterialNumber.ForeColor = System.Drawing.Color.SkyBlue;
            this.lb_MaterialNumber.Location = new System.Drawing.Point(4, 3);
            this.lb_MaterialNumber.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.lb_MaterialNumber.Name = "lb_MaterialNumber";
            this.lb_MaterialNumber.Size = new System.Drawing.Size(65, 28);
            this.lb_MaterialNumber.Text = "物料编码";
            // 
            // tx_MaterialId
            // 
            this.tx_MaterialId.DataMember = "FMATERIALID";
            this.tx_MaterialId.DisplayMember = "FMATERIALNUMBER";
            this.tx_MaterialId.Flex = 85;
            this.tx_MaterialId.FontSize = 16F;
            this.tx_MaterialId.Location = new System.Drawing.Point(72, 3);
            this.tx_MaterialId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_MaterialId.Name = "tx_MaterialId";
            this.tx_MaterialId.ReadOnly = true;
            this.tx_MaterialId.Size = new System.Drawing.Size(218, 28);
            this.tx_MaterialId.ZIndex = 2;
            // 
            // label2
            // 
            this.label2.Bold = true;
            this.label2.Flex = 15;
            this.label2.FontSize = 16F;
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.Text = "物料名称";
            // 
            // tx_MaterialName
            // 
            this.tx_MaterialName.DisplayMember = "FMATERIALNAME";
            this.tx_MaterialName.Flex = 85;
            this.tx_MaterialName.FontSize = 16F;
            this.tx_MaterialName.Location = new System.Drawing.Point(72, 34);
            this.tx_MaterialName.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_MaterialName.Name = "tx_MaterialName";
            this.tx_MaterialName.ReadOnly = true;
            this.tx_MaterialName.Size = new System.Drawing.Size(218, 28);
            // 
            // tx_MaterialModel
            // 
            this.tx_MaterialModel.DisplayMember = "FMATERIALMODEL";
            this.tx_MaterialModel.Flex = 85;
            this.tx_MaterialModel.FontSize = 16F;
            this.tx_MaterialModel.Location = new System.Drawing.Point(72, 65);
            this.tx_MaterialModel.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_MaterialModel.Name = "tx_MaterialModel";
            this.tx_MaterialModel.ReadOnly = true;
            this.tx_MaterialModel.Size = new System.Drawing.Size(218, 28);
            // 
            // label4
            // 
            this.label4.Bold = true;
            this.label4.Flex = 15;
            this.label4.FontSize = 16F;
            this.label4.ForeColor = System.Drawing.Color.SkyBlue;
            this.label4.Location = new System.Drawing.Point(4, 96);
            this.label4.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.Text = "辅助属性";
            // 
            // tx_AuxpropId
            // 
            this.tx_AuxpropId.DataMember = "FAUXPROPID";
            this.tx_AuxpropId.DisplayMember = "FAUXPROPNAME";
            this.tx_AuxpropId.Flex = 85;
            this.tx_AuxpropId.FontSize = 16F;
            this.tx_AuxpropId.Location = new System.Drawing.Point(72, 96);
            this.tx_AuxpropId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_AuxpropId.Name = "tx_AuxpropId";
            this.tx_AuxpropId.ReadOnly = true;
            this.tx_AuxpropId.Size = new System.Drawing.Size(185, 28);
            // 
            // label3
            // 
            this.label3.Bold = true;
            this.label3.Flex = 15;
            this.label3.FontSize = 16F;
            this.label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.Text = "物料规格";
            // 
            // label5
            // 
            this.label5.Bold = true;
            this.label5.Flex = 15;
            this.label5.FontSize = 16F;
            this.label5.ForeColor = System.Drawing.Color.SkyBlue;
            this.label5.Location = new System.Drawing.Point(4, 127);
            this.label5.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 28);
            this.label5.Text = "批号";
            // 
            // tx_lotId
            // 
            this.tx_lotId.DataMember = "FLOT";
            this.tx_lotId.DisplayMember = "FLOT_TEXT";
            this.tx_lotId.Flex = 85;
            this.tx_lotId.FontSize = 16F;
            this.tx_lotId.Location = new System.Drawing.Point(72, 127);
            this.tx_lotId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_lotId.Name = "tx_lotId";
            this.tx_lotId.ReadOnly = true;
            this.tx_lotId.Size = new System.Drawing.Size(218, 28);
            // 
            // label6
            // 
            this.label6.Bold = true;
            this.label6.Flex = 15;
            this.label6.FontSize = 16F;
            this.label6.ForeColor = System.Drawing.Color.SkyBlue;
            this.label6.Location = new System.Drawing.Point(4, 158);
            this.label6.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 28);
            this.label6.Text = "调出仓库";
            // 
            // tx_stockId
            // 
            this.tx_stockId.DataMember = "FSTOCKID";
            this.tx_stockId.DisplayMember = "FSTOCKNAME";
            this.tx_stockId.Flex = 85;
            this.tx_stockId.FontSize = 16F;
            this.tx_stockId.Location = new System.Drawing.Point(72, 158);
            this.tx_stockId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_stockId.Name = "tx_stockId";
            this.tx_stockId.ReadOnly = true;
            this.tx_stockId.Size = new System.Drawing.Size(185, 28);
            // 
            // label7
            // 
            this.label7.Bold = true;
            this.label7.Flex = 15;
            this.label7.FontSize = 16F;
            this.label7.ForeColor = System.Drawing.Color.SkyBlue;
            this.label7.Location = new System.Drawing.Point(4, 189);
            this.label7.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 28);
            this.label7.Text = "调出仓位";
            // 
            // tx_stockLocId
            // 
            this.tx_stockLocId.DataMember = "FSTOCKLOCID";
            this.tx_stockLocId.DisplayMember = "FSTOCKLOCNAME";
            this.tx_stockLocId.Flex = 85;
            this.tx_stockLocId.FontSize = 16F;
            this.tx_stockLocId.Location = new System.Drawing.Point(72, 189);
            this.tx_stockLocId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_stockLocId.Name = "tx_stockLocId";
            this.tx_stockLocId.ReadOnly = true;
            this.tx_stockLocId.Size = new System.Drawing.Size(185, 28);
            // 
            // label8
            // 
            this.label8.Bold = true;
            this.label8.Flex = 15;
            this.label8.FontSize = 16F;
            this.label8.ForeColor = System.Drawing.Color.SkyBlue;
            this.label8.Location = new System.Drawing.Point(4, 220);
            this.label8.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 28);
            this.label8.Text = "调入仓库";
            // 
            // tx_stockId_desc
            // 
            this.tx_stockId_desc.DataMember = "FSTOCKID";
            this.tx_stockId_desc.DisplayMember = "FSTOCKNAME";
            this.tx_stockId_desc.Flex = 85;
            this.tx_stockId_desc.FontSize = 16F;
            this.tx_stockId_desc.Location = new System.Drawing.Point(72, 220);
            this.tx_stockId_desc.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_stockId_desc.Name = "tx_stockId_desc";
            this.tx_stockId_desc.Size = new System.Drawing.Size(185, 28);
            // 
            // label9
            // 
            this.label9.Bold = true;
            this.label9.Flex = 15;
            this.label9.FontSize = 16F;
            this.label9.ForeColor = System.Drawing.Color.SkyBlue;
            this.label9.Location = new System.Drawing.Point(4, 251);
            this.label9.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 28);
            this.label9.Text = "调入仓位";
            // 
            // tx_stockLocId_desc
            // 
            this.tx_stockLocId_desc.DataMember = "FSTOCKLOCID";
            this.tx_stockLocId_desc.DisplayMember = "FSTOCKLOCNAME";
            this.tx_stockLocId_desc.Flex = 85;
            this.tx_stockLocId_desc.FontSize = 16F;
            this.tx_stockLocId_desc.Location = new System.Drawing.Point(72, 251);
            this.tx_stockLocId_desc.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_stockLocId_desc.Name = "tx_stockLocId_desc";
            this.tx_stockLocId_desc.Size = new System.Drawing.Size(185, 28);
            // 
            // label10
            // 
            this.label10.Bold = true;
            this.label10.Flex = 15;
            this.label10.FontSize = 16F;
            this.label10.ForeColor = System.Drawing.Color.SkyBlue;
            this.label10.Location = new System.Drawing.Point(4, 282);
            this.label10.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 28);
            this.label10.Text = "主单位";
            // 
            // tx_UnitId
            // 
            this.tx_UnitId.DataMember = "FBASEUNITID";
            this.tx_UnitId.DisplayMember = "FBASEUNITNAME";
            this.tx_UnitId.Flex = 85;
            this.tx_UnitId.FontSize = 16F;
            this.tx_UnitId.Location = new System.Drawing.Point(72, 282);
            this.tx_UnitId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_UnitId.Name = "tx_UnitId";
            this.tx_UnitId.ReadOnly = true;
            this.tx_UnitId.Size = new System.Drawing.Size(218, 28);
            // 
            // label11
            // 
            this.label11.Bold = true;
            this.label11.Flex = 15;
            this.label11.FontSize = 16F;
            this.label11.ForeColor = System.Drawing.Color.SkyBlue;
            this.label11.Location = new System.Drawing.Point(4, 313);
            this.label11.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 28);
            this.label11.Text = "主数量";
            // 
            // tx_qty
            // 
            this.tx_qty.DisplayMember = "FQTY";
            this.tx_qty.Flex = 85;
            this.tx_qty.FontSize = 16F;
            this.tx_qty.Location = new System.Drawing.Point(72, 313);
            this.tx_qty.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_qty.Name = "tx_qty";
            this.tx_qty.Size = new System.Drawing.Size(218, 28);
            // 
            // label12
            // 
            this.label12.Bold = true;
            this.label12.Flex = 15;
            this.label12.FontSize = 16F;
            this.label12.ForeColor = System.Drawing.Color.SkyBlue;
            this.label12.Location = new System.Drawing.Point(4, 344);
            this.label12.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 28);
            this.label12.Text = "辅单位";
            // 
            // tx_auxUnitId
            // 
            this.tx_auxUnitId.DataMember = "FAUXUNITID";
            this.tx_auxUnitId.DisplayMember = "FAUXUNITNAME";
            this.tx_auxUnitId.Flex = 85;
            this.tx_auxUnitId.FontSize = 16F;
            this.tx_auxUnitId.Location = new System.Drawing.Point(72, 344);
            this.tx_auxUnitId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_auxUnitId.Name = "tx_auxUnitId";
            this.tx_auxUnitId.ReadOnly = true;
            this.tx_auxUnitId.Size = new System.Drawing.Size(218, 28);
            // 
            // label13
            // 
            this.label13.Bold = true;
            this.label13.Flex = 15;
            this.label13.FontSize = 16F;
            this.label13.ForeColor = System.Drawing.Color.SkyBlue;
            this.label13.Location = new System.Drawing.Point(4, 375);
            this.label13.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 28);
            this.label13.Text = "输数量";
            // 
            // tx_auxQty
            // 
            this.tx_auxQty.DisplayMember = "FAUXQTY";
            this.tx_auxQty.Flex = 85;
            this.tx_auxQty.FontSize = 16F;
            this.tx_auxQty.Location = new System.Drawing.Point(72, 375);
            this.tx_auxQty.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_auxQty.Name = "tx_auxQty";
            this.tx_auxQty.Size = new System.Drawing.Size(218, 28);
            // 
            // label14
            // 
            this.label14.Bold = true;
            this.label14.Flex = 15;
            this.label14.FontSize = 16F;
            this.label14.ForeColor = System.Drawing.Color.SkyBlue;
            this.label14.Location = new System.Drawing.Point(4, 406);
            this.label14.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 28);
            this.label14.Text = "label1";
            this.label14.Visible = false;
            // 
            // textBox14
            // 
            this.textBox14.Flex = 85;
            this.textBox14.FontSize = 16F;
            this.textBox14.Location = new System.Drawing.Point(72, 406);
            this.textBox14.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(218, 28);
            this.textBox14.Visible = false;
            // 
            // ibt_flex
            // 
            this.ibt_flex.BackColor = System.Drawing.Color.White;
            this.ibt_flex.Location = new System.Drawing.Point(257, 99);
            this.ibt_flex.Name = "ibt_flex";
            this.ibt_flex.ResourceID = "search3.jpeg";
            this.ibt_flex.Size = new System.Drawing.Size(33, 28);
            this.ibt_flex.Press += new System.EventHandler(this.ibt_flex_Press);
            // 
            // ibt_stockLoc
            // 
            this.ibt_stockLoc.BackColor = System.Drawing.Color.White;
            this.ibt_stockLoc.Location = new System.Drawing.Point(257, 254);
            this.ibt_stockLoc.Name = "ibt_stockLoc";
            this.ibt_stockLoc.ResourceID = "search3.jpeg";
            this.ibt_stockLoc.Size = new System.Drawing.Size(33, 28);
            this.ibt_stockLoc.Press += new System.EventHandler(this.ibt_stockLoc_Press);
            // 
            // ibt_stock
            // 
            this.ibt_stock.BackColor = System.Drawing.Color.White;
            this.ibt_stock.Location = new System.Drawing.Point(257, 223);
            this.ibt_stock.Name = "ibt_stock";
            this.ibt_stock.ResourceID = "search3.jpeg";
            this.ibt_stock.Size = new System.Drawing.Size(33, 28);
            this.ibt_stock.Press += new System.EventHandler(this.ibt_stock_Press);
            // 
            // ibt_stock_src
            // 
            this.ibt_stock_src.BackColor = System.Drawing.Color.White;
            this.ibt_stock_src.Location = new System.Drawing.Point(257, 161);
            this.ibt_stock_src.Name = "ibt_stock_src";
            this.ibt_stock_src.ResourceID = "search3.jpeg";
            this.ibt_stock_src.Size = new System.Drawing.Size(33, 28);
            this.ibt_stock_src.Press += new System.EventHandler(this.ibt_stock_src_Press);
            // 
            // ibt_stockLoc_src
            // 
            this.ibt_stockLoc_src.BackColor = System.Drawing.Color.White;
            this.ibt_stockLoc_src.Location = new System.Drawing.Point(257, 192);
            this.ibt_stockLoc_src.Name = "ibt_stockLoc_src";
            this.ibt_stockLoc_src.ResourceID = "search3.jpeg";
            this.ibt_stockLoc_src.Size = new System.Drawing.Size(33, 28);
            this.ibt_stockLoc_src.Press += new System.EventHandler(this.ibt_stockLoc_src_Press_1);
            // 
            // cus_Titel1
            // 
            this.cus_Titel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cus_Titel1.Location = new System.Drawing.Point(0, 52);
            this.cus_Titel1.Name = "cus_Titel1";
            this.cus_Titel1.Size = new System.Drawing.Size(300, 35);
            this.cus_Titel1.TitelText = "分条打包";
            // 
            // cus_BarCodeScan1
            // 
            this.cus_BarCodeScan1.barCodeText = "";
            this.cus_BarCodeScan1.Flex = 35;
            this.cus_BarCodeScan1.Location = new System.Drawing.Point(0, 35);
            this.cus_BarCodeScan1.Name = "cus_BarCodeScan1";
            this.cus_BarCodeScan1.Size = new System.Drawing.Size(300, 35);
            // 
            // PrdPinBao
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.materialPanel,
            this.cus_Titel1,
            this.cus_BarCodeScan1});
            this.Size = new System.Drawing.Size(300, 800);
            this.Name = "PrdPinBao";

        }
        #endregion

        private Smobiler.Core.Controls.Panel materialPanel;
        private Smobiler.Core.Controls.Label lb_MaterialNumber;
        private Smobiler.Core.Controls.TextBox tx_MaterialId;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox tx_MaterialName;
        private Smobiler.Core.Controls.TextBox tx_MaterialModel;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.TextBox tx_AuxpropId;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.TextBox tx_lotId;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.TextBox tx_stockId;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.TextBox tx_stockLocId;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.TextBox tx_stockId_desc;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.TextBox tx_stockLocId_desc;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.TextBox tx_UnitId;
        private Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.TextBox tx_qty;
        private Smobiler.Core.Controls.Label label12;
        private Smobiler.Core.Controls.TextBox tx_auxUnitId;
        private Smobiler.Core.Controls.Label label13;
        private Smobiler.Core.Controls.TextBox tx_auxQty;
        private Smobiler.Core.Controls.Label label14;
        private Smobiler.Core.Controls.TextBox textBox14;
        private Smobiler.Core.Controls.ImageButton ibt_flex;
        private Smobiler.Core.Controls.ImageButton ibt_stockLoc;
        private Smobiler.Core.Controls.ImageButton ibt_stock;
        private Smobiler.Core.Controls.ImageButton ibt_stock_src;
        private Smobiler.Core.Controls.ImageButton ibt_stockLoc_src;
        private UserContors.cus_Titel cus_Titel1;
        private UserContors.cus_BarCodeScan cus_BarCodeScan1;
    }
}