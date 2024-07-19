using KutuphaneYeni.Entities.EntityOduncKitaplar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni
{
    public class DBOdunc
    {
        private static object baglanti;

        public static List<OduncKitaplar> Liste()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var oduncKitaplar = db.OduncKitaplar.ToList();
                return oduncKitaplar;
            }

        }//linq örnegi
        public static List<EntityOduncK> Liste2()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var kitap = (from a in db.OduncKitaplar
                             select new EntityOduncK
                             {
                                 ID = a.ID,
                                 KitapID = a.KitapID,
                                 KitapAdi = a.Kitaplar.Ad,
                                 KullaniciID = a.KullaniciID,
                                 KullaniciAdi = a.Kullanicilar.AdSoyad,
                                 DegisiklikTarihi = a.DegisiklikTarihi,
                                 DegisiklikYapan = a.DegisiklikYapan,
                                 KayitTarihi = a.KayitTarihi,
                                 KayitYapan = a.KayitYapan,
                                 AlisTarihi = a.AlisTarihi,
                                 TeslimTarihi = a.TeslimTarihi,
                                 TeslimDurumu = a.TeslimDurumu,
                                 YazarID = a.Kitaplar.YazarID,
                                 
                                
                                
                             })
                .ToList();

                return kitap;
            }

        }
        public static List<EntityOduncK> RaporListe(int kullaniciid)
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var kitap = (from a in db.OduncKitaplar
                             
                             select new EntityOduncK
                             {
                                 ID = a.ID,
                                 KitapID = a.KitapID,
                                 KitapAdi = a.Kitaplar.Ad,
                                 KullaniciID = a.KullaniciID,
                                 KullaniciAdi = a.Kullanicilar.AdSoyad,
                                 DegisiklikTarihi = a.DegisiklikTarihi,
                                 DegisiklikYapan = a.DegisiklikYapan,
                                 KayitTarihi = a.KayitTarihi,
                                 KayitYapan = a.KayitYapan,
                                 AlisTarihi = a.AlisTarihi,
                                 TeslimTarihi = a.TeslimTarihi,
                                 TeslimDurumu = a.TeslimDurumu,
                                 YazarID = a.Kitaplar.YazarID,
                                 YazarAdi=a.Kitaplar.Yazarlar.Ad,
                                 YazarSoyad=a.Kitaplar.Yazarlar.Soyad,
                                 KategoriID=a.Kitaplar.KategoriID,
                                 KategoriAdi=a.Kitaplar.Kategoriler.Adi,



                             }).Where(x=> x.KullaniciID ==kullaniciid)
                .ToList();

                return kitap;
            }

        }
        public static void Ekle(OduncKitaplar item)
        {
            //kayit yapan kayit tarihi ekle
            using (var db = new kutuphane_uygEntities1())
            {
                db.OduncKitaplar.Add(item);
                db.SaveChanges();
            }
        }
        public static OduncKitaplar GetOduncKitaplar(OduncKitaplar item)
        {
            return new OduncKitaplar
            {

                ID = item.ID,
                KitapID = item.KitapID,
                KullaniciID = item.KullaniciID,
                AlisTarihi = item.AlisTarihi,
                TeslimTarihi = item.TeslimTarihi,
                TeslimDurumu = item.TeslimDurumu,
                KayitYapan = item.KayitYapan,
                KayitTarihi = item.KayitTarihi,
                DegisiklikYapan = item.DegisiklikYapan,
                DegisiklikTarihi = item.DegisiklikTarihi,


            };
        }

        public static OduncKitaplar Getir(int id)
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var item = db.OduncKitaplar.Where(x => x.ID == id).FirstOrDefault();
                return item;
            }
        }
        public static EntityOduncK Getir2(int id)
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {

                var item = (from a in db.OduncKitaplar where a.ID == id select new EntityOduncK {
                    ID = a.ID,
                    AlisTarihi=a.AlisTarihi,
                    KitapAdi=a.Kitaplar.Ad,
                    KullaniciAdi=a.Kullanicilar.AdSoyad,
                    SayfaSayisi=a.Kitaplar.SayfaSayisi,
                    Fiyat=a.Kitaplar.Fiyat,
                    YazarID=a.Kitaplar.YazarID,
                    YazarAdi=a.Kitaplar.Yazarlar.Ad,
                    KategoriAdi=a.Kitaplar.Kategoriler.Adi,
            



                    
                }).FirstOrDefault();
                return item;
            }
        }
        public static bool Sil(int id)
        {
            bool sonuc = false;
            using (var db = new kutuphane_uygEntities1())
            {

                var oduncKitaplar = db.OduncKitaplar.Where(x => x.ID == id).FirstOrDefault();

                db.OduncKitaplar.Remove(oduncKitaplar);
                db.SaveChanges();
                sonuc = true;
                return sonuc;
            }
        }

        public static void Düzenle(OduncKitaplar item)
        {
            using (var db = new kutuphane_uygEntities1())
            {

                var newitem = db.OduncKitaplar.Where(x => x.ID == item.ID).FirstOrDefault();
                if (newitem == null)
                {
                    return;
                }
                newitem.TeslimTarihi = item.TeslimTarihi;
                newitem.KullaniciID = item.KullaniciID;
                newitem.KitapID = item.KitapID;
                newitem.TeslimDurumu = item.TeslimDurumu;
                newitem.AlisTarihi = item.AlisTarihi;
                newitem.DegisiklikYapan = item.DegisiklikYapan;
                newitem.DegisiklikTarihi = item.DegisiklikTarihi;
                db.SaveChanges();

            }
        }
        public static bool Kaydet(List<EntityOduncK> item)
        {
            using (var db = new kutuphane_uygEntities1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                try
                {
                    foreach (var i in item)
                    {
                        if (i.ID == 0)
                        {
                            db.OduncKitaplar.Add(new OduncKitaplar
                            {
                                AlisTarihi = i.AlisTarihi,
                                KitapID = i.KitapID,
                                KullaniciID = i.KullaniciID,
                                TeslimDurumu = i.TeslimDurumu,
                                TeslimTarihi = i.TeslimTarihi,
                            });
                            db.SaveChanges();
                        }
                        else
                        {
                            var newitem = db.OduncKitaplar.FirstOrDefault(x => x.ID == i.ID);
                            if (newitem == null)
                            {
                                // Hata durumunu işle
                                return false;
                            }
                            var _kitaplar = db.Kitaplar.FirstOrDefault(w => w.ID == i.KitapID);
                            if (_kitaplar != null && _kitaplar.YazarID != i.YazarID)
                            {
                                _kitaplar.YazarID = i.YazarID;
                            }
                            // Düzenleme işlemleri
                            newitem.TeslimTarihi = i.TeslimTarihi;
                            newitem.KullaniciID = i.KullaniciID;
                            newitem.KitapID = i.KitapID;
                            newitem.TeslimDurumu = i.TeslimDurumu;
                            newitem.AlisTarihi = i.AlisTarihi;
                            newitem.DegisiklikYapan = i.DegisiklikYapan;
                            newitem.DegisiklikTarihi = i.DegisiklikTarihi;
                            
                            db.SaveChanges();

                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    // Hata durumunu işle veya logla
                    Console.WriteLine($"Hata: {ex.Message}");
                    return false;
                }
            }
        }
    }
}