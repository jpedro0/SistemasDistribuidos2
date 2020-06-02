using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Services
{
    public static class ConsumirApi
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private static readonly Uri uri = new Uri(ConfigurationManager.AppSettings["UrlApi"]);
              
        public static async Task<T> Get<T>(string url)
        {
            var response = await httpClient.GetAsync(uri.AbsoluteUri + url);

            var json = await response.Content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static async Task Post(string url, object obj)
        {
            var json = JsonConvert.SerializeObject(obj);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            await httpClient.PostAsync(url, data);
        }
    }
}