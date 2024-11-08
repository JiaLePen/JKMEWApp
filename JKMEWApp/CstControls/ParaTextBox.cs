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
    public partial class ParaTextBox : UserControl
    {
        public event EventHandler ParaTextBoxClickHandler;

        public ParaTextBox()
        {
            InitializeComponent();
        }

        private string dataVal;

        /// <summary>
        /// 参数值
        /// </summary>
        public string DataVal
        {
            get { return dataVal; }
            set
            {
                dataVal = value;
                lblText.Text = dataVal + " " + unit;
            }
        }

        private string unit;

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                lblText.Text = dataVal + " " + unit;
            }
        }

        private string varName;

        /// <summary>
        /// 参数变量名
        /// </summary>
        public string VarName
        {
            get { return varName; }
            set
            {
                varName = value;
            }
        }

        private void ParaTextBox_Click(object sender, EventArgs e)
        {
            ParaTextBoxClickHandler?.Invoke(this, e);
        }

        private void lblText_Click(object sender, EventArgs e)
        {
            ParaTextBox_Click(this, null);
        }
    }
}