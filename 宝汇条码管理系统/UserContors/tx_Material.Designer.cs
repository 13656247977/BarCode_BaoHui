using Smobiler.Core;
using System;

namespace 宝汇条码管理系统.UserContors
{
    partial class tx_Material : Smobiler.Core.Controls.MobileUserControl
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
            this.lb_MaterialNumber = new Smobiler.Core.Controls.Label();
            this.lb_materialName = new Smobiler.Core.Controls.Label();
            this.lb_MaterialModel = new Smobiler.Core.Controls.Label();
            this.tx_MaterialModel = new Smobiler.Core.Controls.TextBox();
            this.tx_MaterialName = new Smobiler.Core.Controls.TextBox();
            this.tx_MaterialId = new Smobiler.Core.Controls.TextBox();
            this.ibt_Material = new Smobiler.Core.Controls.ImageButton();
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
            // lb_materialName
            // 
            this.lb_materialName.Bold = true;
            this.lb_materialName.Flex = 15;
            this.lb_materialName.FontSize = 16F;
            this.lb_materialName.ForeColor = System.Drawing.Color.SkyBlue;
            this.lb_materialName.Location = new System.Drawing.Point(4, 31);
            this.lb_materialName.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.lb_materialName.Name = "lb_materialName";
            this.lb_materialName.Size = new System.Drawing.Size(65, 28);
            this.lb_materialName.Text = "物料名称";
            // 
            // lb_MaterialModel
            // 
            this.lb_MaterialModel.Bold = true;
            this.lb_MaterialModel.Flex = 15;
            this.lb_MaterialModel.FontSize = 16F;
            this.lb_MaterialModel.ForeColor = System.Drawing.Color.SkyBlue;
            this.lb_MaterialModel.Location = new System.Drawing.Point(4, 59);
            this.lb_MaterialModel.Margin = new Smobiler.Core.Controls.Margin(3F, 3F, 0F, 0F);
            this.lb_MaterialModel.Name = "lb_MaterialModel";
            this.lb_MaterialModel.Size = new System.Drawing.Size(65, 28);
            this.lb_MaterialModel.Text = "物料规格";
            // 
            // tx_MaterialModel
            // 
            this.tx_MaterialModel.DisplayMember = "FMATERIALMODEL";
            this.tx_MaterialModel.Flex = 85;
            this.tx_MaterialModel.FontSize = 16F;
            this.tx_MaterialModel.Location = new System.Drawing.Point(72, 59);
            this.tx_MaterialModel.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_MaterialModel.Name = "tx_MaterialModel";
            this.tx_MaterialModel.ReadOnly = true;
            this.tx_MaterialModel.Size = new System.Drawing.Size(218, 28);
            // 
            // tx_MaterialName
            // 
            this.tx_MaterialName.DisplayMember = "FMATERIALNAME";
            this.tx_MaterialName.Flex = 85;
            this.tx_MaterialName.FontSize = 16F;
            this.tx_MaterialName.Location = new System.Drawing.Point(72, 31);
            this.tx_MaterialName.Margin = new Smobiler.Core.Controls.Margin(0F, 3F, 0F, 0F);
            this.tx_MaterialName.Name = "tx_MaterialName";
            this.tx_MaterialName.ReadOnly = true;
            this.tx_MaterialName.Size = new System.Drawing.Size(218, 28);
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
            this.tx_MaterialId.SelectOnFocus = true;
            this.tx_MaterialId.Size = new System.Drawing.Size(188, 28);
            this.tx_MaterialId.ZIndex = 2;
            // 
            // ibt_Material
            // 
            this.ibt_Material.BackColor = System.Drawing.Color.SteelBlue;
            this.ibt_Material.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.ibt_Material.Location = new System.Drawing.Point(260, 6);
            this.ibt_Material.Name = "ibt_Material";
            this.ibt_Material.ResourceID = "search";
            this.ibt_Material.Size = new System.Drawing.Size(30, 28);
            this.ibt_Material.Press += new System.EventHandler(this.ibt_Material_Press);
            // 
            // tx_Material
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lb_MaterialNumber,
            this.lb_materialName,
            this.lb_MaterialModel,
            this.tx_MaterialModel,
            this.tx_MaterialName,
            this.tx_MaterialId,
            this.ibt_Material});
            this.Size = new System.Drawing.Size(300, 93);
            this.Name = "tx_Material";

        }
        #endregion

        private Smobiler.Core.Controls.Label lb_MaterialNumber;
        private Smobiler.Core.Controls.Label lb_materialName;
        private Smobiler.Core.Controls.Label lb_MaterialModel;
        private Smobiler.Core.Controls.TextBox tx_MaterialModel;
        private Smobiler.Core.Controls.TextBox tx_MaterialName;
        private Smobiler.Core.Controls.TextBox tx_MaterialId;
        private Smobiler.Core.Controls.ImageButton ibt_Material;
    }
}