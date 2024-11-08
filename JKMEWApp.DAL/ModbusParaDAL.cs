using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.DAL
{
    public class ModbusParaDAL : BaseDAL
    {
        public async Task<string> GetModbusParaInfos()
        {
            return await http.SendGetRequest($"/api/ModbusPara/list");
        }

        public async Task<string> UpdateModbusParaInfos(dynamic obj)
        {
            return await http.SendPostRequest($"/api/ModbusPara/update", obj);
        }

        public async Task<string> GetModbusParaInfosBySlaveId(int slaveId)
        {
            return await http.SendGetRequest($"/api/ModbusPara/list/{slaveId}");
        }

        public async Task<string> GetModbusReportParaInfos(bool isReport)
        {
            return await http.SendGetRequest($"/api/ModbusPara/list2/{isReport}");
        }
    }
}