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
    partial class cus_Titel : Smobiler.Core.Controls.MobileUserControl
    {
        public cus_Titel() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        [Browsable(true), Category("Appearance"), Description("设置Titel文本")]
        public String TitelText
        {
            get { return this.label1.Text; }
            set { this.label1.Text = value; }
        }

        public event EventHandler reBackPress;
        private void reBack_Press(object sender, EventArgs e)
        {
            if (reBackPress != null)
            {
                reBackPress.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler morePress;
        private void more_Press(object sender, EventArgs e)
        {
            if (morePress != null)
            {
                morePress.Invoke(this, EventArgs.Empty);
            }
        }
    }
}