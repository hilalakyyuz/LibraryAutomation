using KutuphaneYeni.DBModels;
using KutuphaneYeni.Entities.EntityOduncKitaplar;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni
{
    public class ApiOdunc
    {
        static string apiUrl = Degiskenler.apiUrl;
        public static List<EntityOduncK> OduncListe()
        {
            try
            {
                return HttpClientManager.Get<List<EntityOduncK>>("api/odunc/GetOduncler");

            }
            catch (Exception)
            {

                return null;
            }
        }

        public static EntityOduncK OduncGetir(int id)
        {
            try
            {
                return HttpClientManager.Get<EntityOduncK>($"api/odunc/GetOdunc?id={id}");

            }
            catch (Exception)
            {

                return null;
            }
        }
        public static EntityOduncK OduncGetir2(int id)
        {
            try
            {
                return HttpClientManager.Get<EntityOduncK>($"api/odunc/GetOdunc2?id={id}");

            }
            catch (Exception)
            {

                return null;
            }
        }
        public static  bool OduncEkle(EntityOduncK odunc)
        {
            try
            {
                return HttpClientManager.Post<EntityOduncK>("api/odunc/PostOdunc" , odunc);

            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool OduncDuzenle(int id, EntityOduncK odunc)
        {
            try
            {
                return HttpClientManager.Put<EntityOduncK>(id,"api/odunc/PutOdunc/",odunc);

            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool OduncSil(int id)
        {
            try
            {
                return HttpClientManager.Delete($"api/odunc/GetOduncSil?id={id}");

            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool OduncKaydet(List<EntityOduncK> oduncListesi)
        {
            try
            {
                return HttpClientManager.Post<List<EntityOduncK>>("api/odunc/PostKaydet", oduncListesi);

            }
            catch (Exception)
            {

                return false;
            }
        }
        public static async Task<bool> OduncKayde4t(List<EntityOduncK> oduncListesi)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token.DBToken.GetToken());

                    var json = JsonConvert.SerializeObject(oduncListesi);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(apiUrl + "api/odunc/PostKaydet", content);

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }
        public static async Task<List<EntityOduncK>> RaporListeAsync(int kullaniciid)
        {
            List<EntityOduncK> liste = new List<EntityOduncK>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token.DBToken.GetToken());

                    var response = await client.GetAsync(apiUrl  + $"api/odunc/raporliste/{kullaniciid}"); 
                    var json = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var oduncKitaplar = JsonConvert.DeserializeObject<List<EntityOduncK>>(json);
                        liste = oduncKitaplar;
                    }
                    return liste;

                }
            }
            catch (Exception ex)
            {
               
            }
             return liste;

        }

    }
}

