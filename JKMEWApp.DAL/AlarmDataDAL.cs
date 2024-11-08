using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.DAL
{
    public class AlarmDataDAL : BaseDAL
    {
        public async Task<string> GetAlarmDatas(dynamic obj)
        {
            return await http.SendPostRequest($"/api/AlarmData/list", obj);
        }
    }
}