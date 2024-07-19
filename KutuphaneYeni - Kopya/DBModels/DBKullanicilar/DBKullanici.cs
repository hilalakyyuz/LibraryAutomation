using KutuphaneYeni.Entities.EntityKullanici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYeni
{
    public class DBKullanici
    {
        private static object baglanti;

        public static List<Kullanicilar> Liste()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var kullanici = db.Kullanicilar.ToList();
                return kullanici;
            }

        }//entityframework örnegi
        public static List<EntityKullanici> Liste2()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var kullanici = db.Kullanicilar.Select(a => new EntityKullanici
                {

                    ID = a.ID,
                    AdSoyad = a.AdSoyad,
                    Email = a.Email,
                    KayitYapan = a.KayitYapan,
                    KayitTarihi = a.KayitTarihi,
                    DegisiklikTarihi = a.DegisiklikTarihi,
                    DegisiklikYapan = a.DegisiklikYapan,
                    Resim=a.Resimler.FirstOrDefault(x=>x.VarsayilanResim!=null&&x.VarsayilanResim.Value).Resim,
                 




                }).ToList();
                return kullanici;
            }

        }
        public static void Ekle(int kullaniciID, Kullanicilar item)
        {

            using (var db = new kutuphane_uygEntities1())
            {

                db.Kullanicilar.Add(item);
                db.SaveChanges();
            }
        }
        public static Kullanicilar GetKategoriler(Kullanicilar item)
        {
            return new Kullanicilar
            {
                ID = item.ID,
                AdSoyad = item.AdSoyad,
                Email = item.Email,
                Resim = item.Resim,
                KayitYapan = item.KayitYapan,
                KayitTarihi = item.KayitTarihi,
                DegisiklikYapan = item.DegisiklikYapan,
                DegisiklikTarihi = item.DegisiklikTarihi,



            };
        }
        public static Kullanicilar Getir(int id)
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var item = db.Kullanicilar.Where(x => x.ID == id).FirstOrDefault();
                return item;
            }
        }
        public static void Sil(int id)
        {
            using (var db = new kutuphane_uygEntities1())
            {
                var kullanici = db.Kullanicilar.FirstOrDefault(x => x.ID == id);

                if (kullanici != null)
                {
                    
                    var relatedResimler = db.Resimler.Where(r => r.KullaniciID == id).ToList();
                    foreach (var resim in relatedResimler)
                    {
                        db.Resimler.Remove(resim);
                    }

                    try
                    {
                        db.Kullanicilar.Remove(kullanici);
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Kullanıcıya ait resim kayıtlarını silmeden kullanıcıyı silemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


    public static void Düzenle(Kullanicilar item)
        {
            using (var db = new kutuphane_uygEntities1())
            {


                var newitem = db.Kullanicilar.Where(x => x.ID == item.ID).FirstOrDefault();
                if (newitem == null)
                {
                    return;
                }

                newitem.AdSoyad = item.AdSoyad;
                newitem.Email = item.Email;
                newitem.Resim = item.Resim;
                newitem.DegisiklikYapan = item.DegisiklikYapan;
                newitem.DegisiklikTarihi = item.DegisiklikTarihi;
                db.SaveChanges();

            }
        }

        
        }
    }
