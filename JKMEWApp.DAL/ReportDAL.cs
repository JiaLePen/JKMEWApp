using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.DAL
{
    public class ReportDAL : BaseDAL
    {
        public async Task<string> GetReports(dynamic obj)
        {
            return await http.SendPostRequest($"/api/Report/list", obj);
        }
    }
}