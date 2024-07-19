using KutuphaneYeni.DBModels;
using KutuphaneYeni.DBResimler;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni
{
    public class ApiResim
    {
        static string apiUrl = Degiskenler.apiUrl;

        public static List<Resimler> GetResimler()
        {
            try
            {
                return HttpClientManager.Get<List<Resimler>>("api/resimler/liste");
            }
            catch (Exception ex)
            {
                
                return null;
            }
        }

        public static List<Resimler> GetResimlerByKullaniciID(int kullaniciID)
        {
            try
            {
                return HttpClientManager.Get<List<Resimler>>($"/api/resimler/kullanici?kullaniciID={kullaniciID}");
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static Resimler GetVarsayilanResim(int kullaniciID)
        {
            try
            {
                return HttpClientManager.Get<Resimler>($"api/resimler/varsayilan/{kullaniciID}");
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        public static bool EkleResim(List<Resimler> resim)
        {
            try
            {
                return HttpClientManager.Post<List<Resimler>>($"api/resimler/ekle/",resim);
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static async Task<bool> DuzenleResim(Resimler resim)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var jsonContent = JsonConvert.SerializeObject(resim);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token.DBToken.GetToken());

                HttpResponseMessage response = await client.PutAsync(apiUrl+$"api/resimler/duzenle/{resim.ID}", content);
                return response.IsSuccessStatusCode;
            }
        }
        public static bool SilResim(int id)
        {
            try
            {
                return HttpClientManager.Delete($"api/resimler/sil/{id}");
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
