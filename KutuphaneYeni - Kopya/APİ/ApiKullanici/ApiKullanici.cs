using KutuphaneYeni.DBModels;
using KutuphaneYeni.Entities.EntityKullanici;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni
{

    public class ApiKullanici
    {
        static string apiUrl = Degiskenler.apiUrl;

        public static List<EntityKullanici> KullaniciListe()
        {
            try
            {
                return HttpClientManager.Get<List<EntityKullanici>>("api/kullanicilar/GetKullanicilar");
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static EntityKullanici KullaniciGetir(int id)
        {
            try
            {
                return HttpClientManager.Get<EntityKullanici>($"api/kullanicilar/GetKullanici?id={id}");
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static bool KullaniciEkle(EntityKullanici kullanici)
        {
            try
            {
                return HttpClientManager.Post<EntityKullanici>("api/kullanicilar/PostKullanici",kullanici);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool KullaniciDuzenle(int id, EntityKullanici kullanici)
        {
            try
            {
                return HttpClientManager.Put<EntityKullanici>(id,"api/kullanicilar/PutKullanici/", kullanici);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool KullaniciSil(int id)
        {
            try
            {
                return HttpClientManager.Delete($"api/kullanicilar/GetKullaniciSil?id={id}");
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
    }




