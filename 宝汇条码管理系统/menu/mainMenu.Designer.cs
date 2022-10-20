using Smobiler.Core;
using System;

namespace 宝汇条码管理系统.menu
{
    partial class mainMenu : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem3 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ListMenuViewGroup listMenuViewGroup1 = new Smobiler.Core.Controls.ListMenuViewGroup();
            Smobiler.Core.Controls.ListMenuViewItem listMenuViewItem1 = new Smobiler.Core.Controls.ListMenuViewItem();
            Smobiler.Core.Controls.ListMenuViewItem listMenuViewItem2 = new Smobiler.Core.Controls.ListMenuViewItem();
            Smobiler.Core.Controls.ListMenuViewGroup listMenuViewGroup2 = new Smobiler.Core.Controls.ListMenuViewGroup();
            Smobiler.Core.Controls.ListMenuViewItem listMenuViewItem3 = new Smobiler.Core.Controls.ListMenuViewItem();
            Smobiler.Core.Controls.ListMenuViewItem listMenuViewItem4 = new Smobiler.Core.Controls.ListMenuViewItem();
            Smobiler.Core.Controls.ListMenuViewGroup listMenuViewGroup3 = new Smobiler.Core.Controls.ListMenuViewGroup();
            Smobiler.Core.Controls.ListMenuViewItem listMenuViewItem5 = new Smobiler.Core.Controls.ListMenuViewItem();
            Smobiler.Core.Controls.ListMenuViewItem listMenuViewItem6 = new Smobiler.Core.Controls.ListMenuViewItem();
            this.功能菜单 = new Smobiler.Core.Controls.Title();
            this.menuBar = new Smobiler.Core.Controls.ToolBar();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.listMenu = new Smobiler.Core.Controls.ListMenuView();
            // 
            // 功能菜单
            // 
            this.功能菜单.BackColor = System.Drawing.Color.MediumTurquoise;
            this.功能菜单.BorderColor = System.Drawing.Color.White;
            this.功能菜单.FontSize = 16F;
            this.功能菜单.Location = new System.Drawing.Point(30, 9);
            this.功能菜单.Name = "功能菜单";
            this.功能菜单.Size = new System.Drawing.Size(100, 30);
            this.功能菜单.Text = "功能菜单";
            // 
            // menuBar
            // 
            toolBarItem1.MessageText = "菜单";
            toolBarItem1.Name = "mainMenu";
            toolBarItem1.SelectIconColor = System.Drawing.Color.MediumTurquoise;
            toolBarItem1.Text = "菜单";
            toolBarItem2.MessageText = "设置";
            toolBarItem2.Name = "settings";
            toolBarItem2.Text = "设置";
            toolBarItem3.Name = "close";
            toolBarItem3.Text = "关闭";
            this.menuBar.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2,
            toolBarItem3});
            this.menuBar.Location = new System.Drawing.Point(54, 480);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(100, 30);
            this.menuBar.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.menuBar_ToolbarItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listMenu});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(9, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 222);
            // 
            // listMenu
            // 
            this.listMenu.BackColor = System.Drawing.Color.White;
            this.listMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMenu.GroupBackColor = System.Drawing.Color.LightSkyBlue;
            this.listMenu.GroupFontSize = 16;
            listMenuViewGroup1.IconBorderRadius = 0;
            listMenuViewItem1.Content = "转库单";
            listMenuViewItem1.ContentFontSize = 20F;
            listMenuViewItem1.Name = "转库单";
            listMenuViewItem2.Content = "状态转换";
            listMenuViewItem2.ContentFontSize = 20F;
            listMenuViewItem2.Name = "状态转换";
            listMenuViewGroup1.Items.AddRange(new Smobiler.Core.Controls.ListMenuViewItem[] {
            listMenuViewItem1,
            listMenuViewItem2});
            listMenuViewGroup1.Title = "库存管理";
            listMenuViewGroup2.IconBorderRadius = 0;
            listMenuViewItem3.Content = "生产领料";
            listMenuViewItem3.ContentFontSize = 20F;
            listMenuViewItem3.Name = "sp_Prick";
            listMenuViewItem4.Content = "生产入库";
            listMenuViewItem4.ContentFontSize = 20F;
            listMenuViewItem4.Name = "sp_Instock";
            listMenuViewGroup2.Items.AddRange(new Smobiler.Core.Controls.ListMenuViewItem[] {
            listMenuViewItem3,
            listMenuViewItem4});
            listMenuViewGroup2.Title = "生产管理";
            listMenuViewGroup3.IconBorderRadius = 0;
            listMenuViewItem5.Content = "打包";
            listMenuViewItem5.ContentFontSize = 20F;
            listMenuViewItem5.Name = "打包";
            listMenuViewItem6.Content = "拆包";
            listMenuViewItem6.ContentFontSize = 20F;
            listMenuViewItem6.Name = "拆包";
            listMenuViewGroup3.Items.AddRange(new Smobiler.Core.Controls.ListMenuViewItem[] {
            listMenuViewItem5,
            listMenuViewItem6});
            listMenuViewGroup3.Title = "打包管理";
            this.listMenu.Groups.AddRange(new Smobiler.Core.Controls.ListMenuViewGroup[] {
            listMenuViewGroup1,
            listMenuViewGroup2,
            listMenuViewGroup3});
            this.listMenu.Location = new System.Drawing.Point(64, 42);
            this.listMenu.MenuGroupHeight = 35;
            this.listMenu.MenuItemHeight = 35;
            this.listMenu.Name = "listMenu";
            this.listMenu.Shadow = 10;
            this.listMenu.ShowGroupTitle = true;
            this.listMenu.Size = new System.Drawing.Size(100, 60);
            this.listMenu.SubTextForeColor = System.Drawing.Color.DeepSkyBlue;
            this.listMenu.TextForeColor = System.Drawing.Color.Black;
            this.listMenu.ItemPress += new Smobiler.Core.Controls.ListMenuViewItemPressEventHandler(this.listMenu_ItemPress);
            this.listMenu.ItemActionPress += new Smobiler.Core.Controls.ListMenuViewItemPressEventHandler(this.listMenu_ItemActionPress);
            // 
            // mainMenu
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.功能菜单,
            this.menuBar,
            this.panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Name = "mainMenu";

        }
        #endregion

        private Smobiler.Core.Controls.Title 功能菜单;
        private Smobiler.Core.Controls.ToolBar menuBar;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.ListMenuView listMenu;
    }
}