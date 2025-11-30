using HttpClientToCurl;
using Newtonsoft.Json;
using Polly;
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

        private static readonly Lazy<HttpClientHelper> _instance =
          new Lazy<HttpClientHelper>(() => new HttpClientHelper());

        private readonly AsyncRetryPolicy<HttpResponseMessage> _retryPolicy;

        private static readonly HttpClient logClient = new HttpClient()
        {
            BaseAddress = new Uri(RouteConstants.BaseUrl),
            Timeout = TimeSpan.FromSeconds(30)
        };


        private HttpClientHelper()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(RouteConstants.BaseUrl),
                Timeout = TimeSpan.FromSeconds(60)
            };

            
            _retryPolicy = Policy
                            .HandleResult<HttpResponseMessage>(r =>
                          !r.IsSuccessStatusCode)             // اگر وضعیت 4xx یا 5xx بود دوباره تلاش کن
                            .Or<HttpRequestException>()             // اگر اینترنت قطع شد یا DNS مشکل داشت
                            .Or<TaskCanceledException>()            // اگر Timeout رخ داد
                            .WaitAndRetryAsync(
          retryCount: 3,                      // سه بار تلاش
          sleepDurationProvider: attempt => TimeSpan.FromSeconds(2) // هر بار ۲ ثانیه فاصله
    );
        }

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
                var response = await _retryPolicy.ExecuteAsync(() => client.SendAsync(req));
                if (!response.IsSuccessStatusCode)
                {


                   var result1= await LogError<T,ErrorLogDTO>(new ErrorLogDTO
                    {
                        Curl = curl,
                        Layer = GetType().Name,
                        Message = string.Format("StatusCode= {0}", response.StatusCode)
                    });
                    return result1;
                }
                string content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(content);
                return result;
            }
            catch (Exception ex)
            {
               var resulr= await LogError<T,ErrorLogDTO>(new ErrorLogDTO
                {
                    Curl = curl,
                    Layer = GetType().Name,
                    Message = ex.Message,
                    Route = route,
                    Source = ex.Source,
                    StackTrace = ex.StackTrace
                });
                    return resulr;
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
                var response = await _retryPolicy.ExecuteAsync(() => client.SendAsync(req));
                if (!response.IsSuccessStatusCode)
                {
                        var result1=await LogError<Tout,ErrorLogDTO>( new ErrorLogDTO
                        {
                            Curl = curl,
                            Layer = GetType().Name,
                            Message = string.Format("StatusCode= {0}", response.StatusCode)
                        });
                        return result1;
                }
                string content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Tout>(content);
                return result;
            }
            catch (Exception ex)
            {
                    var result=await LogError<Tout,ErrorLogDTO>( new ErrorLogDTO
                    {
                        Curl = curl,
                        Layer = GetType().Name,
                        Message = ex.Message,
                        Route = route,
                        Source = ex.Source,
                        StackTrace = ex.StackTrace
                    });
                    return result;
            }

        }
        private async Task<Tout> LogError<Tout,Tin>( Tin data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await logClient.PostAsync(RouteConstants.LogError, stringContent);
                string content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Tout>(content);
                return result;
            }
            catch (Exception ex)
            {
                return default(Tout);
            }

        }
    }
}
