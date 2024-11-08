using JKMEWApp.BLL;
using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
using Sunny.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace JKMEWApp.Report
{
    public partial class FrmReportConfig : UIForm
    {
        private ModbusParaBLL _modbusParaBLL = new ModbusParaBLL();
        private Dictionary<string, ModbusParaSetInfo> reportDicts = new Dictionary<string, ModbusParaSetInfo>();
        private List<string> reportsLeftNotes = new List<string>();  //左边ListBox数据源(Note文本)
        private List<string> reportsRightNotes = new List<string>(); //右边ListBox的数据源(Note文本)
        public List<string> selReportsPara = new List<string>(); //选中的报表参数集合(ParaName)

        public FrmReportConfig()
        {
            InitializeComponent();
        }

        private async void FrmReportConfig_Load(object sender, EventArgs e)
        {
            await LoadReportParaInfos();
            lbParaList.DataSource = reportsLeftNotes;
            lbSelParaList.DataSource = reportsRightNotes;
        }

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        private void UpdateListBoxes()
        {
            lbParaList.DataSource = null;
            lbSelParaList.DataSource = null;
            lbParaList.DataSource = reportsLeftNotes;
            lbSelParaList.DataSource = reportsRightNotes;
        }

        private async Task LoadReportParaInfos()
        {
            ResponseInfo response = await _modbusParaBLL.DoGetModbusReportParaInfos(true);
            if (response.Status == 1)
            {
                List<ModbusParaSetInfo> reports = response.Value as List<ModbusParaSetInfo>;
                foreach (ModbusParaSetInfo report in reports)
                {
                    reportDicts.Add(report.Note, report);
                    reportsLeftNotes.Add(report.Note);
                }
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveLbItem(lbParaList, reportsLeftNotes, reportsRightNotes);
        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            MoveLbAllItems(reportsLeftNotes, reportsRightNotes);
        }

        private void MoveLbItem(ListBox lbList, List<string> removeList, List<string> addList)
        {
            if (lbList.Items.Count == 0 || lbList.SelectedItem == null)
                return;
            SelectedObjectCollection selVals = lbList.SelectedItems;
            foreach (var selval in selVals)
            {
                string v = selval.ToString();
                removeList.Remove(v);
                addList.Add(v);
            }

            UpdateListBoxes();
        }

        private void MoveLbAllItems(List<string> removeList, List<string> addList)
        {
            addList.AddRange(removeList);
            removeList.Clear();
            UpdateListBoxes();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveLbItem(lbSelParaList, reportsRightNotes, reportsLeftNotes);
        }

        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            MoveLbAllItems(reportsRightNotes, reportsLeftNotes);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            selReportsPara.Clear();
            foreach (var note in reportsRightNotes)
            {
                if (reportDicts.ContainsKey(note))
                {
                    ModbusParaSetInfo modbusSet = reportDicts[note];

                    if (modbusSet.ParaName.StartsWith("Actual"))
                    {
                        selReportsPara.Add(modbusSet.ParaName.Substring(7));
                    }
                    else
                    {
                        selReportsPara.Add(modbusSet.ParaName);
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}