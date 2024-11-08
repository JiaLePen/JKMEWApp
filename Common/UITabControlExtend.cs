using JKMEWApp.Tools;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.TabControl;

namespace Common
{
    public static class UITabControlExtend
    {
        public static void AddTabPage(this UITabControl tabControl, string frmName)
        {
            //1.查找当前frmName对应的tabpage是否已经存在
            //1.1 如果已存在，则直接打开
            TabPageCollection tabCollections = tabControl.TabPages;
            if (tabCollections.ContainsKey(frmName))
            {
                TabPage page = tabCollections[frmName];
                tabControl.SelectedTab = page;
            }
            //1.2 如果不存在，则创建一个新的TabPage加入到tabControl中
            else
            {
                //2.如果指定的formName在Panel中不存在
                var tmpPath = Directory.GetCurrentDirectory() + "\\" + "JKMEWApp.exe";
                Assembly asm = Assembly.LoadFile(tmpPath);
                Type[] types = asm.GetTypes();
                Type type = types.Where(t => t.FullName == "JKMEWApp." + frmName).FirstOrDefault();

                if (type != null)
                {
                    TabPage tmpPage = new TabPage();
                    tmpPage.Name = frmName;
                    tmpPage.Text = frmName;

                    UIForm tmpForm = Activator.CreateInstance(type) as UIForm;
                    tmpForm.TopLevel = false;
                    tmpForm.Dock = DockStyle.Fill;
                    tmpForm.Parent = tmpPage;
                    tmpForm.Tag = tabControl.Parent;
                    tmpForm.ShowTitle = false;
                    tmpPage.Controls.Add(tmpForm);
                    tmpForm.Show();

                    tabControl.TabPages.Add(tmpPage);
                    tabControl.SelectedTab = tmpPage;
                   
                }
            }
        }

        public static void CloseTabPage(this UITabControl tabControl, UINavBar navBar)
        {
            TabPageCollection tabCollections = tabControl.TabPages;
            if (tabCollections.Count == 0)
            {
                MsgBoxHelper.MsgErrorShow("提示", "没有可以被关闭的页面");
                return;
            }

            //获取最顶部的TabPage ，移除他并且关闭里面的Form
            TabPage topPage = tabCollections[tabCollections.Count - 1];
            tabControl.TabPages.Remove(topPage);

            UIForm form = topPage.Controls[0] as UIForm;
            form?.Close();

            //设置tabControl的选中项
            tabCollections = tabControl.TabPages;
            if (tabCollections.Count > 0)
            {
                topPage = tabCollections[tabCollections.Count - 1];

                TreeNode findNode = FindNodeByText(navBar.Nodes, topPage.Name);
                var idx = navBar.Nodes.IndexOf(findNode);
                navBar.SelectedIndex = idx;

                tabControl.SelectedTab = topPage;
            }
        }

        private static TreeNode FindNodeByText(TreeNodeCollection nodes, string frmName)
        {
            foreach (TreeNode node in nodes)
            {
                if ((string)node.Tag == frmName)
                {
                    return node;
                }

                if (node.Nodes.Count > 0)
                {
                    TreeNode foundNode = FindNodeByText(node.Nodes, frmName);
                    if (foundNode != null)
                    {
                        return foundNode.Parent;
                    }
                }
            }
            return null;
        }
    }
}