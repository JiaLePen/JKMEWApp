using JKMEWApp.DAL;
using JKMEWApp.Models.BModels;
using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.BLL
{
    public class MenuBLL
    {
        private MenuDAL _menuDal = new MenuDAL();

        public async Task<ResponseInfo> DoGetMenusByUserId(int userId)
        {
            string resInfo = await _menuDal.GetMenusByUserId(userId);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JArray jobject = response.Value as JArray;

                response.Value = jobject.ToObject<List<MenuInfo>>();
            }

            return response;
        }

        public async Task<ResponseInfo> DoGetMenus(int isDel)
        {
            string resInfo = await _menuDal.GetMenus(isDel);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JArray jobject = response.Value as JArray;

                response.Value = jobject.ToObject<List<MenuInfo>>();
            }

            return response;
        }

        public async Task<ResponseInfo> DoGetMenusByRoleId(int roleId)
        {
            string resInfo = await _menuDal.GetMenusByRoleId(roleId);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JArray jobject = response.Value as JArray;

                response.Value = jobject.ToObject<List<MenuInfo>>();
            }

            return response;
        }

        public async Task<ResponseInfo> DoGetMenusByFilter(dynamic obj)
        {
            string resInfo = await _menuDal.GetMenusByFilter(obj);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JObject jobject = response.Value as JObject;

                response.Value = jobject.ToObject<PageModel<ViewMenuInfo>>();
            }

            return response;
        }
    }
}