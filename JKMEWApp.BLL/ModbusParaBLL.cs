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
    public class ModbusParaBLL
    {
        private ModbusParaDAL _modbusParaDal = new ModbusParaDAL();

        public async Task<ResponseInfo> DoGetModbusParaInfos()
        {
            string resInfo = await _modbusParaDal.GetModbusParaInfos();

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JArray jobject = response.Value as JArray;

                response.Value = jobject.ToObject<List<ModbusParaSetInfo>>();
            }

            return response;
        }

        public async Task<ResponseInfo> DoUpdateModbusParaInfos(dynamic obj)
        {
            string resInfo = await _modbusParaDal.UpdateModbusParaInfos(obj);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            return response;
        }

        public async Task<ResponseInfo> GetModbusParaInfosBySlaveId(int slaveId)
        {
            string resInfo = await _modbusParaDal.GetModbusParaInfosBySlaveId(slaveId);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JArray jobject = response.Value as JArray;

                response.Value = jobject.ToObject<List<ModbusParaSetInfo>>();
            }

            return response;
        }

        public async Task<ResponseInfo> DoGetModbusReportParaInfos(bool isReport)
        {
            string resInfo = await _modbusParaDal.GetModbusReportParaInfos(isReport);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JArray jobject = response.Value as JArray;

                response.Value = jobject.ToObject<List<ModbusParaSetInfo>>();
            }

            return response;
        }
    }
}