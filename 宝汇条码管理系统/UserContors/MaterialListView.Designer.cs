using Smobiler.Core;
using System;

namespace 宝汇条码管理系统.UserContors
{
    partial class MaterialListView : Smobiler.Core.Controls.MobileUserControl
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
            this.label2 = new Smobiler.Core.Controls.Label();
            this.tx_MaterialName = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.tx_MaterialModel = new Smobiler.Core.Controls.TextBox();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.tx_AuxpropId = new Smobiler.Core.Controls.TextBox();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.tx_lotId = new Smobiler.Core.Controls.TextBox();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.tx_stockId = new Smobiler.Core.Controls.TextBox();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.tx_stockLocId = new Smobiler.Core.Controls.TextBox();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.tx_UnitId = new Smobiler.Core.Controls.TextBox();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.tx_qty = new Smobiler.Core.Controls.TextBox();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.tx_auxUnitId = new Smobiler.Core.Controls.TextBox();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.tx_auxQty = new Smobiler.Core.Controls.TextBox();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lb_MaterialNumber,
            this.tx_MaterialId,
            this.label2,
            this.tx_MaterialName,
            this.label3,
            this.tx_MaterialModel,
            this.label4,
            this.tx_AuxpropId,
            this.label5,
            this.tx_lotId,
            this.label6,
            this.tx_stockId,
            this.label7,
            this.tx_stockLocId,
            this.label10,
            this.tx_UnitId,
            this.label11,
            this.tx_qty,
            this.label12,
            this.tx_auxUnitId,
            this.label13,
            this.tx_auxQty});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 459);
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
            this.lb_MaterialNumber.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.lb_MaterialNumber.Name = "lb_MaterialNumber";
            this.lb_MaterialNumber.Size = new System.Drawing.Size(60, 28);
            this.lb_MaterialNumber.Text = "编码";
            // 
            // tx_MaterialId
            // 
            this.tx_MaterialId.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_MaterialId.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_MaterialId.DataMember = "FMATERIALID";
            this.tx_MaterialId.DisplayMember = "FMATERIALNUMBER";
            this.tx_MaterialId.Flex = 85;
            this.tx_MaterialId.FontSize = 16F;
            this.tx_MaterialId.Location = new System.Drawing.Point(63, 0);
            this.tx_MaterialId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_MaterialId.Name = "tx_MaterialId";
            this.tx_MaterialId.ReadOnly = true;
            this.tx_MaterialId.Size = new System.Drawing.Size(223, 28);
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
            this.label2.Location = new System.Drawing.Point(0, 31);
            this.label2.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.Text = "品名";
            // 
            // tx_MaterialName
            // 
            this.tx_MaterialName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_MaterialName.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_MaterialName.DisplayMember = "FMATERIALNAME";
            this.tx_MaterialName.Flex = 85;
            this.tx_MaterialName.FontSize = 16F;
            this.tx_MaterialName.Location = new System.Drawing.Point(63, 31);
            this.tx_MaterialName.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_MaterialName.Name = "tx_MaterialName";
            this.tx_MaterialName.ReadOnly = true;
            this.tx_MaterialName.Size = new System.Drawing.Size(223, 28);
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
            this.label3.Location = new System.Drawing.Point(0, 62);
            this.label3.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.Text = "规格";
            // 
            // tx_MaterialModel
            // 
            this.tx_MaterialModel.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_MaterialModel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_MaterialModel.DisplayMember = "FMATERIALMODEL";
            this.tx_MaterialModel.Flex = 85;
            this.tx_MaterialModel.FontSize = 16F;
            this.tx_MaterialModel.Location = new System.Drawing.Point(63, 62);
            this.tx_MaterialModel.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_MaterialModel.Name = "tx_MaterialModel";
            this.tx_MaterialModel.ReadOnly = true;
            this.tx_MaterialModel.Size = new System.Drawing.Size(223, 28);
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
            this.label4.Location = new System.Drawing.Point(0, 93);
            this.label4.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.Text = "属性";
            // 
            // tx_AuxpropId
            // 
            this.tx_AuxpropId.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_AuxpropId.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_AuxpropId.DataMember = "FAUXPROPID";
            this.tx_AuxpropId.DisplayMember = "FCZNAME";
            this.tx_AuxpropId.Flex = 85;
            this.tx_AuxpropId.FontSize = 16F;
            this.tx_AuxpropId.Location = new System.Drawing.Point(63, 93);
            this.tx_AuxpropId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_AuxpropId.Name = "tx_AuxpropId";
            this.tx_AuxpropId.ReadOnly = true;
            this.tx_AuxpropId.Size = new System.Drawing.Size(223, 28);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Bold = true;
            this.label5.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label5.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Flex = 15;
            this.label5.FontSize = 14F;
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(0, 124);
            this.label5.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 28);
            this.label5.Text = "批号";
            // 
            // tx_lotId
            // 
            this.tx_lotId.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_lotId.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_lotId.Flex = 85;
            this.tx_lotId.FontSize = 16F;
            this.tx_lotId.Location = new System.Drawing.Point(63, 124);
            this.tx_lotId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_lotId.Name = "tx_lotId";
            this.tx_lotId.ReadOnly = true;
            this.tx_lotId.Size = new System.Drawing.Size(223, 28);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Bold = true;
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label6.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Flex = 15;
            this.label6.FontSize = 14F;
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(0, 155);
            this.label6.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 28);
            this.label6.Text = "仓库";
            // 
            // tx_stockId
            // 
            this.tx_stockId.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_stockId.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_stockId.Flex = 85;
            this.tx_stockId.FontSize = 16F;
            this.tx_stockId.Location = new System.Drawing.Point(63, 155);
            this.tx_stockId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_stockId.Name = "tx_stockId";
            this.tx_stockId.ReadOnly = true;
            this.tx_stockId.Size = new System.Drawing.Size(223, 28);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Bold = true;
            this.label7.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label7.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Flex = 15;
            this.label7.FontSize = 14F;
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(0, 186);
            this.label7.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 28);
            this.label7.Text = "仓位";
            // 
            // tx_stockLocId
            // 
            this.tx_stockLocId.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_stockLocId.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_stockLocId.Flex = 85;
            this.tx_stockLocId.FontSize = 16F;
            this.tx_stockLocId.Location = new System.Drawing.Point(63, 186);
            this.tx_stockLocId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_stockLocId.Name = "tx_stockLocId";
            this.tx_stockLocId.ReadOnly = true;
            this.tx_stockLocId.Size = new System.Drawing.Size(223, 28);
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
            this.label10.Location = new System.Drawing.Point(0, 217);
            this.label10.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 28);
            this.label10.Text = "主单位";
            // 
            // tx_UnitId
            // 
            this.tx_UnitId.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_UnitId.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_UnitId.Flex = 85;
            this.tx_UnitId.FontSize = 16F;
            this.tx_UnitId.Location = new System.Drawing.Point(63, 217);
            this.tx_UnitId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_UnitId.Name = "tx_UnitId";
            this.tx_UnitId.ReadOnly = true;
            this.tx_UnitId.Size = new System.Drawing.Size(223, 28);
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
            this.label11.Location = new System.Drawing.Point(0, 248);
            this.label11.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 28);
            this.label11.Text = "主数量";
            // 
            // tx_qty
            // 
            this.tx_qty.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_qty.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_qty.Flex = 85;
            this.tx_qty.FontSize = 16F;
            this.tx_qty.Location = new System.Drawing.Point(63, 248);
            this.tx_qty.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_qty.Name = "tx_qty";
            this.tx_qty.Size = new System.Drawing.Size(223, 28);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Bold = true;
            this.label12.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label12.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Flex = 15;
            this.label12.FontSize = 14F;
            this.label12.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label12.Location = new System.Drawing.Point(0, 279);
            this.label12.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 28);
            this.label12.Text = "辅单位";
            // 
            // tx_auxUnitId
            // 
            this.tx_auxUnitId.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_auxUnitId.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_auxUnitId.Flex = 85;
            this.tx_auxUnitId.FontSize = 16F;
            this.tx_auxUnitId.Location = new System.Drawing.Point(63, 279);
            this.tx_auxUnitId.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_auxUnitId.Name = "tx_auxUnitId";
            this.tx_auxUnitId.ReadOnly = true;
            this.tx_auxUnitId.Size = new System.Drawing.Size(223, 28);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Bold = true;
            this.label13.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label13.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Flex = 15;
            this.label13.FontSize = 14F;
            this.label13.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Location = new System.Drawing.Point(0, 310);
            this.label13.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 28);
            this.label13.Text = "输数量";
            // 
            // tx_auxQty
            // 
            this.tx_auxQty.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tx_auxQty.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tx_auxQty.Flex = 85;
            this.tx_auxQty.FontSize = 16F;
            this.tx_auxQty.Location = new System.Drawing.Point(63, 310);
            this.tx_auxQty.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_auxQty.Name = "tx_auxQty";
            this.tx_auxQty.Size = new System.Drawing.Size(223, 28);
            // 
            // MaterialListView
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(0, 450);
            this.Load += new System.EventHandler(this.MaterialListView_Load);
            this.Name = "MaterialListView";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label lb_MaterialNumber;
        private Smobiler.Core.Controls.TextBox tx_MaterialId;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox tx_MaterialName;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.TextBox tx_MaterialModel;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.TextBox tx_AuxpropId;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.TextBox tx_lotId;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.TextBox tx_stockId;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.TextBox tx_stockLocId;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.TextBox tx_UnitId;
        private Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.TextBox tx_qty;
        private Smobiler.Core.Controls.Label label12;
        private Smobiler.Core.Controls.TextBox tx_auxUnitId;
        private Smobiler.Core.Controls.Label label13;
        private Smobiler.Core.Controls.TextBox tx_auxQty;
    }
}