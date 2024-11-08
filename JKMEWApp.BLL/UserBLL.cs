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
    public class UserBLL
    {
        private UserDAL _userDal = new UserDAL();

        public async Task<ResponseInfo> DoLogin(dynamic user)
        {
            string resInfo = await _userDal.Login(user);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JObject jobject = response.Value as JObject;

                response.Value = jobject.ToObject<ResToken>();
            }

            return response;
        }

        public async Task<ResponseInfo> DoGetUsers(dynamic obj)
        {
            string resInfo = await _userDal.GetUsers(obj);

            ResponseInfo response = JsonConvert.DeserializeObject<ResponseInfo>(resInfo);

            if (response.Status == 1)
            {
                JObject jobject = response.Value as JObject;

                response.Value = jobject.ToObject<PageModel<UserInfo>>();
            }

            return response;
        }
    }
}