using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 宝汇条码管理系统.UserContors
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    [System.ComponentModel.ToolboxItem(true)]
    partial class cus_BarCodeScan : Smobiler.Core.Controls.MobileUserControl
    {
        public cus_BarCodeScan() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public String barCodeText
        {
            get { return this.txt_Barcode.Text; }
            set { this.txt_Barcode.Text = value; }
        }

        public event EventHandler barCodeOkPress;
        private void ok_Press(object sender, EventArgs e)
        {
            if (barCodeOkPress != null)
            {
                barCodeOkPress.Invoke(this, EventArgs.Empty);
            }
        }
        private void tb_Barcode_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            this.txt_Barcode.Text = "";
            this.txt_Barcode.Text = e.Value;
        }
    }
}