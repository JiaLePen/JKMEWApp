using System;
using System.Collections.Generic;

namespace JKMEWApp.Models.Models
{
    public class AlarmParaInfo
    {
        public int AparaId { get; set; }

        public string AparaName { get; set; }

        public int AlarmType { get; set; }

        public string AlarmValue { get; set; }

        public string ValueType { get; set; }

        public string AlarmNote { get; set; }

        public int IsDeleted { get; set; }
    }
}