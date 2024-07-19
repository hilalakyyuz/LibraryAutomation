using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using KutuphaneYeni.DBModels;
using Newtonsoft.Json;

namespace KutuphaneYeni
{
    public static class HttpClientManager
    {
        private static readonly HttpClient _client;
        static string _apiUrl = Degiskenler.apiUrl;

        static HttpClientManager()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            SetAuthorizationHeaderAsync(); 
        }
        private static  void SetAuthorizationHeaderAsync()
        {
            var token = Token.DBToken.GetToken(); 
            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        }
        public static T Get<T>(string endpoint)
        {
            var response = _client.GetAsync(_apiUrl + endpoint).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                var liste = JsonConvert.DeserializeObject<T>(json);
                return liste;
            }
            else
            {
            
                throw new Exception($"HTTP isteği başarısız {endpoint}. Status code: {response.StatusCode}");
            }
        }
        public static bool Post<T>(string endpoint, T data)
        {
            try
            {
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = _client.PostAsync(_apiUrl + endpoint, content).Result; 
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException ex)
            {
                XtraMessageBox.Show($"HTTP isteği başarısız: {ex.Message}");
                return false;
            }
        }
        public static bool Put<T>(int id, string endpoint, T data)
        {
            try
            {
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = _client.PutAsync(_apiUrl + endpoint + "/" + id, content).Result;
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException ex)
            {
                XtraMessageBox.Show($"HTTP isteği başarısız: {ex.Message}");
                return false;
            }
        }
        public static bool Delete(string endpoint)
        {
            try
            {
                var response = _client.GetAsync(_apiUrl + endpoint).Result;
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException ex)
            {
                XtraMessageBox.Show($"HTTP isteği başarısız: {ex.Message}");
                return false;
            }
        }



    }
}
