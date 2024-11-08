using HslCommunication;
using HslCommunication.ModBus;
using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JKMEWApp.Tools
{
    public class ModbusHelper
    {
        public static string fileName = ConfigurationManager.AppSettings["modbusConfig"].ToString();

        public static ModbusSetInfo GetModbusSetInfo()
        {
            ModbusSetInfo modbusSet = new ModbusSetInfo();
            if (File.Exists(fileName))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);//加载xml文档
                XmlNode root = doc.SelectSingleNode("ModbusSet");
                modbusSet.Connection = root.SelectSingleNode("Connection").InnerText;
                modbusSet.Port = root.SelectSingleNode("Port").InnerText;
                modbusSet.Baud = root.SelectSingleNode("Baud").InnerText.GetInt();
                modbusSet.DataBits = root.SelectSingleNode("DataBits").InnerText.GetInt();
                modbusSet.StopBits = (StopBits)Enum.Parse(typeof(StopBits), root.SelectSingleNode("StopBits").InnerText);
                modbusSet.Mode = root.SelectSingleNode("Mode").InnerText;
                modbusSet.Parity = (Parity)Enum.Parse(typeof(Parity), root.SelectSingleNode("Parity").InnerText);
            }
            else
            {
                modbusSet.Connection = "串口";
                modbusSet.Port = "COM1";
                modbusSet.Baud = 9600;
                modbusSet.DataBits = 8;
                modbusSet.StopBits = StopBits.One;
                modbusSet.Mode = "RTU";
                modbusSet.Parity = Parity.None;
            }
            return modbusSet;
        }

        public static bool SaveModbusConfig(ModbusSetInfo modbusSetInfo)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                var pros = typeof(ModbusSetInfo).GetProperties();

                //如果通信参数的配置文件已经存在，则修改配置文件
                if (File.Exists(fileName))
                {
                    doc.Load(fileName);
                    XmlNode root = doc.SelectSingleNode("ModbusSet");

                    foreach (var p in pros)
                    {
                        root.SelectSingleNode(p.Name).InnerText = p.GetValue(modbusSetInfo).ToString();
                    }
                }
                //如果通信参数的配置文件不存在，则保存配置文件
                else
                {
                    XmlNode root = doc.CreateElement("ModbusSet");

                    foreach (var p in pros)
                    {
                        XmlElement node = doc.CreateElement(p.Name);
                        node.InnerText = p.GetValue(modbusSetInfo).ToString();

                        root.AppendChild(node);
                    }

                    doc.AppendChild(root);
                }
                doc.Save(fileName);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //通信类
        private static ModbusRtu modbus;

        //打开串口
        public static bool CreateSerialMaster()
        {
            modbus = new ModbusRtu();
            ModbusSetInfo modbusSetInfo = GetModbusSetInfo();
            modbus.SerialPortInni(sp =>
            {
                sp.PortName = modbusSetInfo.Port;
                sp.BaudRate = modbusSetInfo.Baud;
                sp.DataBits = modbusSetInfo.DataBits;
                sp.StopBits = modbusSetInfo.StopBits;
                sp.Parity = modbusSetInfo.Parity;
                sp.RtsEnable = false;
            });
            modbus.ReceiveTimeOut = 5000;   // 接收超时，单位毫秒
            modbus.AddressStartWithZero = true;
            modbus.IsStringReverse = false;
            modbus.DataFormat = HslCommunication.Core.DataFormat.ABCD;

            modbus.Crc16CheckEnable = true;
            modbus.IsClearCacheBeforeRead = false;

            OperateResult connect = modbus.Open();
            if (connect.IsSuccess)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //关闭串口
        public static void CloseSerialMaster()
        {
            if (modbus.IsOpen())
            {
                modbus.Close();
            }
        }

        //读取下位机的数据
        public static async Task ReadEquipParaSet()
        {
            if (modbus == null)
            {
                bool isSuccess = CreateSerialMaster();
                if (isSuccess == false)
                {
                    MsgBoxHelper.MsgErrorShow("提示", "打开串口失败");
                    return;
                }
            }

            modbus.Station = 2;
            OperateResult<short[]> result = await modbus.ReadInt16Async("0", 24);
            if (result.IsSuccess)
            {
                short[] values = result.Content;

                for (int i = 0; i < values.Length; i++)
                {
                    ModbusParaSetInfo paraSetInfo = ModbusDataCenter.SetParaAddress.Values.Where(sp => sp.Address == i).FirstOrDefault();
                    if (ModbusDataCenter.SetParaValues.ContainsKey(paraSetInfo.ParaName))
                    {
                        ModbusDataCenter.SetParaValues.Remove(paraSetInfo.ParaName);
                    }

                    if (paraSetInfo.DataType == "Float")
                    {
                        double val = values[i] / Math.Pow(10, paraSetInfo.DecimalPlaces);
                        ModbusDataCenter.SetParaValues.Add(paraSetInfo.ParaName, val.ToString());
                    }
                    else
                    {
                        ModbusDataCenter.SetParaValues.Add(paraSetInfo.ParaName, values[i].ToString());
                    }
                }
            }
        }


        //写下位机数据
        public static async Task<bool> WriteEquipParaSet(int slaveId,int address,short val) {
            if (modbus == null)
            {
                bool isSuccess = CreateSerialMaster();
                if (isSuccess == false)
                {
                    MsgBoxHelper.MsgErrorShow("提示", "打开串口失败");
                    return false;
                }
            }
            modbus.Station = (byte)slaveId;

            OperateResult writeResult = await modbus.WriteOneRegisterAsync(address.ToString(), val);
            return writeResult.IsSuccess;
        }
    }
}