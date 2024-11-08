using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.Models.BModels
{
    public class PageModel<T>
    {
        //总记录条数
        public int Total { get; set; }

        //当前页对应的数据
        public List<T> Datas { get; set; }
    }
}