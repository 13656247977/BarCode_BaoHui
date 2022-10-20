using Smobiler.Core;
using System;

namespace 宝汇条码管理系统.UserContors
{
    partial class cus_BarCodeScan : Smobiler.Core.Controls.MobileUserControl
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
            this.tb_Barcode = new Smobiler.Core.Controls.BarcodeScannerButton();
            this.txt_Barcode = new Smobiler.Core.Controls.TextBox();
            this.ok = new Smobiler.Core.Controls.ImageButton();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tb_Barcode,
            this.txt_Barcode});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(49, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            // 
            // tb_Barcode
            // 
            this.tb_Barcode.Flex = 5;
            this.tb_Barcode.FontSize = 16F;
            this.tb_Barcode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_Barcode.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.tb_Barcode.ImgTextRatio = new Smobiler.Core.Controls.Ratio(0, 10);
            this.tb_Barcode.Location = new System.Drawing.Point(0, 2);
            this.tb_Barcode.Name = "tb_Barcode";
            this.tb_Barcode.Size = new System.Drawing.Size(30, 30);
            this.tb_Barcode.Text = "条码";
            this.tb_Barcode.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.tb_Barcode_BarcodeScanned);
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.Bold = true;
            this.txt_Barcode.Flex = 90;
            this.txt_Barcode.FontSize = 16F;
            this.txt_Barcode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_Barcode.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.txt_Barcode.Location = new System.Drawing.Point(30, 2);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.SelectOnFocus = true;
            this.txt_Barcode.Size = new System.Drawing.Size(240, 30);
            this.txt_Barcode.WaterMarkText = "请扫描条码...";
            this.txt_Barcode.ZIndex = 1;
            // 
            // ok
            // 
            this.ok.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ok.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.ok.Location = new System.Drawing.Point(270, 2);
            this.ok.Name = "ok";
            this.ok.ResourceID = "md-return-left";
            this.ok.Size = new System.Drawing.Size(30, 30);
            this.ok.Press += new System.EventHandler(this.ok_Press);
            // 
            // cus_BarCodeScan
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.ok});
            this.Size = new System.Drawing.Size(300, 35);
            this.Name = "cus_BarCodeScan";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.BarcodeScannerButton tb_Barcode;
        private Smobiler.Core.Controls.TextBox txt_Barcode;
        private Smobiler.Core.Controls.ImageButton ok;
    }
}