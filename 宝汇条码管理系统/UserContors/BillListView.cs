using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace 宝汇条码管理系统.UserContors
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class BillListView : Smobiler.Core.Controls.MobileUserControl
    {
        public BillListView() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void MaterialListView_Load(object sender, EventArgs e)
        {

        }
    }
}