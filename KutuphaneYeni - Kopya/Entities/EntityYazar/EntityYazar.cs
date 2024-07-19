using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni.Entities.EntityYazar
{
  public  class EntityYazar
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Ulke { get; set; }
        public string KayitYapan { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string DegisiklikYapan { get; set; }
        public DateTime? DegisiklikTarihi { get; set; }
    }
}
