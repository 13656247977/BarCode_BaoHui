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
    partial class Search : Smobiler.Core.Controls.MobileUserControl
    {
        public event EventHandler SearchButtonPress;
        public Search() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        [Browsable(true),Category("Appearance"),Description("获取/设置搜索框水印文字")]
        public String WaterMarkText
        {
            get { return this.tx_searchStr.WaterMarkText; }
            set { this.tx_searchStr.WaterMarkText = value; }
        }
        /// <summary>
        /// 读写搜索框内容文本
        /// </summary>
        public String SearchText
        {
            get { return this.tx_searchStr.Text; }
            set { this.tx_searchStr.Text = value; }
        }

        private void ibt_Search_Press(object sender, EventArgs e)
        {
            if(SearchButtonPress !=null)
            {
                SearchButtonPress.Invoke(this,EventArgs.Empty);
            }
        }
    }
}