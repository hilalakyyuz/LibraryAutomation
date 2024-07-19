
using KutuphaneYeni.Entities.EntityResim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYeni.DBResimler
{
    public class DBResimler
    {
        private static object baglanti;

        public static List<EntityResim> Liste()
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var resim = (from a in db.Resimler
                             select new EntityResim
                             {
                                 ID = a.ID,
                                 KullaniciID = a.KullaniciID,
                                 VarsayilanResim = a.VarsayilanResim,
                                 Resim = a.Resim,
                             })
                             .ToList();

                return resim;
            }
        }
        public static List<EntityResim> ListeGetir(int kullaniciid)
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var resim = (from a in db.Resimler where a.KullaniciID==kullaniciid 
                             select new EntityResim
                             {
                                 ID = a.ID,
                                 KullaniciID = a.KullaniciID,
                                 VarsayilanResim = a.VarsayilanResim,
                                 Resim = a.Resim,
                             })
                             .ToList();

                return resim;
            }
        }
        public static EntityResim VarsayılanGetir(int kullaniciid)
        {
            using (kutuphane_uygEntities1 db = new kutuphane_uygEntities1())
            {
                var resim = (from a in db.Resimler
                             where a.KullaniciID == kullaniciid && a.VarsayilanResim == true
                             select new EntityResim
                             {
                                 ID = a.ID,
                                 KullaniciID = a.KullaniciID,
                                 VarsayilanResim = a.VarsayilanResim,
                                 Resim = a.Resim,
                             }).FirstOrDefault();

                return resim;
            }
        }
        public static void Ekle(List<Resimler> items)
        {
            using (var db = new kutuphane_uygEntities1())
            {
                foreach (var item in items)
                {
                    if (item.ID == 0)
                    {
                        // Check if the related user exists
                        var kullanici = db.Kullanicilar.FirstOrDefault(x => x.ID == item.KullaniciID);
                        if (kullanici != null)
                        {
                            db.Resimler.Add(item);
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcıyı kaydetmeden resim ekleyemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                db.SaveChanges();
            }
        }


        public static void Düzenle(Resimler item)
        {
            using (var db = new kutuphane_uygEntities1())
            {
                try
                {
                    var newitem = db.Resimler.Where(x => x.ID == item.ID).FirstOrDefault();
                    if (newitem == null)
                    {
                        return;
                    }

                    newitem.ID = item.ID;
                    newitem.KullaniciID = item.KullaniciID;
                    newitem.VarsayilanResim = item.VarsayilanResim;
                    newitem.Resim = item.Resim;

                    db.SaveChanges();
                }
                catch (Exception ex)
                { 
                    Console.WriteLine("Error updating image: " + ex.Message);

                }
            }
        }


        public static bool Sil(int id)
        {
            bool sonuc = false;
            using (var db = new kutuphane_uygEntities1())
            {

                var resimler = db.Resimler.Where(x => x.ID == id).FirstOrDefault();

                db.Resimler.Remove(resimler);
                db.SaveChanges();
                sonuc = true;
                return sonuc;
            }
        }

    }
}
