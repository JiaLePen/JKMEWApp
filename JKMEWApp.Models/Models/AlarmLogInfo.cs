using System;
using System.Collections.Generic;

namespace JKMEWApp.Models.Models
{
    public class AlarmLogInfo
    {
        public int AlarmLogId { get; set; }

        public int? AparaId { get; set; }

        public string AparaName { get; set; }

        public decimal Value { get; set; }

        public string AlarmState { get; set; }

        public string AlarmNote { get; set; }

        public DateTime AlarmTime { get; set; }

        public int IsDeleted { get; set; }

        private string _aTypeName = "低报警";

        public string ATypeName
        {
            get
            {
                if (AlarmState == "LAlarm")
                {
                    _aTypeName = "低报警";
                }
                else if (AlarmState == "HAlarm")
                {
                    _aTypeName = "高报警";
                }
                else if (AlarmState == "UnLAlarm")
                {
                    _aTypeName = "取消低报警";
                }
                else if (AlarmState == "UnHAlarm")
                {
                    _aTypeName = "取消高报警";
                }
                return _aTypeName;
            }
        }
    }
}