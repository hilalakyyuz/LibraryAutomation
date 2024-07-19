using KutuphaneYeni.DBModels;
using KutuphaneYeni.Entities.EntityKitap;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni
{
    public class ApiKitap
    {
        static string apiUrl = Degiskenler.apiUrl;

        public static List<EntityKitap> KitapListe()
        {
            try
            {
                return HttpClientManager.Get<List<EntityKitap>>("api/kitaplar/GetKitaplar");
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static EntityKitap KitapGetir(int id)
        {
            try
            {
                return HttpClientManager.Get<EntityKitap>($"api/kitaplar/GetKitap?id={id}");
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static bool KitapEkle(EntityKitap kitap)
        {
            try
            {
                return HttpClientManager.Post<EntityKitap>($"api/kitaplar/PostKitap", kitap);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool KitapDuzenle(int id, EntityKitap kitap)
        {
            try
            {
                return HttpClientManager.Put<EntityKitap>(id,"api/kitaplar/PutKitap/", kitap);
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static bool KitapSil(int id)
        {
            try
            {
                return HttpClientManager.Delete($"api/kitaplar/GetKitapSil?id={id}");
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}