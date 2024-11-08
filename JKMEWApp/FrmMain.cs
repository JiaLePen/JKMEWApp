using Common;
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

namespace JKMEWApp
{
    public partial class FrmMain : UIForm
    {
        private UserInfo _userInfo;
        private MenuBLL _menuBLL = new MenuBLL();
        private List<MenuInfo> _menuInfos;
        private System.Timers.Timer _timer;

        public UserInfo UserInfo
        {
            get
            {
                return _userInfo;
            }
            set
            {
                _userInfo = value;
            }
        }

        private FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(UserInfo userInfo)
        {
            InitializeComponent();
            UserInfo = userInfo;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
            _timer.Elapsed -= _timer_Elapsed;
            _timer = null;

            FrmLogin frmLogin = this.Tag as FrmLogin;
            if (frmLogin != null)
            {
                frmLogin.Show();
            }
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            await LoadMenuData(_userInfo.UserId);
            LoadBottomInfo();

            topMenu_MenuItemClick("角色管理", 0, 0);
        }

        private void LoadBottomInfo()
        {
            _timer = new System.Timers.Timer();
            _timer.Interval = 1000;
            _timer.Elapsed += _timer_Elapsed;
            _timer.Start();

            this.lblUser.Text = _userInfo.UserName;
            this.lblTime.Text = DateTime.Now.ToString();
            this.lblCopy.Text = "极客教育版权所有";
        }

        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                this.lblTime.Text = DateTime.Now.ToString();
            }));
        }

        private async Task LoadMenuData(int userId)
        {
            ResponseInfo response = await _menuBLL.DoGetMenusByUserId(userId);
            if (response.Status == 1)
            {
                _menuInfos = response.Value as List<MenuInfo>;
                _menuInfos.Sort((m1, m2) => m1.Morder - m2.Morder);

                var parentMenus = _menuInfos.Where(m => m.ParentId == 0).ToList();
                foreach (var parentMenu in parentMenus)
                {
                    var parentNode = new TreeNode()
                    {
                        Name = "Menu" + parentMenu.MenuId,
                        Text = parentMenu.MenuName,
                        Tag = parentMenu.FrmName
                    };

                    var childMenus = _menuInfos.Where(m => m.ParentId == parentMenu.MenuId).ToList();
                    foreach (var childMenu in childMenus)
                    {
                        var childNode = new TreeNode()
                        {
                            Name = "Menu" + childMenu.MenuId,
                            Text = childMenu.MenuName,
                            Tag = childMenu.FrmName
                        };
                        parentNode.Nodes.Add(childNode);
                    }

                    topMenu.Nodes.Add(parentNode);
                }
            }
        }

        //顶部菜单的点击事件
        private void topMenu_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {
            MenuInfo currentMenu = _menuInfos.FirstOrDefault(mi => mi.MenuName == itemText);
            if (currentMenu != null)
            {
                //退出系统
                if (currentMenu.MenuCode == "Exit")
                {
                    DialogResult dialogResult = MsgBoxHelper.MsgBoxConfirm("提示", "您是否确认退出系统?");
                    if (dialogResult == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    return;
                }

                //打开对应的页面:基于封装实现
                tabContrl.AddTabPage(currentMenu.FrmName);
            }
        }

        //关闭tabpage页面的事件
        private void btnClosePage_Click(object sender, EventArgs e)
        {
            tabContrl.CloseTabPage(topMenu);
        }
    }
}