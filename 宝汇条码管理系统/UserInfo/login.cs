using ServiceHelper;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using 宝汇条码管理系统.menu;

namespace 宝汇条码管理系统
{
    partial class login : Smobiler.Core.Controls.MobileForm
    {
        public login() : base()
        {
            InitializeComponent();
           
        }

        private void bt_login_Press(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tx_user.Text))
            {
                MessageBox.Show("请录入用户名...");
                return;
            }
            if (string.IsNullOrEmpty(tx_passwd.Text))
            {
                MessageBox.Show("请录入密码...");
                return;
            }
            
            string userName = tx_user.Text.Trim();
            string userPwd = tx_passwd.Text.Trim();
            //记录用户名
            if (ck_Rember.Checked)
            {
                LoadClientData("userName", userName);
            }            
            string sql = string.Format(@"SELECT T1.FID,T2.FNAME,FPASSWORD,FEMPINFOID FROM T_ZZ_TM_USER T1,T_ZZ_TM_USER_L T2
                                         WHERE T1.FDOCUMENTSTATUS='C' AND T1.FFORBIDSTATUS='A' AND T2.FLocaleID=2052 
                                               AND T1.FID=T2.FID AND T1.FID=T2.FID AND FNUMBER='{0}' OR FNAME ='{0}'", userName);
            DataTable dt = DbServiceHepler.GetDataTable(sql);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("用户名错误！");
                return;
            }
            else if (dt.Rows.Count > 1)
            {
                MessageBox.Show("用户名重复，请联系系统管理员！");
                return;
            }
            else
            {
                string pwd = string.IsNullOrWhiteSpace(dt.Rows[0]["FPASSWORD"].ToString()) ? "" : dt.Rows[0]["FPASSWORD"].ToString();


                if (userPwd == pwd)
                {
                    string fid = string.IsNullOrWhiteSpace(dt.Rows[0]["FID"].ToString()) ? "" :
                                 dt.Rows[0]["FID"].ToString();
                    string logName = string.IsNullOrWhiteSpace(dt.Rows[0]["FNAME"].ToString()) ? "" :
                                 dt.Rows[0]["FNAME"].ToString();
                    long empInfoId = string.IsNullOrWhiteSpace(dt.Rows[0]["FEMPINFOID"].ToString()) ? 0 :
                                     Convert.ToInt64(dt.Rows[0]["FPASSWORD"].ToString());
                    Session.Add("UserId", empInfoId);
                    Session.Add("logId", fid);
                    Session.Add("logName", logName);
                    this.Show(new Menu());
                }
                else
                {
                    MessageBox.Show("密码错误!");
                    return;
                }
            }
        }
        /// <summary>
        /// 请除记住的用户名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Forget_Press(object sender, EventArgs e)
        {
            try
            {
                RemoveClientData("userName",(object s,ClientDataResultHandlerArgs args)=>
                {                   
                    if(string.IsNullOrEmpty(args.error))
                    {
                        Toast("用户名清除成功！");
                    }
                });
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
       
        private void login_ClientDataLoaded(object sender, ClientDataResultHandlerArgs e)
        {
           
        }
        /// <summary>
        /// 载入数据时判断有无记住的用户名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_Load(object sender, EventArgs e)
        {
            ReadClientData("userName", (object s, ClientDataResultHandlerArgs args) =>
            {
                if (string.IsNullOrEmpty(args.error))
                {
                    tx_user.Text = args.Value;
                }
            });
        }
    }
}