using JKMEWApp.Models.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.DAL
{
    public class RoleDAL : BaseDAL
    {
        public async Task<string> GetRoles(int isDel)
        {
            return await http.SendGetRequest($"/api/Role/list/{isDel}");
        }

        public async Task<string> UpdateRole(RoleInfo roleInfo)
        {
            return await http.SendPostRequest($"/api/Role/update", roleInfo);
        }

        public async Task<string> UpdateRoleMenus(dynamic obj)
        {
            return await http.SendPostRequest($"/api/Role/updateRoleMenus", obj);
        }

        public async Task<string> GetRolesByUserId(int userId)
        {
            return await http.SendGetRequest($"/api/Role/listByUser/{userId}");
        }
    }
}