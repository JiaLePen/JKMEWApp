using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
using JKMEWApp.Tools;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace JKMEWApp.SM.SysSetting
{
    public partial class FrmModbusSet : UIForm
    {
        private ModbusSetInfo _modbusSetInfo;

        public FrmModbusSet()
        {
            InitializeComponent();
        }

        private void FrmModbusSet_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboPorts.DataSource = ports;

            _modbusSetInfo = ModbusHelper.GetModbusSetInfo();

            cboConnection.SelectedItem = _modbusSetInfo.Connection;
            cboBauds.SelectedItem = _modbusSetInfo.Baud.ToString();
            cboDataBits.SelectedItem = _modbusSetInfo.DataBits.ToString();
            cboStopBits.SelectedItem = _modbusSetInfo.StopBits.GetInt().ToString();
            cboParity.SelectedItem = _modbusSetInfo.Parity.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string connection = cboConnection.Text.Trim();
            string port = cboPorts.Text.Trim();
            int baud = int.Parse(cboBauds.Text.Trim());
            int databit = int.Parse(cboDataBits.Text.Trim());
            int stopbit = int.Parse(cboStopBits.Text.Trim());
            string parity = cboParity.Text.Trim();
            string mode = rbtnRTU.Checked ? "RTU" : "ASCII";

            ModbusSetInfo modbusSetInfo = new ModbusSetInfo()
            {
                Connection = connection,
                Port = port,
                Baud = baud,
                DataBits = databit,
                StopBits = stopbit == 1 ? StopBits.One : StopBits.Two,
                Parity = (Parity)Enum.Parse(typeof(Parity), parity),
                Mode = mode
            };

            bool isSuccess = ModbusHelper.SaveModbusConfig(modbusSetInfo);
            if (isSuccess)
            {
                MsgBoxHelper.MsgBoxShow("保存通信设置", "通信设置保存成功");
            }
        }
    }
}