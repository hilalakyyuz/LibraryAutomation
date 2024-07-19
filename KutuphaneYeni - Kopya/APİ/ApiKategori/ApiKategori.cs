using DevExpress.XtraEditors;
using KutuphaneYeni.DBModels;
using KutuphaneYeni.Entities.EntityKategoriler;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace KutuphaneYeni
{
    public class ApiKategori 
    {
         static string apiUrl = Degiskenler.apiUrl;

        public static  List<EntityKategoriler> KategoriListe()
        {
            try
            {
                return  HttpClientManager.Get<List<EntityKategoriler>>("api/kategoriler/GetKategoriler");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Kategori getirme işlemi başarısız: {ex.Message}");
                return null;
            }
        }
        public static EntityKategoriler KategoriGetir(int id)
        {
            try
            {
                return HttpClientManager.Get<EntityKategoriler>($"api/kategoriler/GetKategori?id={id}");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Kategori getirme işlemi başarısız: {ex.Message}");
                return null;
            }
        }
        public static bool KategoriEkle(EntityKategoriler kategori)
        {
            try
            {
                return HttpClientManager.Post<EntityKategoriler>($"api/kategoriler/PostKategori", kategori);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Kategori ekleme işlemi başarısız: {ex.Message}");
                return false;
            }
        }
        public static bool KategoriDuzenle(int id, EntityKategoriler kategori)
        {
            try
            {

                return HttpClientManager.Put<EntityKategoriler>(id, $"api/kategoriler/PutKategori/", kategori);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Kategori getirme işlemi başarısız: {ex.Message}");
                return false;
            }
        }

        public static bool KategoriSil(int id)
        {
            try
            {
                return HttpClientManager.Delete($"api/kategoriler/GetKategoriSil?id={id}");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Kategori silme işlemi başarısız: {ex.Message}");
                return false;
            }
        }
    }
}

