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
    public partial class FrmRightManage : UIForm
    {
        private RoleBLL roleBLL = new RoleBLL();
        private MenuBLL menuBLL = new MenuBLL();
        private List<RoleInfo> _roleInfos;
        private List<MenuInfo> _menuInfos;
        private List<MenuInfo> _currentRoleMenus;

        public FrmRightManage()
        {
            InitializeComponent();
        }

        private async void FrmRightManage_Load(object sender, EventArgs e)
        {
            await LoadRoles();
            await LoadMenus();
        }

        private async Task LoadRoles()
        {
            ResponseInfo response = await roleBLL.DoGetRoles(0);
            if (response.Status == 1)
            {
                _roleInfos = response.Value as List<RoleInfo>;
                _roleInfos.RemoveAt(0);
                _roleInfos.Insert(0, new RoleInfo
                {
                    RoleName = "请选择角色",
                    RoleId = 0
                });
                cboRoles.DisplayMember = "RoleName";
                cboRoles.ValueMember = "RoleId";
                cboRoles.DataSource = _roleInfos;
            }
        }

        private async Task LoadMenus()
        {
            ResponseInfo response = await menuBLL.DoGetMenus(0);
            if (response.Status == 1)
            {
                _menuInfos = response.Value as List<MenuInfo>;

                LoadTreeViewMenus(_menuInfos, null, 0);

                //var parentMenus = _menuInfos.Where(m => m.ParentId == 0).ToList();
                //foreach (var menu in parentMenus)
                //{
                //    TreeNode parentNode = new TreeNode();
                //    parentNode.Text = menu.MenuName;
                //    parentNode.Name = menu.FrmName;
                //    parentNode.Tag = menu.MenuId;

                //    var subMenus = _menuInfos.Where(m => m.ParentId == menu.MenuId).ToList();

                //    foreach (var submenu in subMenus)
                //    {
                //        TreeNode subNode = new TreeNode();
                //        subNode.Text = submenu.MenuName;
                //        subNode.Name = submenu.FrmName;
                //        subNode.Tag = submenu.MenuId;
                //        parentNode.Nodes.Add(subNode);
                //    }

                //    tvRolePermission.Nodes.Add(parentNode);
                //}
            }
        }

        //递归加载TreeView的菜单
        private void LoadTreeViewMenus(List<MenuInfo> menuInfos, TreeNode currentNode, int menuId)
        {
            var currentMenus = menuInfos.Where(m => m.ParentId == menuId).ToList();

            foreach (var menu in currentMenus)
            {
                TreeNode node = new TreeNode();
                node.Text = menu.MenuName;
                node.Name = menu.FrmName;
                node.Tag = menu.MenuId;

                if (currentNode == null)
                {
                    tvRolePermission.Nodes.Add(node);
                }
                else
                {
                    currentNode.Nodes.Add(node);
                }

                LoadTreeViewMenus(menuInfos, node, menu.MenuId);
            }
        }

        //TreeView中的 CheckBox的打钩事件
        private void tvRolePermission_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //如果当前事件是鼠标点击
            if (e.Action == TreeViewAction.ByMouse)
            {
                //递归子节点
                setChildNodeCheckedState(e.Node, e.Node.Checked);

                //递归父节点
                if (e.Node.Parent != null)
                {
                    bool isAnySelect = false;
                    foreach (TreeNode tmp in e.Node.Parent.Nodes)
                    {
                        if (tmp.Checked)
                        {
                            isAnySelect = true;
                            break;
                        }
                    }
                    setParentNodeCheckedState(e.Node, isAnySelect);
                }
            }
        }

        //设置当前节点的父节点的状态
        private void setParentNodeCheckedState(TreeNode node, bool state)
        {
            TreeNode parentNode = node.Parent;
            parentNode.Checked = state;

            if (parentNode.Parent != null)
            {
                setParentNodeCheckedState(parentNode, state);
            }
        }

        //重置当前node节点下的所有子节点的状态 和 当前node节点状态一致
        private void setChildNodeCheckedState(TreeNode node, bool state)
        {
            TreeNodeCollection childNodes = node.Nodes;
            foreach (TreeNode child in childNodes)
            {
                child.Checked = state;
                setChildNodeCheckedState(child, state);
            }
        }

        //获取用户选择的角色以及角色对应的权限
        private async void btnSave_Click(object sender, EventArgs e)
        {
            //1.获取用户选择的角色id信息
            int roleId = cboRoles.SelectedValue.GetInt();
            if (roleId == 0)
            {
                MsgBoxHelper.MsgErrorShow("提示", "请选择要修改的角色");
                return;
            }

            //2.获取用户选择的权限列表id集合
            List<int> selIds = new List<int>();
            foreach (TreeNode node in tvRolePermission.Nodes)
            {
                GetCheckedTreeViewIds(selIds, node);
            }

            //3.用户选择的Id集合和_currentRoleMenus进行比较，看是否一致，如果一致则没有修改
            List<int> origalIds = _currentRoleMenus.Select(r => r.MenuId).ToList();
            bool isSame = selIds.Count == origalIds.Count && selIds.All(origalIds.Contains);
            if (isSame)
            {
                MsgBoxHelper.MsgErrorShow("提示", "请修改当前角色的权限");
                return;
            }

            //4.封装传递给服务器的数据
            var obj = new
            {
                RoleId = roleId,
                MenuIds = selIds
            };
            ResponseInfo response = await roleBLL.DoUpdateRoleMenus(obj);

            MsgBoxHelper.MsgBoxShow(response.Title, response.Message);
        }

        //重置Nodes节点的所有状态
        private void SetNodeCheckedStatus(TreeNodeCollection nodes, bool bl)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = bl;

                SetNodeCheckedStatus(node.Nodes, bl);
            }
        }

        //获取TreeView中所有的选中的Node节点的Id信息
        private void GetCheckedTreeViewIds(List<int> ids, TreeNode currentNode)
        {
            if (currentNode.Checked)
            {
                ids.Add((int)currentNode.Tag);

                foreach (TreeNode subNode in currentNode.Nodes)
                {
                    GetCheckedTreeViewIds(ids, subNode);
                }
            }
        }

        //当用选择了角色
        private async void cboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selRoleId = (int)cboRoles.SelectedValue;
            if (selRoleId == 0)
            {
                return;
            }

            //每次选择角色之前重置TreeView的状态
            SetNodeCheckedStatus(tvRolePermission.Nodes, false);

            ResponseInfo response = await menuBLL.DoGetMenusByRoleId(selRoleId);
            if (response.Status == 1)
            {
                _currentRoleMenus = response.Value as List<MenuInfo>;

                foreach (MenuInfo menu in _currentRoleMenus)
                {
                    MatchTreeNodeCheckInfo(tvRolePermission.Nodes, menu.MenuId);
                }
            }
        }

        //匹配角色对应的菜单，进行打钩的设置
        private void MatchTreeNodeCheckInfo(TreeNodeCollection nodes, int menuId)
        {
            foreach (TreeNode node in nodes)
            {
                if ((int)node.Tag == menuId)
                {
                    node.Checked = true;
                }

                MatchTreeNodeCheckInfo(node.Nodes, menuId);
            }
        }
    }
}