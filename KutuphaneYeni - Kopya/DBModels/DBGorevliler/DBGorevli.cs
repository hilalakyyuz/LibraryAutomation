using KutuphaneYeni.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni
{
    public class DBGorevli
    {

        private static object baglanti;

        public static List<Gorevliler> Liste()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var gorevli = db.Gorevliler.ToList();
                return gorevli;
            }

        }
        public static List<Gorevliler> Liste2()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var gorevli = (from a in db.Gorevliler
                             select new Gorevliler
                             {
                                 ID=a.ID,
                                 AdSoyad = a.AdSoyad,
                                 Email = a.Email,
                                 Sifre = a.Sifre,
                                 DegisiklikTarihi =a.DegisiklikTarihi,
                                 DegisiklikYapan=a.DegisiklikYapan,
                                 KayitTarihi=a.KayitTarihi,
                                 KayitYapan=a.KayitYapan


                             })
                .ToList();

                return gorevli;
            }

        }
        public static void Ekle(Gorevliler item)
        {
            //kayit yapan kayit tarihi ekle
            using (var db = new kutuphane_uygEntities1())
            {
                db.Gorevliler.Add(item);
                db.SaveChanges();
            }
        }
        public static Gorevliler GetGorevliler(Gorevliler item)
        {
            return new Gorevliler
            {
                ID=item.ID,
                Email=item.Email,
                Sifre=item.Sifre,
                AdSoyad= item.AdSoyad,
                KayitYapan = item.KayitYapan,
                KayitTarihi = item.KayitTarihi,
                DegisiklikYapan = item.DegisiklikYapan,
                DegisiklikTarihi = item.DegisiklikTarihi

            };
        }

        public static Gorevliler Getir(int id)
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var item = db.Gorevliler.Where(x => x.ID == id).FirstOrDefault();
                return item;
            }
        }
        public static void Sil(int id)
        {
            using (var db = new kutuphane_uygEntities1())
            {

                var gorevli = db.Gorevliler.Where(x => x.ID == id).FirstOrDefault();
                db.Gorevliler.Remove(gorevli);
                db.SaveChanges();
            }
        }

        public static void Düzenle(Gorevliler item)
        {
            using (var db = new kutuphane_uygEntities1())
            {

                var newitem = db.Gorevliler.Where(x => x.ID == item.ID).FirstOrDefault();
                if (newitem == null)
                {
                    return;
                }

                newitem.AdSoyad = item.AdSoyad;
                newitem.DegisiklikYapan = item.DegisiklikYapan;
                newitem.DegisiklikTarihi = item.DegisiklikTarihi;
                db.SaveChanges();

            }
        }



    }
}
