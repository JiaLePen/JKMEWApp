using JKMEWApp.DAL;
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
    public class AlarmParaBLL
    {
        private AlarmParaDAL _alarmParaDAL = new AlarmParaDAL();

        public async Task<ResponseInfo> DoGetParaNameAlarmInfo(string paraName)
        {
            string resInfo = await _alarmParaDAL.GetParaNameAlarmInfo(paraName);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JArray jobject = response.Value as JArray;

                response.Value = jobject.ToObject<List<AlarmParaInfo>>();
            }

            return response;
        }
    }
}