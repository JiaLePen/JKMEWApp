using JKMEWApp.BLL;
using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
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

namespace JKMEWApp.SM.SysSetting
{
    public partial class FrmParaManage : UIForm
    {
        private ModbusParaBLL _modbusParaBLL = new ModbusParaBLL();
        private List<ModbusParaSetInfo> _modbusSetInfos;

        public FrmParaManage()
        {
            InitializeComponent();
        }

        private async void FrmParaManage_Load(object sender, EventArgs e)
        {
            await LoadModbusSetInfos();
        }

        private async Task LoadModbusSetInfos()
        {
            ResponseInfo response = await _modbusParaBLL.DoGetModbusParaInfos();
            if (response.Status == 1)
            {
                _modbusSetInfos = response.Value as List<ModbusParaSetInfo>;

                dgvParaList.AutoGenerateColumns = false;
                dgvParaList.DataSource = _modbusSetInfos;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvParaList.CurrentRow != null)
            {
                ModbusParaSetInfo currentInfo = dgvParaList.CurrentRow.DataBoundItem as ModbusParaSetInfo;

                FrmParaInfo frmParaInfo = new FrmParaInfo(currentInfo);
                frmParaInfo.StartPosition = FormStartPosition.CenterScreen;
                frmParaInfo.ShowDialog();
            }
        }
    }
}