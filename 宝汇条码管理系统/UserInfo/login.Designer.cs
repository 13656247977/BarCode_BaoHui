using Smobiler.Core;

namespace 宝汇条码管理系统
{
    partial class login : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.bt_login = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.tx_passwd = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.tx_user = new Smobiler.Core.Controls.TextBox();
            this.logon = new Smobiler.Core.Controls.Image();
            this.ck_Rember = new Smobiler.Core.Controls.CheckBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.bt_Forget = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.bt_login,
            this.label2,
            this.tx_passwd,
            this.label1,
            this.tx_user,
            this.logon,
            this.ck_Rember,
            this.label3,
            this.bt_Forget});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 179);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 252);
            // 
            // bt_login
            // 
            this.bt_login.BorderRadius = 10;
            this.bt_login.FontSize = 20F;
            this.bt_login.Location = new System.Drawing.Point(88, 335);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(111, 29);
            this.bt_login.Text = "登录";
            this.bt_login.Press += new System.EventHandler(this.bt_login_Press);
            // 
            // label2
            // 
            this.label2.Bold = true;
            this.label2.BorderRadius = 5;
            this.label2.FontSize = 20F;
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(49, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 32);
            this.label2.Text = "密码：";
            // 
            // tx_passwd
            // 
            this.tx_passwd.Bold = true;
            this.tx_passwd.Border = new Smobiler.Core.Controls.Border(1F);
            this.tx_passwd.BorderRadius = 5;
            this.tx_passwd.FontSize = 20F;
            this.tx_passwd.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.tx_passwd.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.tx_passwd.Location = new System.Drawing.Point(123, 217);
            this.tx_passwd.Name = "tx_passwd";
            this.tx_passwd.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Next;
            this.tx_passwd.SecurityMode = true;
            this.tx_passwd.Size = new System.Drawing.Size(131, 32);
            this.tx_passwd.ValueType = Smobiler.Core.Controls.InputValueType.Number;
            this.tx_passwd.WaterMarkText = "请输入密码";
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.BorderRadius = 5;
            this.label1.FontSize = 20F;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(49, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 35);
            this.label1.Text = "用户名：";
            // 
            // tx_user
            // 
            this.tx_user.Bold = true;
            this.tx_user.Border = new Smobiler.Core.Controls.Border(1F);
            this.tx_user.BorderRadius = 5;
            this.tx_user.FontSize = 20F;
            this.tx_user.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.tx_user.Location = new System.Drawing.Point(123, 179);
            this.tx_user.MaxLength = 8;
            this.tx_user.Name = "tx_user";
            this.tx_user.Size = new System.Drawing.Size(131, 35);
            this.tx_user.WaterMarkText = "请输入用户名";
            // 
            // logon
            // 
            this.logon.BorderRadius = 10;
            this.logon.Location = new System.Drawing.Point(88, 46);
            this.logon.Name = "logon";
            this.logon.ResourceID = "logon.png";
            this.logon.Size = new System.Drawing.Size(111, 97);
            // 
            // ck_Rember
            // 
            this.ck_Rember.Location = new System.Drawing.Point(53, 264);
            this.ck_Rember.Name = "ck_Rember";
            this.ck_Rember.Size = new System.Drawing.Size(25, 25);
            // 
            // label3
            // 
            this.label3.FontSize = 16F;
            this.label3.Location = new System.Drawing.Point(82, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.Text = "记住用户名";
            // 
            // bt_Forget
            // 
            this.bt_Forget.BorderRadius = 0;
            this.bt_Forget.FontSize = 16F;
            this.bt_Forget.Location = new System.Drawing.Point(164, 261);
            this.bt_Forget.Name = "bt_Forget";
            this.bt_Forget.Size = new System.Drawing.Size(90, 30);
            this.bt_Forget.Text = "清除用户名";
            this.bt_Forget.Press += new System.EventHandler(this.bt_Forget_Press);
            // 
            // login
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.ClientDataLoaded += new Smobiler.Core.Controls.LoadClientDataCallBackHandler(this.login_ClientDataLoaded);
            this.Load += new System.EventHandler(this.login_Load);
            this.Name = "login";

        }
        #endregion
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Button bt_login;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox tx_passwd;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TextBox tx_user;
        private Smobiler.Core.Controls.Image logon;
        private Smobiler.Core.Controls.CheckBox ck_Rember;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Button bt_Forget;
    }
}