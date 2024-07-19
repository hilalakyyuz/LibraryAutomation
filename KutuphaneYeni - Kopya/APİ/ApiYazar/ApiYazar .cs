using KutuphaneYeni.DBModels;
using KutuphaneYeni.Entities.EntityYazar;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni
{
    public class ApiYazar
    {
        static string apiUrl = Degiskenler.apiUrl;
        public static List<EntityYazar> YazarListe()
        {
            try
            {
                return HttpClientManager.Get <List<EntityYazar>>("api/yazarlar/GetYazarlar");

            }
            catch (Exception)
            {

                return null;
            }
            
        }
        public static EntityYazar YazarGetir(int id)
        {
            try
            {
                return HttpClientManager.Get<EntityYazar>($"api/yazarlar/GetYazar?id={id}");

            }
            catch (Exception)
            {

                return null;
            }

        }

        public static bool YazarEkle(EntityYazar yazar)
        {
            try
            {
                return HttpClientManager.Post<EntityYazar>("api/yazarlar/postyazar" , yazar);
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static bool YazarDuzenle(int id, EntityYazar yazar)
        {
            try
            {
                return HttpClientManager.Put<EntityYazar>(id,"api/yazarlar/PutYazar/", yazar);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool YazarSil(int id)
        {
            try
            {
                return HttpClientManager.Delete($"api/yazarlar/GetYazarSil?id={id}");
            }
            catch (Exception)
            {

                return false;
            }
        }

        }

    }




