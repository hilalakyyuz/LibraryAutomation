using DevExpress.XtraEditors;
using KutuphaneYeni.Entities.EntityKitap;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni
{
    public class DBKitap
    {
        //private static object baglanti;

        public static List<Kitaplar> Liste()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var kitap = db.Kitaplar.ToList();
                return kitap;
            }

        }
        public static List<EntityKitap> Liste2()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var kitap = (from a in db.Kitaplar
                             select new EntityKitap
                             {
                                 ID = a.ID,
                                 Ad = a.Ad,
                                 KategoriID = a.KategoriID,
                                 Adi = a.Kategoriler.Adi,
                                 YazarID = a.YazarID,
                                 Adyazar = a.Yazarlar.Ad,
                                 Fiyat = a.Fiyat,
                                 YayinYili = a.YayinYili,
                                 SayfaSayisi = a.SayfaSayisi,
                                 DegisiklikTarihi = a.DegisiklikTarihi,
                                 DegisiklikYapan = a.DegisiklikYapan,
                                 KayitYapan = a.KayitYapan,
                                 KayitTarihi = a.KayitTarihi,




                             })
                .ToList();

                return kitap;
            }

        }
        public static void Ekle(Kitaplar item)
        {
            //kayit yapan kayit tarihi ekle
            using (var db = new kutuphane_uygEntities1())
            {
                db.Kitaplar.Add(item);
                db.SaveChanges();
            }
        }
        public static Kitaplar GetKitaplar(Kitaplar item)
        {
            return new Kitaplar
            {
                ID = item.ID,
                Ad = item.Ad,
                KategoriID = item.KategoriID,
                YazarID = item.YazarID,
                Fiyat = item.Fiyat,
                YayinYili = item.YayinYili,
                SayfaSayisi = item.SayfaSayisi,
                DegisiklikTarihi = item.DegisiklikTarihi,
                DegisiklikYapan = item.DegisiklikYapan,
                KayitYapan = item.KayitYapan,
                KayitTarihi = item.KayitTarihi,


            };
        }
        public static Kitaplar Getir(int id)
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var item = db.Kitaplar.Where(x => x.ID == id).FirstOrDefault();
                return item;
            }
        }
        public static bool Sil(int id)
        {
            using (var db = new kutuphane_uygEntities1())
            {
                bool sonuc = false;
                var kitap = db.Kitaplar.Where(x => x.ID == id).FirstOrDefault();
                var kontrol = db.OduncKitaplar.Where(z => z.KitapID == id).FirstOrDefault();
                if (kontrol != null)
                {
                    XtraMessageBox.Show("Kayıt başka yerde kullanılmış...Silemesiniz.");
                    sonuc = false;
                }
                else
                {
                    sonuc = true;
                    db.Kitaplar.Remove(kitap);
                    db.SaveChanges();
                }
                return sonuc;
            }
        }

        public static void Düzenle(Kitaplar item, DbContext dd = null)
        {
            if (dd != null)
            {
                var newitem = dd.Set<Kitaplar>().Where(x => x.ID == item.ID).FirstOrDefault();
                if (newitem == null)
                {
                    return;
                }
                newitem.ID = item.ID;
                newitem.KategoriID = item.KategoriID;
                newitem.Ad = item.Ad;
                newitem.Fiyat = item.Fiyat;
                newitem.YazarID = item.YazarID;
                newitem.DegisiklikYapan = item.DegisiklikYapan;
                newitem.DegisiklikTarihi = item.DegisiklikTarihi;
                return;
            }
            using (var db = new kutuphane_uygEntities1())
            {

                var newitem = db.Kitaplar.Where(x => x.ID == item.ID).FirstOrDefault();
                if (newitem == null)
                {
                    return;
                }
                newitem.ID = item.ID;
                newitem.KategoriID = item.KategoriID;
                newitem.Ad = item.Ad;
                newitem.Fiyat = item.Fiyat;
                newitem.YazarID = item.YazarID;
                newitem.DegisiklikYapan = item.DegisiklikYapan;
                newitem.DegisiklikTarihi = item.DegisiklikTarihi;
                db.SaveChanges();

            }
        }


    }
}
