using JKMEWApp.BLL;
using JKMEWApp.CstControls;
using JKMEWApp.Models.BModels;
using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKMEWApp.SM
{
    public partial class FrmMenuList : UIForm
    {
        private MenuBLL _menuBLL = new MenuBLL();
        private List<ViewMenuInfo> _viewMenuInfos;
        private List<MenuInfo> _parentMenus;
        private int _totalNum;

        public FrmMenuList()
        {
            InitializeComponent();
        }

        private async void FrmMenuList_Load(object sender, EventArgs e)
        {
            await LoadParentMenus();

            uMenuPager.OnPageChanged += UMenuPager_OnPageChanged;

            await LoadMenuInfos();
        }

        //每单分页控件中点击页面切换按钮执行的事件
        private async void UMenuPager_OnPageChanged(object sender, EventArgs e)
        {
            await LoadMenuInfos();
        }

        private async Task LoadMenuInfos()
        {
            var obj = new
            {
                KeyWords = txtKeywords.Text.Trim(),
                PageSize = uMenuPager.PageSize,
                StartIndex = uMenuPager.StartRecord,
                IsDel = 0
            };
            ResponseInfo response = await _menuBLL.DoGetMenusByFilter(obj);
            if (response.Status == 1)
            {
                PageModel<ViewMenuInfo> pageModel = response.Value as PageModel<ViewMenuInfo>;
                _viewMenuInfos = pageModel.Datas;
                _totalNum = pageModel.Total;

                dgvMenuList.AutoGenerateColumns = false;
                dgvMenuList.DataSource = _viewMenuInfos;

                uMenuPager.Record = _totalNum;
            }
        }

        private async Task LoadParentMenus()
        {
            ResponseInfo response = await _menuBLL.DoGetMenus(0);
            if (response.Status == 1)
            {
                List<MenuInfo> tmpMenus = response.Value as List<MenuInfo>;
                _parentMenus = tmpMenus.Where(m => m.ParentId == 0).ToList();

                cboParentList.DisplayMember = "MenuName";
                cboParentList.ValueMember = "MenuId";
                cboParentList.DataSource = _parentMenus;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadMenuInfos();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMenuList.CurrentRow != null)
            {
                ViewMenuInfo viewMenuInfo = dgvMenuList.CurrentRow.DataBoundItem as ViewMenuInfo;
                txtMenuName.Text = viewMenuInfo.MenuName;

                if (viewMenuInfo.IsTop)
                {
                    chkTop.Checked = true;
                }
                else
                {
                    chkEmbedded.Checked = true;
                }

                cboParentList.SelectedValue = viewMenuInfo.MenuId;

                txtOrder.Value = viewMenuInfo.Morder;
                txtMCode.Text = viewMenuInfo.MenuCode;
                txtFrm.Text = viewMenuInfo.FrmName;

                btnOK.Text = "修改";
                btnClear.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMenuName.Text = "";

            chkEmbedded.Checked = true;

            txtOrder.Value = 0;
            txtMCode.Text = "";
            txtFrm.Text = "";

            cboParentList.SelectedIndex = 0;

            btnOK.Text = "新增";
            btnClear.Visible = true;
        }
    }
}