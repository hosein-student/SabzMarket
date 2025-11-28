using HttpClientToCurl;
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
using static System.Runtime.InteropServices.JavaScript.JSType;


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
            string curl = "";
            try
            {
                var req = new HttpRequestMessage(HttpMethod.Get, new Uri(RouteConstants.BaseUrl + route));



                curl = client.GenerateCurlInString(req);
                var response = await client.SendAsync(req);
                if (!response.IsSuccessStatusCode)
                {
                    try
                    {
                        var error = new ErrorLogDTO
                        {
                            Curl = curl,
                            Layer = GetType().Name,
                            Message = response.StatusCode.ToString()
                        };

                        await LogError<ErrorLogDTO>(RouteConstants.LogError, error);
                        return default(T);
                    }
                    catch (Exception ex)
                    {
                        return default(T);
                    }

                }
                string content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(content);
                return result;
            }
            catch (Exception ex)
            {
                try
                {
                    var error = new ErrorLogDTO
                    {
                        Curl = curl,
                        Layer = GetType().Name,
                        Message = ex.Message,
                        Route = route,
                        Source = ex.Source,
                        StackTrace = ex.StackTrace
                    };
                    await LogError<ErrorLogDTO>(RouteConstants.LogError, error);
                    return default(T);

                }
                catch (Exception ex1)
                {
                    return default(T);
                }
            }


        }
        public async Task<Tout> PostAsync<Tout, Tin>(string route, Tin data)
        {
            string curl = "";
            try
            {
                string json = JsonConvert.SerializeObject(data);
                StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                var req = new HttpRequestMessage(HttpMethod.Post, new Uri(RouteConstants.BaseUrl + route))
                {
                    Content = stringContent,
                };
                curl = client.GenerateCurlInString(req);
                var response = await client.SendAsync(req);
                if (!response.IsSuccessStatusCode)
                {
                    try
                    {
                        var error = new ErrorLogDTO
                        {
                            Curl = curl,
                            Layer = GetType().Name,
                            Message = response.StatusCode.ToString()
                        };

                        await LogError<ErrorLogDTO>(RouteConstants.LogError, error);
                        return default(Tout);
                    }
                    catch (Exception ex)
                    {
                        return default(Tout);
                    }
                }
                string content = await response.Content.ReadAsStringAsync();
                var resilt = JsonConvert.DeserializeObject<Tout>(content);
                return resilt;
            }
            catch (Exception ex)
            {
                try
                {
                    var error = new ErrorLogDTO
                    {
                        Curl = curl,
                        Layer = GetType().Name,
                        Message = ex.Message,
                        Route = route,
                        Source = ex.Source,
                        StackTrace = ex.StackTrace
                    };
                    await LogError<ErrorLogDTO>(RouteConstants.LogError, error);
                    return default(Tout);

                }
                catch (Exception ex1)
                {
                    return default(Tout);
                }
            }

        }
        private async Task LogError<Tin>(string route, Tin data)
        {
            try
            {
                using var tempClient = new HttpClient();
                string json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                await tempClient.PostAsync(RouteConstants.LogError, content);
            }
            catch (Exception ex)
            {

            }

        }
    }
}
