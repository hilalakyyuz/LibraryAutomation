using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KutuphaneYeni.jsonFormat
{
      public class jsonModel
    {
        //kullanıcı bilgisini modelleyip, jsona ceviriyoruz.sonra tekrar bu modele ceviriyoruz.

          public string kullaniciAdi { get; set; }
          public string sifre { get; set; }
          public string rememberMe { get; set; }

    }
}

