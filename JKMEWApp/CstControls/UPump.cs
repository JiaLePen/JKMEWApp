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
    public partial class UPump : UserControl
    {
        public UPump()
        {
            InitializeComponent();
        }

        private Bitmap lightImg = global::JKMEWApp.Properties.Resources.light_off;

        /// <summary>
        /// 泵状态指示灯图片
        /// </summary>
        public Bitmap LightImg
        {
            get { return lightImg; }
            set
            {
                lightImg = value;
                picLight.Image = lightImg;
            }
        }

        private Color switchBgColor = Color.FromArgb(0, 192, 0);

        /// <summary>
        /// 开关按钮的背景色
        /// </summary>
        public Color SwitchBgColor
        {
            get { return switchBgColor; }
            set
            {
                switchBgColor = value;
                btnSwitch.BackColor = switchBgColor;
            }
        }

        private string btnText = "OFF";

        /// <summary>
        /// 开关按钮文本
        /// </summary>
        public string BtnText
        {
            get { return btnText; }
            set
            {
                btnText = value;
                btnSwitch.Text = btnText;
            }
        }

        private string pumpStateName;

        /// <summary>
        /// 泵的状态参数名称
        /// </summary>
        public string PumpStateName
        {
            get { return pumpStateName; }
            set { pumpStateName = value; }
        }

        private string deviceName;

        /// <summary>
        /// 设备名称
        /// </summary>
        public string PumpName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }

        private string pumpStateText;

        /// <summary>
        /// 泵状态描述
        /// </summary>
        public string PumpStateText
        {
            get { return pumpStateText; }
            set { pumpStateText = value; }
        }

        private bool actualState = false;

        /// <summary>
        /// 状态泵的运行实际状态值
        /// </summary>
        public bool ActualState
        {
            get { return actualState; }
            set
            {
                actualState = value;
                if (actualState)
                {
                    this.SwitchBgColor = Color.Orange;
                    LightImg = global::JKMEWApp.Properties.Resources.light_on;
                    BtnText = "ON";
                }
                else
                {
                    SwitchBgColor = Color.FromArgb(0, 192, 0);
                    LightImg = global::JKMEWApp.Properties.Resources.light_off;
                    BtnText = "OFF";
                }
            }
        }
    }
}