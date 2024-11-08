using System;
using System.Collections.Generic;

namespace JKMEWApp.Models.Models
{
    public partial class ViewMenuInfo
    {
        public int MenuId { get; set; }

        public string MenuName { get; set; }

        public int ParentId { get; set; }

        public string PmenuName { get; set; }

        public string FrmName { get; set; }

        public bool IsTop { get; set; }

        public int Morder { get; set; }

        public string MenuCode { get; set; }

        public int IsDeleted { get; set; }
    }
}