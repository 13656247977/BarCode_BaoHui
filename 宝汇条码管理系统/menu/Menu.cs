using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 宝汇条码管理系统.menu
{
    partial class Menu : Smobiler.Core.Controls.MobileForm
    {
        public Menu() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {

        }

        private void im_ckgl_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "XSCK":
                    this.Show(new Out_Stock());
                    break;
                //case "sp_Prick":  //生产领料
                //    this.Show(new Sp_PickMtr());
                //    break;
                //case "打包":
                //    this.Show(new PrdPinBao());
                //    break;
                //case "拆包":
                //    this.Show(new StocklocTransfer());
                //    break;
            }
        }

        private void im_xsgl_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "XSCK":
                    this.Show(new Out_Stock());
                    break;
                    //case "sp_Prick":  //生产领料
                    //    this.Show(new Sp_PickMtr());
                    //    break;
                    //case "打包":
                    //    this.Show(new PrdPinBao());
                    //    break;
                    //case "拆包":
                    //    this.Show(new StocklocTransfer());
                    //    break;
            }
        }
    }
}