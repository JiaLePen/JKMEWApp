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
    public partial class UCWTower : UserControl
    {
        public UCWTower()
        {
            InitializeComponent();
            StateForeColor = Color.Gray;
        }

        private string towerStateName;

        /// <summary>
        /// 冷却塔的状态参数名称
        /// </summary>
        public string TowerStateName
        {
            get { return towerStateName; }
            set { towerStateName = value; }
        }

        private string towerName;

        /// <summary>
        /// 设备名称
        /// </summary>
        public string TowerName
        {
            get { return towerName; }
            set
            {
                towerName = value;
                lblTowerName.Text = towerName;
            }
        }

        private string towerStateText;

        /// <summary>
        /// 冷却塔状态描述
        /// </summary>
        public string TowerStateText
        {
            get { return towerStateText; }
            set
            {
                towerStateText = value;
                lblState.Text = towerStateText;
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
        ///  冷却塔状态的运行实际状态值
        /// </summary>
        public bool ActualState
        {
            get { return actualState; }
            set
            {
                actualState = value;
                if (actualState)
                {
                    TowerStateText = "运行中";
                    StateForeColor = Color.Blue;
                    btnSwitch.BackColor = Color.Orange;
                    btnSwitch.Text = "ON";
                }
                else
                {
                    TowerStateText = "已停止";
                    StateForeColor = Color.Gray;
                    btnSwitch.BackColor = Color.Gray;
                    btnSwitch.Text = "OFF";
                }
            }
        }

        /// <summary>
        /// 提供外部绑定click事件
        /// </summary>
        public event EventHandler CheckClick;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CheckClick?.Invoke(this, new EventArgs());
        }
    }
}