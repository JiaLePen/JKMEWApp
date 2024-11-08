using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.Models.DTO
{
    public class ModbusSetInfo
    {
        /// <summary>
        /// 连接方式：串口
        /// </summary>
        public string Connection { get; set; }

        /// <summary>
        /// 连接模式   RTU  ASCII
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// 波特率  9600
        /// </summary>
        public int Baud { get; set; }

        /// <summary>
        /// 数据位  8
        /// </summary>
        public int DataBits { get; set; }

        /// <summary>
        /// 校验位   None
        /// </summary>
        public Parity Parity { get; set; }

        /// <summary>
        /// 停止位  1
        /// </summary>
        public StopBits StopBits { get; set; }
    }
}