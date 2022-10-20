using Smobiler.Core;
using System;

namespace 宝汇条码管理系统.Inventory
{
    partial class frmStockSelect : Smobiler.Core.Controls.MobileForm
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
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.ls_Stock = new Smobiler.Core.Controls.ListView();
            this.tb_tools = new Smobiler.Core.Controls.ToolBar();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.tx_stockName = new Smobiler.Core.Controls.TextBox();
            this.ibt_search = new Smobiler.Core.Controls.ImageButton();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.title1.Location = new System.Drawing.Point(113, 195);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 30);
            this.title1.Text = "仓库选择";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ls_Stock});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 275);
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // ls_Stock
            // 
            this.ls_Stock.Location = new System.Drawing.Point(0, 49);
            this.ls_Stock.Name = "ls_Stock";
            this.ls_Stock.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ls_Stock.ShowSplitLine = true;
            this.ls_Stock.Size = new System.Drawing.Size(300, 370);
            this.ls_Stock.TemplateControlName = "uc_StockListRow";
            // 
            // tb_tools
            // 
            toolBarItem1.Name = "reBack";
            toolBarItem1.Text = "返回";
            this.tb_tools.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1});
            this.tb_tools.Location = new System.Drawing.Point(67, 457);
            this.tb_tools.Name = "tb_tools";
            this.tb_tools.Size = new System.Drawing.Size(100, 42);
            this.tb_tools.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.tb_tools_ToolbarItemClick);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.tx_stockName,
            this.ibt_search});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(8, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 41);
            this.panel2.Press += new System.EventHandler(this.panel2_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 30);
            this.label1.Text = "仓库名称";
            // 
            // tx_stockName
            // 
            this.tx_stockName.FontSize = 16F;
            this.tx_stockName.Location = new System.Drawing.Point(50, 0);
            this.tx_stockName.Name = "tx_stockName";
            this.tx_stockName.Size = new System.Drawing.Size(195, 31);
            // 
            // ibt_search
            // 
            this.ibt_search.BackColor = System.Drawing.Color.SteelBlue;
            this.ibt_search.Location = new System.Drawing.Point(245, 1);
            this.ibt_search.Name = "ibt_search";
            this.ibt_search.ResourceID = "search3.jpeg";
            this.ibt_search.Size = new System.Drawing.Size(49, 30);
            this.ibt_search.Press += new System.EventHandler(this.ibt_search_Press);
            // 
            // frmStockSelect
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1,
            this.tb_tools,
            this.panel2});
            this.Name = "frmStockSelect";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.ListView ls_Stock;
        private Smobiler.Core.Controls.ToolBar tb_tools;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TextBox tx_stockName;
        private Smobiler.Core.Controls.ImageButton ibt_search;
    }
}