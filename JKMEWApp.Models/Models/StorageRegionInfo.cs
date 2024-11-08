using System;
using System.Collections.Generic;

namespace JKMEWApp.Models.Models
{
    public class StorageRegionInfo
    {
        public int Id { get; set; }

        public int SlaveAddress { get; set; }

        public int FunctionCode { get; set; }

        public int StartAddress { get; set; }

        public int Length { get; set; }

        public string Remark { get; set; }

        public int IsDeleted { get; set; }
    }
}