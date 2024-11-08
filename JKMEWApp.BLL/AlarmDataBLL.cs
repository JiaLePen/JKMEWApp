using JKMEWApp.DAL;
using JKMEWApp.Models.BModels;
using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.BLL
{
    public class AlarmDataBLL
    {
        private AlarmDataDAL _alarmDataDAL = new AlarmDataDAL();

        public async Task<ResponseInfo> DoGetAlarmDatas(dynamic obj)
        {
            string resInfo = await _alarmDataDAL.GetAlarmDatas(obj);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JObject jobject = response.Value as JObject;

                response.Value = jobject.ToObject<PageModel<AlarmLogInfo>>();
            }

            return response;
        }
    }
}