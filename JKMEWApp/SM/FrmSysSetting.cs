using Common;
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
    public partial class FrmSysSetting : UIForm
    {
        public FrmSysSetting()
        {
            InitializeComponent();
        }

        private void btnModbusSet_Click(object sender, EventArgs e)
        {
            panelPage.AddToPanel("FrmModbusSet");
        }

        private void btnParaManage_Click(object sender, EventArgs e)
        {
            panelPage.AddToPanel("FrmParaManage");
        }

        private void btnEquiparm_Click(object sender, EventArgs e)
        {
            panelPage.AddToPanel("FrmEquipParaSet");
        }

        private void FrmSysSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            panelPage.CloseAllPanelPage();
        }
    }
}