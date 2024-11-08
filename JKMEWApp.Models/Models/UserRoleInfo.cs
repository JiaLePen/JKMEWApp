using System;
using System.Collections.Generic;

namespace JKMEWApp.Models.Models
{
    public class UserRoleInfo
    {
        public int Urid { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }

        public int IsDeleted { get; set; }
    }
}