using JKMEWApp.BLL;
using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.Tools
{
    public class ModbusDataCenter
    {
        private static ModbusParaBLL _modbusParaBLL = new ModbusParaBLL();

        /// <summary>
        /// 设备的初始设置变量参数集合： 不包含Actual的字段
        /// </summary>
        public static Dictionary<string, ModbusParaSetInfo> SetParaAddress = new Dictionary<string, ModbusParaSetInfo>();

        /// <summary>
        /// 设备的初始设置参数值的集合 (和下位机读到的数据进行匹对)
        /// </summary>
        public static Dictionary<string, string> SetParaValues = new Dictionary<string, string>();

        //从数据库加载初始数据
        public static async Task LoadSqlData()
        {
            ResponseInfo response = await _modbusParaBLL.GetModbusParaInfosBySlaveId(2);
            if (response.Status == 1)
            {
                List<ModbusParaSetInfo> modbusParaSetInfos = response.Value as List<ModbusParaSetInfo>;
                foreach (var tmp in modbusParaSetInfos)
                {
                    SetParaAddress.Add(tmp.ParaName, tmp);
                }
            }
        }
    }
}