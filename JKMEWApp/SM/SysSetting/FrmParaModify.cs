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

namespace JKMEWApp.SM.SysSetting
{
    public partial class FrmParaModify : UIForm
    {
        private string _varName;
        private string _dataVal;

        private FrmParaModify()
        {
            InitializeComponent();
        }

        public FrmParaModify(string varname, string dataVal)
        {
            InitializeComponent();
            _varName = varname;
            _dataVal = dataVal;
        }

        private void FrmParaModify_Load(object sender, EventArgs e)
        {
            lbl_Initial.Text = _dataVal;
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (ModbusDataCenter.SetParaAddress.ContainsKey(_varName))
            {
                ModbusParaSetInfo modbusSetInfo = ModbusDataCenter.SetParaAddress[_varName];

                string newVal = txtNewVal.Text.Trim();
                if (newVal.CheckNullEmpty()) {
                    MsgBoxHelper.MsgErrorShow("提示", "请输入要修改的值");
                    return;
                }
                short val = 0;

                if (modbusSetInfo.DataType == "Float")
                {
                    val = (short)(newVal.GetDecimal() * (int)Math.Pow(10, modbusSetInfo.DecimalPlaces));
                }
                else
                {
                    val = (short)newVal.GetInt();
                }

                int slaveAddress = modbusSetInfo.SlaveAddress;
                int address = modbusSetInfo.Address;

                bool isSuccess = await ModbusHelper.WriteEquipParaSet(slaveAddress, address, val);

                if (isSuccess)
                {
                    MsgBoxHelper.MsgBoxShow("提示", "写入成功");
                    this.Close();
                }
                else {
                    MsgBoxHelper.MsgErrorShow("提示", "写入失败");
                }
            }
        }
    }
}