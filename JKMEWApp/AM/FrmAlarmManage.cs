using JKMEWApp.BLL;
using JKMEWApp.Models.BModels;
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

namespace JKMEWApp.AM
{
    public partial class FrmAlarmManage : UIForm
    {
        private AlarmDataBLL _alarmDataBLL = new AlarmDataBLL();
        private int _total = 0;
        private List<AlarmLogInfo> _alarmDatas;

        public FrmAlarmManage()
        {
            InitializeComponent();
        }

        private async void FrmAlarmManage_Load(object sender, EventArgs e)
        {
            uAlarmPager.PageSize = txtPageSize.Value.GetInt();
            uAlarmPager.OnPageChanged += UAlarmPager_OnPageChanged;
        }

        private async void UAlarmPager_OnPageChanged(object sender, EventArgs e)
        {
            await LoadAlarmData();
        }

        private async Task LoadAlarmData()
        {
            var obj = new
            {
                StartRecord = uAlarmPager.StartRecord,
                PageSize = uAlarmPager.PageSize,
                StartTime = dtStart.Value.ToString(),
                EndTime = dtEnd.Value.ToString(),
            };

            ResponseInfo response = await _alarmDataBLL.DoGetAlarmDatas(obj);
            if (response.Status == 1)
            {
                PageModel<AlarmLogInfo> pageModel = response.Value as PageModel<AlarmLogInfo>;
                _total = pageModel.Total;
                _alarmDatas = pageModel.Datas;
                dgvAlarmList.AutoGenerateColumns = false;
                dgvAlarmList.DataSource = _alarmDatas;

                uAlarmPager.Record = _total;
            }
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            await LoadAlarmData();
        }

        private async void btnSet_Click(object sender, EventArgs e)
        {
            uAlarmPager.PageSize = txtPageSize.Value.GetInt();
            await LoadAlarmData();
        }
    }
}