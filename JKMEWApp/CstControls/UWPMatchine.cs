using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKMEWApp.CstControls
{
    public partial class UWPMatchine : UserControl
    {
        public UWPMatchine()
        {
            InitializeComponent();
        }

        private string isRunStateName;

        /// <summary>
        /// 风机的状态参数名称
        /// </summary>
        public string IsRunStateName
        {
            get { return isRunStateName; }
            set { isRunStateName = value; }
        }

        /// <summary>
        /// 开关按钮文本
        /// </summary>
        public string BtnText
        {
            get { return btnStart.Text; }
            set
            {
                btnStart.Text = value;
            }
        }

        private string deviceName;

        /// <summary>
        /// 设备名称
        /// </summary>
        public string WindPipeName
        {
            get { return deviceName; }
            set
            {
                deviceName = value;
                lblDevName.Text = deviceName;
            }
        }

        private double setTemper = 15.0;

        [DefaultValue(typeof(double), "15.0"), Description("制冷温度")]
        public double SetTemper
        {
            get { return setTemper; }
            set
            {
                setTemper = value;
                txtTemper.DataVal = setTemper.ToString("0.0");
            }
        }

        public string TemperVarName
        {
            get { return txtTemper.VarName; }
            set
            {
                txtTemper.VarName = value;
            }
        }

        private bool isCold;

        /// <summary>
        /// 设置的房间温度
        /// </summary>
        public bool IsCold
        {
            get { return isCold; }
            set
            {
                isCold = value;
                lblMode.Text = isCold ? "制冷" : "制热";
            }
        }

        private string runStateText;

        /// <summary>
        /// 冷水机组状态描述
        /// </summary>
        public string RunStateText
        {
            get { return runStateText; }
            set
            {
                runStateText = value;
                lblRunState.Text = runStateText;
            }
        }

        /// <summary>
        /// 运行状态文本颜色
        /// </summary>
        public Color StateForeColor
        {
            get { return lblRunState.ForeColor; }
            set { lblRunState.ForeColor = value; }
        }

        private bool actualState = false;

        /// <summary>
        ///  风机运行实际状态值
        /// </summary>
        public bool ActualState
        {
            get { return actualState; }
            set
            {
                actualState = value;
                if (actualState)
                {
                    RunStateText = "运行中";
                    StateForeColor = Color.Blue;
                    BtnText = "关闭";
                }
                else
                {
                    RunStateText = "已停止";
                    StateForeColor = Color.Gray;
                    BtnText = "启动";
                }
            }
        }

        private double increment = 1.0;

        //升温
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (SetTemper < 30 && !IsCold)
            {
                SetTemper += increment;
                UpdateTemperature();
            }
        }

        //降温
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (SetTemper > 5 && IsCold)
            {
                SetTemper -= increment;
                UpdateTemperature();
            }
        }

        /// <summary>
        /// 将温度写进设备
        /// </summary>
        private void UpdateTemperature()
        {
            byte slaveAddress = 1;
            ushort address = 15;
            ushort writeVal = (ushort)(SetTemper * 10);
            Task.Run(() =>
            {
            });
        }

        public event Action<object, EventArgs> StartEvent;//启动或停止

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}