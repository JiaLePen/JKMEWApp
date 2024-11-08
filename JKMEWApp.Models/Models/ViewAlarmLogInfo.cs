using System;
using System.Collections.Generic;

namespace JKMEWApp.Models.Models
{
    public class ViewAlarmLogInfo
    {
        public int AlarmLogId { get; set; }

        public string AparaName { get; set; }

        public decimal Value { get; set; }

        public string AlarmState { get; set; }

        public int AlarmType { get; set; }

        public string AlarmValue { get; set; }

        public string AlarmNote { get; set; }

        public string AtypeName { get; set; }

        public DateTime AlarmTime { get; set; }

        public int IsDeleted { get; set; }

        public int? AparaId { get; set; }
    }
}