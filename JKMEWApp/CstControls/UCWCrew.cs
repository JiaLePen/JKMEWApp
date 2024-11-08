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
    public partial class UCWCrew : UserControl
    {
        public UCWCrew()
        {
            InitializeComponent();
        }

        private string crewStateName;

        /// <summary>
        /// 冷水机组的状态参数名称
        /// </summary>
        public string CrewStateName
        {
            get { return crewStateName; }
            set { crewStateName = value; }
        }

        private string deviceName;

        /// <summary>
        /// 设备名称
        /// </summary>
        public string CrewName
        {
            get { return deviceName; }
            set
            {
                deviceName = value;
                lblCrewName.Text = deviceName;
            }
        }

        private string crewStateText;

        /// <summary>
        /// 冷水机组状态描述
        /// </summary>
        public string CrewStateText
        {
            get { return crewStateText; }
            set
            {
                crewStateText = value;
                lblState.Text = crewStateText;
            }
        }

        /// <summary>
        /// 运行状态文本颜色
        /// </summary>
        public Color StateForeColor
        {
            get { return lblState.ForeColor; }
            set { lblState.ForeColor = value; }
        }

        private bool actualState = false;

        /// <summary>
        ///  冷水机组状态的运行实际状态值
        /// </summary>
        public bool ActualState
        {
            get { return actualState; }
            set
            {
                actualState = value;
                if (actualState)
                {
                    CrewStateText = "运行中";
                    StateForeColor = Color.Blue;
                    btnSwitch.BackColor = Color.Orange;
                    btnSwitch.Text = "ON";
                }
                else
                {
                    CrewStateText = "已停止";
                    StateForeColor = Color.Gray;
                    btnSwitch.BackColor = Color.Gray;
                    btnSwitch.Text = "OFF";
                }
            }
        }
    }
}