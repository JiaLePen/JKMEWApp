using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.DAL
{
    public class MenuDAL : BaseDAL
    {
        public async Task<string> GetMenusByUserId(int userId)
        {
            return await http.SendGetRequest($"/api/Menu/menus/{userId}");
        }

        public async Task<string> GetMenus(int isDel)
        {
            return await http.SendGetRequest($"/api/Menu/list/{isDel}");
        }

        public async Task<string> GetMenusByRoleId(int roleId)
        {
            return await http.SendGetRequest($"/api/Menu/roles/{roleId}");
        }

        public async Task<string> GetMenusByFilter(dynamic obj)
        {
            return await http.SendPostRequest($"/api/Menu/filter", obj);
        }
    }
}