using JKMEWApp.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JKMEWApp.Tools
{
    public class NetWorkHelper
    {
        private HttpClient _httpClient;
        private static string _baseUrl = "https://localhost:7108";

        public NetWorkHelper()
        {
            _httpClient = new HttpClient();
        }

        private void SetToken()
        {
            var token = "";
            if (File.Exists("token.txt"))
            {
                token = File.ReadAllText("token.txt");
            }
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        //发送Get请求
        public async Task<string> SendGetRequest(string url)
        {
            SetToken();
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(_baseUrl + url);
                //response.EnsureSuccessStatusCode(); // 确保请求成功

                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (Exception ex)
            {
                // 处理异常
                Console.WriteLine("发送 GET 请求时出现异常：" + ex.Message);
                return JsonConvert.SerializeObject(new ResponseInfo
                {
                    Status = -1,
                    Title = "请求发送出现错误",
                    Message = ex.Message,
                    Errors = ex.StackTrace,
                    Value = null
                });
            }
        }

        //发送POST请求
        public async Task<string> SendPostRequest(string url)
        {
            return await SendPostRequest(url, null);
        }

        //发送POST请求，重载方法，有请求体的
        public async Task<string> SendPostRequest(string url, object requestBody)
        {
            SetToken();
            try
            {
                HttpResponseMessage response;

                if (requestBody != null)
                {
                    var requestBodyJson = JsonConvert.SerializeObject(requestBody, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });

                    response = await _httpClient.PostAsync(_baseUrl + url, new StringContent(requestBodyJson, Encoding.UTF8, "application/json"));
                }
                else
                {
                    response = await _httpClient.PostAsync(_baseUrl + url, null);
                }

                //response.EnsureSuccessStatusCode(); // 确保请求成功

                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (Exception ex)
            {
                // 处理异常
                Console.WriteLine("发送 POST 请求时出现异常：" + ex.Message);
                return JsonConvert.SerializeObject(new ResponseInfo
                {
                    Status = -1,
                    Title = "请求发送出现错误",
                    Message = ex.Message,
                    Errors = ex.StackTrace,
                    Value = null
                });
            }
        }
    }
}