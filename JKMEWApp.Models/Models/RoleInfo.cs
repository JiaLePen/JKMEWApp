using System;
using System.Collections.Generic;

namespace JKMEWApp.Models.Models
{
    public class RoleInfo
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public string Remark { get; set; }

        public bool IsAdmin { get; set; }

        public int IsDeleted { get; set; }

        public DateTime CreateTime { get; set; }
    }
}