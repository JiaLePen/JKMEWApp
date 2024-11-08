using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.DAL
{
    public class UserDAL : BaseDAL
    {
        public async Task<string> Login(dynamic user)
        {
            return await http.SendPostRequest("/api/User/Login", user);
        }

        public async Task<string> GetUsers(dynamic obj)
        {
            return await http.SendPostRequest("/api/User/list", obj);
        }
    }
}