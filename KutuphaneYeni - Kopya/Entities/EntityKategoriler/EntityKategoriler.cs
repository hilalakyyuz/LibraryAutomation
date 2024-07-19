using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni.Entities.EntityKategoriler
{
    public class EntityKategoriler
    {
        public int ID { get; set; }
        public string Adi { get;  set; }
        public string KayitYapan { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string DegisiklikYapan { get; set; }
        public DateTime? DegisiklikTarihi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OduncKitaplar> OduncKitaplar { get; set; }
   
    }
}
