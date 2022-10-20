using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 宝汇条码管理系统.Inventory;
using 宝汇条码管理系统.Product;

namespace 宝汇条码管理系统.menu
{
    partial class mainMenu : Smobiler.Core.Controls.MobileForm
    {
        public mainMenu() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            
        }
        /// <summary>
        /// 菜单组点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listMenu_ItemActionPress(object sender, ListMenuViewItemPressEventArgs e)
        {

        }
        /// <summary>
        /// 菜单点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listMenu_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            switch(e.Item.Name)
            {
                case "转库单":
                    this.Show(new StocklocTransfer());
                    break;
                case "sp_Prick":  //生产领料
                    this.Show(new Sp_PickMtr());
                    break;
                case "打包":
                    this.Show(new PrdPinBao());
                    break;
                case "拆包":
                    this.Show(new StocklocTransfer());
                    break;
            }
        }
        /// <summary>
        /// 底部菜单点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuBar_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            
        }
    }
}