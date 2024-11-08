using JKMEWApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.Models.BModels
{
    public class ResToken
    {
        public string Token { get; set; }
        public string Expiration { get; set; }
        public UserInfo User { get; set; }
    }
}