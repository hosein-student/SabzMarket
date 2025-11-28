using Newtonsoft.Json;
using Polly;
using Polly.Extensions.Http;
using Polly.Retry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share
{
    public sealed class HttpClientHelper
    {
        private readonly HttpClient client;
        private HttpClientHelper()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(RouteConstants.BaseUrl);
            client.Timeout = TimeSpan.FromSeconds(60);

            


        }
        private static readonly Lazy<HttpClientHelper> _instance =
           new Lazy<HttpClientHelper>(() => new HttpClientHelper());
        public static HttpClientHelper Instance
        {
            get
            {
                return _instance.Value; 
            }
        }
        public async Task<T> GetAsync<T>(string route)
        {
            try
            {
                var req = new HttpRequestMessage(HttpMethod.Get, new Uri(RouteConstants.BaseUrl + route));
                var curl = await req.ToCurlAsync();
                var response = await client.SendAsync(req);
                if (!response.IsSuccessStatusCode)
                {
                    // ذخیره لاگ در دیتابیس
                    return default(T);
                }
                string content = await response.Content.ReadAsStringAsync();
                var resilt = JsonConvert.DeserializeObject<T>(content);
                return resilt;
            }
            catch (Exception ex)
            {
                return default(T);
            }

            
        }
        public async Task<Tout> PostAsync<Tout, Tin>(string route, Tin data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data);
                StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                var req = new HttpRequestMessage(HttpMethod.Post, new Uri(RouteConstants.BaseUrl + route))
                {
                    Content = stringContent,
                };
                var curl = await req.ToCurlAsync();
                var response = await client.SendAsync(req);
                if (!response.IsSuccessStatusCode)
                {
                    //addlog
                    return default(Tout);
                }
                string content = await response.Content.ReadAsStringAsync();
                var resilt = JsonConvert.DeserializeObject<Tout>(content);
                return resilt;
            }
            catch (Exception ex)
            {
                return default(Tout);
            }
            
        }
    }
}
