using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni
{
  public  class Sifreleme
    {
        public static string DecodeSifre(string sifre)
        {
            string decodedSifre = Encoding.UTF8.GetString(Convert.FromBase64String(sifre));
            return decodedSifre;
        }

        public static string EncodeSifre(string sifre)
        {
            string encodedSifre = Convert.ToBase64String(Encoding.UTF8.GetBytes(sifre));
            return encodedSifre;
        }
    }
}
