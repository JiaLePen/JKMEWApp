using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.DAL
{
    public class AlarmParaDAL : BaseDAL
    {
        public async Task<string> GetParaNameAlarmInfo(string paraName)
        {
            return await http.SendGetRequest($"/api/AlarmPara/list/{paraName}");
        }
    }
}