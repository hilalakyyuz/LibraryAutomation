using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni.Entities.EntityKitap
{
    public class EntityKitap
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public int? KategoriID { get; set; }
        public int? YazarID { get; set; }

        public string YayinYili { get; set; }
        public string SayfaSayisi { get; set; }
        public string Fiyat { get; set; }
        public string KayitYapan { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string DegisiklikYapan { get; set; }
        public DateTime? DegisiklikTarihi { get; set; }
        public string Adyazar { get; set; }
        public string Adi { get;  set; }
        public EntityYazar.EntityYazar Yazarlar { get;  set; }
        public EntityKategoriler.EntityKategoriler Kategori { get; set; }
    }
}