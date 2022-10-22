using Smobiler.Core;
using System;

namespace 宝汇条码管理系统.UserContors
{
    partial class BillListTreeView : Smobiler.Core.Controls.MobileUserControl
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
            this.lb_MaterialNumber = new Smobiler.Core.Controls.Label();
            this.tx_MaterialId = new Smobiler.Core.Controls.TextBox();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.tx_AuxpropId = new Smobiler.Core.Controls.TextBox();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.tx_UnitId = new Smobiler.Core.Controls.TextBox();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.tx_qty = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.tx_BillNo = new Smobiler.Core.Controls.TextBox();
            this.tx_BillSeq = new Smobiler.Core.Controls.TextBox();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.tx_Cust = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.tx_JH = new Smobiler.Core.Controls.TextBox();
            this.ck_scanBar = new Smobiler.Core.Controls.CheckBox();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 2F);
            this.panel1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lb_MaterialNumber,
            this.tx_MaterialId,
            this.label4,
            this.tx_AuxpropId,
            this.label10,
            this.tx_UnitId,
            this.label11,
            this.tx_qty,
            this.label1,
            this.tx_BillNo,
            this.tx_BillSeq,
            this.label2,
            this.tx_Cust,
            this.label3,
            this.tx_JH,
            this.ck_scanBar});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 190);
            // 
            // lb_MaterialNumber
            // 
            this.lb_MaterialNumber.BackColor = System.Drawing.Color.White;
            this.lb_MaterialNumber.Bold = true;
            this.lb_MaterialNumber.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lb_MaterialNumber.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.lb_MaterialNumber.Flex = 15;
            this.lb_MaterialNumber.FontSize = 14F;
            this.lb_MaterialNumber.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lb_MaterialNumber.Location = new System.Drawing.Point(0, 84);
            this.lb_MaterialNumber.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.lb_MaterialNumber.Name = "lb_MaterialNumber";
            this.lb_MaterialNumber.Size = new System.Drawing.Size(37, 28);
            this.lb_MaterialNumber.Text = "物料";
            // 
            // tx_MaterialId
            // 
            this.tx_MaterialId.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_MaterialId.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_MaterialId.DataMember = "FMATERIALID";
            this.tx_MaterialId.DisplayMember = "FMATERIALNUMBER";
            this.tx_MaterialId.Flex = 85;
            this.tx_MaterialId.FontSize = 16F;
            this.tx_MaterialId.Location = new System.Drawing.Point(40, 84);
            this.tx_MaterialId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_MaterialId.Name = "tx_MaterialId";
            this.tx_MaterialId.ReadOnly = true;
            this.tx_MaterialId.Size = new System.Drawing.Size(255, 28);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Bold = true;
            this.label4.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label4.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Flex = 15;
            this.label4.FontSize = 14F;
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(0, 116);
            this.label4.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 32);
            this.label4.Text = "属性";
            // 
            // tx_AuxpropId
            // 
            this.tx_AuxpropId.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_AuxpropId.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_AuxpropId.DataMember = "FAUXPROPID";
            this.tx_AuxpropId.DisplayMember = "FAUXPROPNAME";
            this.tx_AuxpropId.Flex = 85;
            this.tx_AuxpropId.FontSize = 16F;
            this.tx_AuxpropId.Location = new System.Drawing.Point(40, 116);
            this.tx_AuxpropId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_AuxpropId.Name = "tx_AuxpropId";
            this.tx_AuxpropId.ReadOnly = true;
            this.tx_AuxpropId.Size = new System.Drawing.Size(255, 32);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Bold = true;
            this.label10.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label10.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Flex = 15;
            this.label10.FontSize = 14F;
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(0, 154);
            this.label10.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 28);
            this.label10.Text = "单位";
            // 
            // tx_UnitId
            // 
            this.tx_UnitId.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_UnitId.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_UnitId.DataMember = "FUNITID";
            this.tx_UnitId.DisplayMember = "FUNITNAME";
            this.tx_UnitId.Flex = 85;
            this.tx_UnitId.FontSize = 16F;
            this.tx_UnitId.Location = new System.Drawing.Point(40, 154);
            this.tx_UnitId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_UnitId.Name = "tx_UnitId";
            this.tx_UnitId.ReadOnly = true;
            this.tx_UnitId.Size = new System.Drawing.Size(42, 28);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Bold = true;
            this.label11.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label11.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Flex = 15;
            this.label11.FontSize = 14F;
            this.label11.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label11.Location = new System.Drawing.Point(85, 154);
            this.label11.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 28);
            this.label11.Text = "数量";
            // 
            // tx_qty
            // 
            this.tx_qty.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_qty.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_qty.DataMember = "FQTY";
            this.tx_qty.DisplayMember = "FQTY";
            this.tx_qty.Flex = 85;
            this.tx_qty.FontSize = 16F;
            this.tx_qty.Location = new System.Drawing.Point(126, 154);
            this.tx_qty.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_qty.Name = "tx_qty";
            this.tx_qty.Size = new System.Drawing.Size(106, 28);
            this.tx_qty.ValueType = Smobiler.Core.Controls.InputValueType.Number;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Bold = true;
            this.label1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Flex = 15;
            this.label1.FontSize = 14F;
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 27);
            this.label1.Text = "单号";
            // 
            // tx_BillNo
            // 
            this.tx_BillNo.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_BillNo.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_BillNo.DataMember = "FID";
            this.tx_BillNo.DisplayMember = "FBILLNO";
            this.tx_BillNo.Flex = 85;
            this.tx_BillNo.FontSize = 16F;
            this.tx_BillNo.Location = new System.Drawing.Point(40, 27);
            this.tx_BillNo.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_BillNo.Name = "tx_BillNo";
            this.tx_BillNo.ReadOnly = true;
            this.tx_BillNo.Size = new System.Drawing.Size(192, 27);
            // 
            // tx_BillSeq
            // 
            this.tx_BillSeq.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_BillSeq.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_BillSeq.DataMember = "FENTRYID";
            this.tx_BillSeq.DisplayMember = "FSEQ";
            this.tx_BillSeq.Flex = 85;
            this.tx_BillSeq.FontSize = 16F;
            this.tx_BillSeq.Location = new System.Drawing.Point(232, 27);
            this.tx_BillSeq.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_BillSeq.Name = "tx_BillSeq";
            this.tx_BillSeq.ReadOnly = true;
            this.tx_BillSeq.Size = new System.Drawing.Size(63, 27);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Bold = true;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Flex = 15;
            this.label2.FontSize = 14F;
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 28);
            this.label2.Text = "客户";
            // 
            // tx_Cust
            // 
            this.tx_Cust.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_Cust.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_Cust.DataMember = "FCUSTID";
            this.tx_Cust.DisplayMember = "FCUSTNAME";
            this.tx_Cust.Flex = 85;
            this.tx_Cust.FontSize = 16F;
            this.tx_Cust.Location = new System.Drawing.Point(40, 0);
            this.tx_Cust.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_Cust.Name = "tx_Cust";
            this.tx_Cust.ReadOnly = true;
            this.tx_Cust.Size = new System.Drawing.Size(255, 28);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Bold = true;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Flex = 15;
            this.label3.FontSize = 14F;
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(0, 56);
            this.label3.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 28);
            this.label3.Text = "卷号";
            // 
            // tx_JH
            // 
            this.tx_JH.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_JH.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_JH.DataMember = "FZZ_JH";
            this.tx_JH.DisplayMember = "FZZ_JH";
            this.tx_JH.Flex = 85;
            this.tx_JH.FontSize = 16F;
            this.tx_JH.Location = new System.Drawing.Point(40, 56);
            this.tx_JH.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_JH.Name = "tx_JH";
            this.tx_JH.ReadOnly = true;
            this.tx_JH.Size = new System.Drawing.Size(255, 28);
            // 
            // ck_scanBar
            // 
            this.ck_scanBar.Location = new System.Drawing.Point(262, 163);
            this.ck_scanBar.Name = "ck_scanBar";
            this.ck_scanBar.Size = new System.Drawing.Size(22, 22);
            // 
            // BillListTreeView
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(0, 192);
            this.Load += new System.EventHandler(this.MaterialListView_Load);
            this.Name = "BillListTreeView";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label lb_MaterialNumber;
        private Smobiler.Core.Controls.TextBox tx_MaterialId;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.TextBox tx_AuxpropId;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.TextBox tx_UnitId;
        private Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.TextBox tx_qty;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TextBox tx_BillNo;
        private Smobiler.Core.Controls.TextBox tx_BillSeq;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox tx_Cust;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.TextBox tx_JH;
        private Smobiler.Core.Controls.CheckBox ck_scanBar;
    }
}