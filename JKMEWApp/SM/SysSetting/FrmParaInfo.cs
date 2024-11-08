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
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKMEWApp.SM.SysSetting
{
    public partial class FrmParaInfo : UIForm
    {
        private AlarmParaBLL _alarmParaBLL = new AlarmParaBLL();
        private ModbusParaBLL _modbusParaBLL = new ModbusParaBLL();

        private List<AlarmParaInfo> _alarmParaInfos;
        private List<AlarmParaInfo> _sendAlarmParaInfos = new List<AlarmParaInfo>();

        private ModbusParaSetInfo _currentInfo;

        private FrmParaInfo()
        {
            InitializeComponent();
        }

        public FrmParaInfo(ModbusParaSetInfo modbusParaSetInfo)
        {
            InitializeComponent();
            _currentInfo = modbusParaSetInfo;
        }

        private async void FrmParaInfo_Load(object sender, EventArgs e)
        {
            await LoadAlarmParaInfos();
            InitParamInfo();
        }

        private async Task LoadAlarmParaInfos()
        {
            ResponseInfo response = await _alarmParaBLL.DoGetParaNameAlarmInfo(_currentInfo.ParaName);
            if (response.Status == 1)
            {
                _alarmParaInfos = response.Value as List<AlarmParaInfo>;
            }
        }

        private void InitParamInfo()
        {
            this.cboDataType.Items.Add("Bool");
            this.cboDataType.Items.Add("Signed");
            this.cboDataType.Items.Add("Unsigned");
            this.cboDataType.Items.Add("Float");

            this.cboStoreArea.Items.Add("01 Coil Status(0x)");
            this.cboStoreArea.Items.Add("02 Input Status(1x)");
            this.cboStoreArea.Items.Add("03 Holding Register(4x)");
            this.cboStoreArea.Items.Add("04 Input Registers(3x)");

            txtVarName.Text = _currentInfo.ParaName;
            cboDataType.SelectedItem = _currentInfo.DataType;
            if (_currentInfo.DataType == "Float")
            {
                txtDecimalPlaces.Text = _currentInfo.DecimalPlaces.ToString();
                txtDecimalPlaces.Enabled = true;
            }
            cboStoreArea.SelectedItem = _currentInfo.StoreFunction;
            txtAddress.Text = _currentInfo.Address.ToString();
            if (_currentInfo.IsReport)
            {
                chkIsReport.Checked = true;
            }
            if (_currentInfo.IsAlarm)
            {
                chkIsAlarm.Checked = true;
            }
            txtNote.Text = _currentInfo.Note;
            txtSAddress.Text = _currentInfo.SlaveAddress.ToString();

            //如果当前参数有报警配置
            if (_alarmParaInfos.Count == 0)
            {
                gbAlarm.Enabled = false;
            }
            else
            {
                gbAlarm.Enabled = true;

                foreach (AlarmParaInfo alarm in _alarmParaInfos)
                {
                    if (alarm.AlarmType == 1)
                    {
                        chk_Low.Checked = true;
                        txt_Alarm_Low.Text = alarm.AlarmValue;
                        txt_Note_Low.Text = alarm.AlarmNote;
                        txt_Alarm_Low.Enabled = true;
                        txt_Note_Low.Enabled = true;
                    }
                    else
                    {
                        chk_High.Checked = true;
                        txt_Alarm_High.Text = alarm.AlarmValue;
                        txt_Note_High.Text = alarm.AlarmNote;
                        txt_Alarm_High.Enabled = true;
                        txt_Note_High.Enabled = true;
                    }
                }
            }
        }

        private void cboDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selType = cboDataType.SelectedItem.ToString();
            if (selType == "Float")
            {
                txtDecimalPlaces.Enabled = true;
                txtDecimalPlaces.Text = _currentInfo.DecimalPlaces.ToString();
            }
            else
            {
                txtDecimalPlaces.Enabled = false;
                txtDecimalPlaces.Text = "";
            }
        }

        private void chk_Low_CheckedChanged(object sender, EventArgs e)
        {
            AlarmParaInfo alarm = _alarmParaInfos.Where(ap => ap.AlarmType == 1).FirstOrDefault();

            if (chk_Low.Checked)
            {
                txt_Alarm_Low.Text = alarm?.AlarmValue;
                txt_Note_Low.Text = alarm?.AlarmNote;
                txt_Alarm_Low.Enabled = true;
                txt_Note_Low.Enabled = true;
            }
            else
            {
                txt_Alarm_Low.Text = "";
                txt_Note_Low.Text = "";
                txt_Alarm_Low.Enabled = false;
                txt_Note_Low.Enabled = false;
            }
        }

        private void chk_High_CheckedChanged(object sender, EventArgs e)
        {
            AlarmParaInfo alarm = _alarmParaInfos.Where(ap => ap.AlarmType == 2).FirstOrDefault();
            if (chk_High.Checked)
            {
                txt_Alarm_High.Text = alarm?.AlarmValue;
                txt_Note_High.Text = alarm?.AlarmNote;
                txt_Alarm_High.Enabled = true;
                txt_Note_High.Enabled = true;
            }
            else
            {
                txt_Alarm_High.Text = "";
                txt_Note_High.Text = "";
                txt_Alarm_High.Enabled = false;
                txt_Note_High.Enabled = false;
            }
        }

        //修改参数
        private async void btnOK_Click(object sender, EventArgs e)
        {
            _currentInfo.ParaName = txtVarName.Text;
            _currentInfo.DataType = cboDataType.SelectedItem.ToString();
            _currentInfo.DecimalPlaces = txtDecimalPlaces.Text.GetInt();
            _currentInfo.StoreFunction = cboStoreArea.SelectedItem.ToString();
            _currentInfo.Address = txtAddress.Text.GetInt();
            _currentInfo.Note = txtNote.Text;
            _currentInfo.SlaveAddress = txtSAddress.Text.GetInt();

            foreach (AlarmParaInfo item in _alarmParaInfos)
            {
                if (item.AlarmType == 1)
                {
                    item.AlarmValue = txt_Alarm_Low.Text;
                    item.AlarmNote = txt_Note_Low.Text;
                }
                else if (item.AlarmType == 2)
                {
                    item.AlarmValue = txt_Alarm_High.Text;
                    item.AlarmNote = txt_Note_High.Text;
                }
            }

            _sendAlarmParaInfos.Clear();
            if (chk_Low.Checked)
            {
                AlarmParaInfo alarm = _alarmParaInfos.Where(ap => ap.AlarmType == 1).FirstOrDefault();
                if (alarm != null)
                {
                    _sendAlarmParaInfos.Add(alarm);
                }
                else
                {
                    _sendAlarmParaInfos.Add(new AlarmParaInfo
                    {
                        AparaName = _currentInfo.ParaName,
                        AlarmType = 1,
                        AlarmValue = txt_Alarm_Low.Text,
                        ValueType = _currentInfo.DataType,
                        AlarmNote = txt_Note_Low.Text,
                    });
                }
            }

            if (chk_High.Checked)
            {
                AlarmParaInfo alarm = _alarmParaInfos.Where(ap => ap.AlarmType == 2).FirstOrDefault();
                if (alarm != null)
                {
                    _sendAlarmParaInfos.Add(alarm);
                }
                else
                {
                    _sendAlarmParaInfos.Add(new AlarmParaInfo
                    {
                        AparaName = _currentInfo.ParaName,
                        AlarmType = 2,
                        AlarmValue = txt_Alarm_High.Text,
                        ValueType = _currentInfo.DataType,
                        AlarmNote = txt_Note_High.Text,
                    });
                }
            }

            ResponseInfo response = await _modbusParaBLL.DoUpdateModbusParaInfos(new
            {
                ModbusPara = _currentInfo,
                AlarmParas = _sendAlarmParaInfos
            });
            MsgBoxHelper.MsgBoxShow(response.Title, response.Message);
        }
    }
}