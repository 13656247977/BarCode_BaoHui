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
    partial class tx_Material : Smobiler.Core.Controls.MobileUserControl
    {
        public tx_Material() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        [Browsable(true), Category("Appearance"), DefaultValue("物料编码"), Description("编码LabelText")]
        public String LabelNumberText
        {
            set { this.lb_MaterialNumber.Text = value; }
        }
        [Browsable(true), Category("Appearance"), DefaultValue("物料名称"), Description("名称LabelText")]
        public String LabelNameText
        {
            set { this.lb_materialName.Text = value; }
        }
        [Browsable(true), Category("Appearance"), DefaultValue("物料规格"), Description("规格LabelText")]
        public String LabelModelText
        {
            set { this.lb_MaterialModel.Text = value; }
        }
        [Browsable(true), Category("Appearance"), DefaultValue("True"), Description("编码TextBox只读")]
        public bool TxNumberReadOnly
        {
            set { this.tx_MaterialId.ReadOnly = value; }
        }

        public long MaterialId
        {
            get
            {
                return SParse.ToLong(this.tx_MaterialId.BindDataValue);
            }
        }
        private void ibt_Material_Press(object sender, EventArgs e)
        {

        }
    }
}