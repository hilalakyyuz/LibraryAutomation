using KutuphaneYeni.Entities.EntityYazar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni
{
    public class DBYazar
    {
        private static object baglanti;

        public static List<Yazarlar> Liste()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var liste = db.Yazarlar.ToList();
                return liste;
            }

        }

        public static List<EntityYazar> Liste2()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var yazar = db.Yazarlar.Select(a => new EntityYazar
                {
                    ID = a.ID,
                    Ad = a.Ad,
                    Soyad = a.Soyad,
                    DogumTarihi = a.DogumTarihi,
                    Ulke = a.Ulke,
                    KayitYapan = a.KayitYapan,
                    KayitTarihi = a.KayitTarihi,
                    DegisiklikYapan = a.DegisiklikYapan,
                    DegisiklikTarihi = a.DegisiklikTarihi,
                }).ToList();

                return yazar;
            }
        }
        public static void Ekle(Yazarlar item)
        {
            //kayit yapan kayit tarihi ekle
            using (var db = new kutuphane_uygEntities1())
            {
                db.Yazarlar.Add(item);
                db.SaveChanges();
            }
        }
        public static Yazarlar GetYazar(Yazarlar item)
        {
            return new Yazarlar
            {
                ID = item.ID,
                Ad = item.Ad,
                Soyad = item.Soyad,
                DogumTarihi = item.DogumTarihi,
                Ulke = item.Ulke,
                KayitYapan = item.KayitYapan,
                KayitTarihi = item.KayitTarihi,
                DegisiklikYapan = item.DegisiklikYapan,
                DegisiklikTarihi = item.DegisiklikTarihi,


            };
        }
        public static Yazarlar Getir(int id)
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var item = db.Yazarlar.Where(x => x.ID == id).FirstOrDefault();
                return item;
            }
        }
        public static void Sil(int id)
        {
            using (var db = new kutuphane_uygEntities1())
            {

                var yazar = db.Yazarlar.Where(x => x.ID == id).FirstOrDefault();
                db.Yazarlar.Remove(yazar);
                db.SaveChanges();
            }
        }

        public static void Düzenle(Yazarlar item)
        {
            using (var db = new kutuphane_uygEntities1())
            {

                var newitem = db.Yazarlar.Where(x => x.ID == item.ID).FirstOrDefault();
                if (newitem == null)
                {
                    return;
                }
                newitem.ID = item.ID;
                newitem.Ad = item.Ad;
                newitem.Soyad = item.Soyad;
                newitem.DogumTarihi = item.DogumTarihi;
                newitem.Ulke = item.Ulke;
                newitem.DegisiklikYapan = item.DegisiklikYapan;
                newitem.DegisiklikTarihi = item.DegisiklikTarihi;
                db.SaveChanges();

            }
        }




    }


}

