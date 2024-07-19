using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni.Entities.EntityKullanici
{
      public class EntityKullanici
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string KayitYapan { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string DegisiklikYapan { get; set; }
        public DateTime? DegisiklikTarihi { get; set; }
        public byte[] Resim { get; set; }



    }
}
