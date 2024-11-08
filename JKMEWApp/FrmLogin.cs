using JKMEWApp.BLL;
using JKMEWApp.Models.BModels;
using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
using JKMEWApp.Tools;
using Newtonsoft.Json;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKMEWApp
{
    public partial class FrmLogin : UIForm
    {
        private UserBLL _userBLL = new UserBLL();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtUName.Text.Trim();
            string pwd = txtUPwd.Text.Trim();
            if (name.CheckNullEmpty())
            {
                lblNameErr.Visible = true;
                txtUName.Focus();
                return;
            }

            if (pwd.CheckNullEmpty())
            {
                lblPwdErr.Visible = true;
                txtUPwd.Focus();
                return;
            }

            //登录的用户
            var user = new
            {
                userName = name,
                userPwd = pwd
            };

            ResponseInfo response = await _userBLL.DoLogin(user);
            if (response.Status != 1)
            {
                lblLoginErr.Visible = true;
                lblLoginErr.Text = "账号密码有误";
            }
            else
            {
                //获取Token存起来
                ResToken resToken = response.Value as ResToken;
                //将token保存起来
                using (StreamWriter sw = new StreamWriter("token.txt", false))
                {
                    sw.Write(resToken.Token);
                }

                //获取登录的用户信息
                UserInfo reUser = resToken.User;
                if (reUser.UserState)
                {
                    this.Hide();

                    FrmMain frmMain = new FrmMain(reUser);
                    frmMain.Tag = this;
                    frmMain.StartPosition = FormStartPosition.CenterScreen;
                    frmMain.ShowDialog();
                }
                else
                {
                    lblLoginErr.Visible = true;
                    lblLoginErr.Text = "该用户已冻结，不能使用系统";
                }
            }
        }
    }
}