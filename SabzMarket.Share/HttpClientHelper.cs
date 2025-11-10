using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            var response = await client.GetAsync(route);
            string content = await response.Content.ReadAsStringAsync();
            var resilt = JsonConvert.DeserializeObject<T>(content);
            return resilt;
        }
        public async Task<Tout> PostAsync<Tout, Tin>(string route, Tin data)
        {
            string json = JsonConvert.SerializeObject(data);
            StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(route, stringContent);
            string content = await response.Content.ReadAsStringAsync();
            var resilt = JsonConvert.DeserializeObject<Tout>(content);
            return resilt;
        }
    }
}
