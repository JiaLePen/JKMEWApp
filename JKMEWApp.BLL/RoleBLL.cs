using JKMEWApp.DAL;
using JKMEWApp.Models.BModels;
using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace JKMEWApp.BLL
{
    public class RoleBLL
    {
        private RoleDAL _roleDal = new RoleDAL();

        public async Task<ResponseInfo> DoGetRoles(int isDel)
        {
            string resInfo = await _roleDal.GetRoles(isDel);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JArray jobject = response.Value as JArray;

                response.Value = jobject.ToObject<List<RoleInfo>>();
            }

            return response;
        }

        public async Task<ResponseInfo> DoUpdateRole(RoleInfo roleInfo)
        {
            string resInfo = await _roleDal.UpdateRole(roleInfo);
            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);
            return response;
        }

        public async Task<ResponseInfo> DoUpdateRoleMenus(dynamic obj)
        {
            string resInfo = await _roleDal.UpdateRoleMenus(obj);
            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);
            return response;
        }

        public async Task<ResponseInfo> DoGetRolesByUserId(int userId)
        {
            string resInfo = await _roleDal.GetRolesByUserId(userId);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JArray jobject = response.Value as JArray;

                response.Value = jobject.ToObject<List<int>>();
            }

            return response;
        }
    }
}