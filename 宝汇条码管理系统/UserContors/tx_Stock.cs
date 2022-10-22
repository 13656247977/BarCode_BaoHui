using ServiceHelper;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace 宝汇条码管理系统.UserContors
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    [System.ComponentModel.ToolboxItem(true)]
    partial class tx_Stock : Smobiler.Core.Controls.MobileUserControl
    {
        public tx_Stock() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        [Browsable(true), Category("Appearance"), DefaultValue("仓库"), Description("仓库LabelText")]
        public String LabelNumberText
        {
            set { this.lbNameTxt.Text = value; }
        }   

        [Browsable(true), Category("Appearance"), DefaultValue("True"), Description("编码TextBox只读")]
        public bool TxNumberReadOnly
        {
            set { this.tx_stockId.ReadOnly = value; }
        }

        public long StockId
        {
            get
            {
                return SParse.ToLong(this.tx_stockId.BindDataValue);
            }
        }
        public long StockName
        {
            get
            {
                return SParse.ToLong(this.tx_stockId.BindDisplayValue);
            }
        }
        private void ibt_stock_src_Press(object sender, EventArgs e)
        {

        }
    }
}