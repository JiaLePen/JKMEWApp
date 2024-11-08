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

namespace Common
{
    public static class PanelHelper
    {
        //将Form添加Panel内部的方法
        public static void AddToPanel(this Panel panel, string formName)
        {
            //1.如果指定的formName在Panel中是否已存在
            var formNameSpace = "JKMEWApp.SM.SysSetting." + formName;
            bool find = false;
            foreach (var ctrl in panel.Controls)
            {
                if (ctrl is Form)
                {
                    UIForm tmp = (UIForm)ctrl;
                    Type type = tmp.GetType();
                    if (type.FullName == formNameSpace)
                    {
                        find = true;
                        tmp.BringToFront();
                    }
                }
            }
            if (find) return;

            //2.如果指定的formName在Panel中不存在
            var tmpPath = Directory.GetCurrentDirectory() + "\\" + "JKMEWApp.exe";
            Assembly asm = Assembly.LoadFile(tmpPath);
            Type[] types = asm.GetTypes();
            Type currentType = types.Where(t => t.FullName == formNameSpace).FirstOrDefault();
            if (currentType != null)
            {
                UIForm form = Activator.CreateInstance(currentType) as UIForm;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                form.ShowTitle = false;
                panel.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
        }

        //关闭页面的点击事件
        public static void CloseAllPanelPage(this Panel panel)
        {
            List<UIForm> forms = panel.Controls.OfType<UIForm>().ToList();

            foreach (UIForm form in forms)
            {
                form.Close();
                panel.Controls.Remove(form);
            }
        }
    }
}