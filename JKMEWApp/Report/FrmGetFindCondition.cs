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

namespace JKMEWApp.Report
{
    public partial class FrmGetFindCondition : UIForm
    {
        //查询报表列名称集合
        public List<string> ReportColumns = new List<string>();

        public FrmGetFindCondition()
        {
            InitializeComponent();
        }

        private void FrmGetFindCondition_Load(object sender, EventArgs e)
        {
            InitChooseInfo();
        }

        /// <summary>
        /// 初始化选择设置
        /// </summary>
        private void InitChooseInfo()
        {
            cboRegions.SelectedIndex = 0;
            rbtnDefaultSet.Checked = true;
            rbtnRegionSet.Checked = false;
            rbtnReportConfig.Checked = false;
            cboRegions.Enabled = false;
            btnCustReport.Enabled = false;
        }

        private void rbtnRegionSet_CheckedChanged(object sender, EventArgs e)
        {
            cboRegions.Enabled = rbtnRegionSet.Checked;

            ReportColumns.Clear();

            if (cboRegions.Enabled == true)
            {
                cboRegions_SelectedIndexChanged(cboRegions, null);
            }
        }

        private void rbtnDefaultSet_CheckedChanged(object sender, EventArgs e)
        {
            ReportColumns.Clear();
            ReportColumns.Add("CWInTemperature");
            ReportColumns.Add("CWOutTemperature");
            ReportColumns.Add("CWInPressure");
            ReportColumns.Add("CWOutPressure");
            ReportColumns.Add("FreezeInTemperature");
            ReportColumns.Add("FreezeOutTemperature");
            ReportColumns.Add("FreezeInPressure");
            ReportColumns.Add("FreezeOutPressure");
            ReportColumns.Add("CurRoomTemperature");
        }

        private void rbtnReportConfig_CheckedChanged(object sender, EventArgs e)
        {
            btnCustReport.Enabled = rbtnReportConfig.Checked;
            ReportColumns.Clear();
        }

        private void cboRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportColumns.Clear();
            if (cboRegions.SelectedIndex == 0)
            {
                ReportColumns.Add("CWInTemperature");
                ReportColumns.Add("CWOutTemperature");
                ReportColumns.Add("CWInPressure");
                ReportColumns.Add("CWOutPressure");
                ReportColumns.Add("CoolPump1Frequency");
                ReportColumns.Add("CoolPump2Frequency");
                ReportColumns.Add("CoolPump3Frequency");
            }
            else
            {
                ReportColumns.Add("FreezeInTemperature");
                ReportColumns.Add("FreezeOutTemperature");
                ReportColumns.Add("FreezeInPressure");
                ReportColumns.Add("FreezeOutPressure");
                ReportColumns.Add("ColdPump1Frequency");
                ReportColumns.Add("ColdPump2Frequency");
                ReportColumns.Add("ColdPump3Frequency");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ReportColumns.Count == 0)
            {
                MessageBox.Show("请选择要查找的列");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCustReport_Click(object sender, EventArgs e)
        {
            FrmReportConfig frmReportConfig = new FrmReportConfig();
            frmReportConfig.StartPosition = FormStartPosition.CenterScreen;
            DialogResult dialogResult = frmReportConfig.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ReportColumns = frmReportConfig.selReportsPara;
            }
        }
    }
}