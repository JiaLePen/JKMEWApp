using JKMEWApp.DAL;
using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.BLL
{
    public class ReportBLL
    {
        private ReportDAL _reportDAL = new ReportDAL();

        public async Task<ResponseInfo> DoGetReports(dynamic obj)
        {
            string resInfo = await _reportDAL.GetReports(obj);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JArray jobject = response.Value as JArray;

                response.Value = jobject.ToObject<List<ParaDataInfo>>();
            }

            return response;
        }
    }
}