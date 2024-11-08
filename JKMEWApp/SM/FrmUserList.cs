using JKMEWApp.BLL;
using JKMEWApp.Models.BModels;
using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
using JKMEWApp.Tools;
using Sunny.UI;
using Sunny.UI.Win32;
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
    public partial class FrmUserList : UIForm
    {
        private UserBLL userBLL = new UserBLL();
        private RoleBLL roleBLL = new RoleBLL();
        private List<UserInfo> _userInfos;
        private List<RoleInfo> _roleInfos;
        private List<int> _selUserRoleIds;
        private int _totalNum = 0;

        public FrmUserList()
        {
            InitializeComponent();
        }

        private async void FrmUserList_Load(object sender, EventArgs e)
        {
            await LoadUsers(0);
            await LoadRoles();
        }

        private async Task LoadRoles()
        {
            ResponseInfo response = await roleBLL.DoGetRoles(0);
            if (response.Status == 1)
            {
                _roleInfos = response.Value as List<RoleInfo>;

                foreach (RoleInfo roleInfo in _roleInfos)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = roleInfo.RoleName;
                    checkBox.Tag = roleInfo.RoleId;
                    chkFlow.Controls.Add(checkBox);
                }
            }
        }

        private async Task LoadRoleIdsByUserId(int userId)
        {
            ResponseInfo response = await roleBLL.DoGetRolesByUserId(userId);
            if (response.Status == 1)
            {
                _selUserRoleIds = response.Value as List<int>;
                //使用用户的角色id 和 页面的checkbox进行匹对，让对应的checkbox打钩
                foreach (int roleId in _selUserRoleIds)
                {
                    SetRoleCheckBoxStatus(roleId);
                }
            }
        }


        //根据选中的用户，设置Role的CheckBox的状态
        private void SetRoleCheckBoxStatus(int roleId)
        {
            foreach (CheckBox checkBox in chkFlow.Controls)
            {
                if (checkBox.Tag.GetInt() == roleId)
                {
                    checkBox.Checked = true;
                }
            }
        }

        //清空Role的CheckBox的状态
        private void ClearRoleCheckBoxStatus() {
            foreach (CheckBox checkBox in chkFlow.Controls)
            {
                checkBox.Checked = false;
            }
        }

        private async Task LoadUsers(int isDel)
        {
            var obj = new
            {
                KeyWords = txtKeywords.Text.Trim(),
                PageSize = uUserPager.PageSize,
                StartIndex = uUserPager.StartRecord,
                IsDel = isDel
            };
            ResponseInfo response = await userBLL.DoGetUsers(obj);
            if (response.Status == 1)
            {
                PageModel<UserInfo> pageModel = response.Value as PageModel<UserInfo>;
                _userInfos = pageModel.Datas;
                _totalNum = pageModel.Total;

                dgvUserList.AutoGenerateColumns = false;
                dgvUserList.DataSource = _userInfos;

                foreach (DataGridViewRow row in dgvUserList.Rows)
                {
                    DataGridViewLinkCell linkCell = row.Cells["colEditState"] as DataGridViewLinkCell;
                    UserInfo currentUser = row.DataBoundItem as UserInfo;
                    if (linkCell != null)
                    {
                        if (currentUser.IsDeleted == 1)
                        {
                            linkCell.Value = "启用";
                        }
                        else
                        {
                            linkCell.Value = "停用";
                        }
                    }
                }

                uUserPager.Record = _totalNum;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkDel.Checked)
            {
                await LoadUsers(1);
            }
            else
            {
                await LoadUsers(0);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            btnOK.Text = "修改";
            btnClear.Visible = false;
            ClearRoleCheckBoxStatus();

            if (dgvUserList.CurrentRow != null)
            {
                UserInfo tmpUser = dgvUserList.CurrentRow.DataBoundItem as UserInfo;

                await LoadRoleIdsByUserId(tmpUser.UserId);

                txtUName.Text = tmpUser.UserName;
                txtUPwd.Text = tmpUser.UserRealPwd;
                txtIP.Text = tmpUser.LastLoginIp;
                txtLastLoginTime.Text = tmpUser.LastLoginTime.ToString();
                txtPhone.Text = tmpUser.UserPhone;
                if (tmpUser.IsDeleted == 0)
                {
                    chkNormal.Checked = true;
                }
                else
                {
                    chkNormal.Checked = false;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnOK.Text = "新增";
            btnClear.Visible = true;

            txtUName.Text = "";
            txtUPwd.Text = "";
            txtIP.Text = "";
            txtLastLoginTime.Text = "";
            txtPhone.Text = "";
            chkNormal.Checked = true;
        }
    }
}