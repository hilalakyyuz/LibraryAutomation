 using KutuphaneYeni.Entities.EntityKategoriler;
using KutuphaneYeni.Entities.EntityKitap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni
{
     public  class DBKategori
    {
        private static object baglanti;

        public static List<Kategoriler> Liste()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var kategori = db.Kategoriler.ToList();
                return kategori;
            }

        }
        public static List<EntityKategoriler> Liste2()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var kategori = (from a in db.Kategoriler
                                select new EntityKategoriler
                                {
                                    ID = a.ID,
                                    Adi = a.Adi,
                                    KayitYapan = a.KayitYapan,
                                    KayitTarihi = a.KayitTarihi,
                                    DegisiklikYapan = a.DegisiklikYapan,
                                    DegisiklikTarihi = a.DegisiklikTarihi,
                                })
                .ToList();

                return kategori;
            }

        }
        public static void Ekle(Kategoriler item)
        {
            //kayit yapan kayit tarihi ekle
            using (var db = new kutuphane_uygEntities1())
            {
                db.Kategoriler.Add(item);
                db.SaveChanges();
            }
        }
        public static Kategoriler GetKategoriler(Kategoriler item)
        {
            return new Kategoriler
            {
                ID=item.ID,
                Adi = item.Adi,
                KayitYapan = item.KayitYapan,
                KayitTarihi = item.KayitTarihi,
                DegisiklikYapan = item.DegisiklikYapan,
                DegisiklikTarihi = item.DegisiklikTarihi,
               

            };
        }
        public static Kategoriler Getir(int id)
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var item = db.Kategoriler.Where(x => x.ID == id).FirstOrDefault();
                return item;
            }
        }
        public static void Sil(int id)
        {
            using (var db = new kutuphane_uygEntities1())
            {

                var kategori = db.Kategoriler.Where(x => x.ID == id).FirstOrDefault();
                db.Kategoriler.Remove(kategori);
                db.SaveChanges();
            }
        }

        public static void Düzenle(Kategoriler item)
        {
            using (var db = new kutuphane_uygEntities1())
            {
                var newitem = db.Kategoriler.Where(x => x.ID == item.ID).FirstOrDefault();
                if (newitem == null)
                {
                    return;
                }
                newitem.Adi = item.Adi;
                newitem.DegisiklikYapan = item.DegisiklikYapan;
                newitem.DegisiklikTarihi = item.DegisiklikTarihi;
                db.SaveChanges();

            }
        }




    }


}
