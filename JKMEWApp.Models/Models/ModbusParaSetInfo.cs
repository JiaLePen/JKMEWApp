using System;
using System.Collections.Generic;

namespace JKMEWApp.Models.Models
{
    public class ModbusParaSetInfo
    {
        public int ParaId { get; set; }

        public string ParaName { get; set; }

        public int SlaveAddress { get; set; }

        public int Address { get; set; }

        public string DataType { get; set; }

        public int DecimalPlaces { get; set; }

        public string StoreFunction { get; set; }

        public string Note { get; set; }

        public bool IsAlarm { get; set; }

        public bool IsReport { get; set; }

        public int IsDeleted { get; set; }
    }
}