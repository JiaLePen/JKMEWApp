using JKMEWApp.Models.Models;
using JKMEWApp.Tools;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKMEWApp.SM
{
    public partial class FrmModifyPwd : UIForm
    {
        private UserInfo _currentUser;

        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        private void FrmModifyPwd_Load(object sender, EventArgs e)
        {
            FrmMain frmMain = this.Tag as FrmMain;
            _currentUser = frmMain.UserInfo;

            lblUserName.Text = _currentUser.UserName;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string origialP = origialPwd.Text.Trim();
            string newP = newPwd.Text.Trim();
            string renewP = renewPwd.Text.Trim();
            if (string.IsNullOrEmpty(origialP))
            {
                lblOPwdErr.Visible = true;
                return;
            }
            else
            {
                lblOPwdErr.Visible = false;
            }

            if (string.IsNullOrEmpty(newP))
            {
                lblNPwdErr.Visible = true;
                return;
            }
            else
            {
                lblNPwdErr.Visible = false;
            }

            if (string.IsNullOrEmpty(renewP))
            {
                lblConPwdErr.Visible = true;
                return;
            }
            else
            {
                lblConPwdErr.Visible = false;
            }

            if (newP != renewP)
            {
                MsgBoxHelper.MsgBoxShow("错误", "两次密码要一致");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TabPage tabPage = this.Parent as TabPage;
            if (tabPage != null)
            {
                TabControl tabControl = tabPage.Parent as TabControl;
                if (tabControl != null)
                {
                    tabControl.TabPages.Remove(tabPage);
                }

                this.Close();
            }
        }
    }
}