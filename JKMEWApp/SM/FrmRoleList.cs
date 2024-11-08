using JKMEWApp.BLL;
using JKMEWApp.Models.DTO;
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
    public partial class FrmRoleList : UIForm
    {
        private List<RoleInfo> _roleInfos;
        private RoleBLL roleBLL = new RoleBLL();
        private RoleInfo currentRole = null;

        public FrmRoleList()
        {
            InitializeComponent();
        }

        private async Task LoadRoles(int isDel)
        {
            ResponseInfo response = await roleBLL.DoGetRoles(isDel);
            if (response.Status == 1)
            {
                _roleInfos = response.Value as List<RoleInfo>;
                dgvRole.AutoGenerateColumns = false;
                dgvRole.DataSource = _roleInfos;
            }
        }

        private async void FrmRoleList_Load(object sender, EventArgs e)
        {
            await LoadRoles(0);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRole.CurrentRow != null)
            {
                RoleInfo selRoleInfo = dgvRole.CurrentRow.DataBoundItem as RoleInfo;
                txtRoleName.Text = selRoleInfo.RoleName;
                txtRemark.Text = selRoleInfo.Remark;
                btnClear.Visible = false;
                btnOK.Text = "编辑";

                //保存当前编辑的行数据
                currentRole = selRoleInfo;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnOK.Text = "新增";
            txtRoleName.Text = "";
            txtRemark.Text = "";
            btnClear.Visible = true;

            //置空
            currentRole = null;
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            RoleInfo editRole;
            //编辑操作
            if (currentRole != null)
            {
                editRole = currentRole;
            }
            //新增操作
            else
            {
                editRole = new RoleInfo();
            }
            editRole.RoleName = txtRoleName.Text;
            editRole.Remark = txtRemark.Text;

            ResponseInfo response = await roleBLL.DoUpdateRole(editRole);
            MsgBoxHelper.MsgBoxShow(response.Title, response.Message);
            if (response.Status == 1)
            {
                if (chkDel.Checked)
                {
                    await LoadRoles(1);
                }
                else
                {
                    await LoadRoles(0);
                }
            }
        }

        private async void chkDel_CheckedChanged(object sender, EventArgs e)
        {
            UICheckBox checkBox = sender as UICheckBox;
            if (checkBox.Checked)
            {
                await LoadRoles(1);
            }
            else
            {
                await LoadRoles(0);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> selRoleIds = new List<int>();
            foreach (DataGridViewRow row in dgvRole.Rows)
            {
                DataGridViewCheckBoxCell checkCell = row.Cells["dataGridViewCheckBoxColumn1"] as DataGridViewCheckBoxCell;

                if (checkCell.FormattedValue.ToString() == "True")
                {
                    RoleInfo current = row.DataBoundItem as RoleInfo;
                    selRoleIds.Add(current.RoleId);
                }
            }
            Console.WriteLine(selRoleIds);
        }
    }
}