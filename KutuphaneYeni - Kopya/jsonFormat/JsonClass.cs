using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.IO;
using KutuphaneYeni;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KutuphaneYeni.jsonFormat
{
    public class JsonClass
    {
        private bool rememberMeCheck;

        public string jsonPath { get; private set; }

        public static void JsonSave(string jsonPath, string kullaniciAd, string encodedSifre, string rememberMeCheck)
        {
            jsonModel loginInfo = new jsonModel

            {
                kullaniciAdi = kullaniciAd,
                sifre = encodedSifre,
                rememberMe = rememberMeCheck,
            };

            string json = JsonConvert.SerializeObject(loginInfo); //json cevirme
            File.WriteAllText(jsonPath, json);//yazılanları 
        }
        public static void JsonLoad(string jsonPath, CheckEdit rememberMeCheck, TextEdit kullaniciad, TextEdit sifre)
        {
            try
            {
                if (File.Exists(jsonPath))
                {
                    string json = File.ReadAllText(jsonPath);
                    jsonModel loginInfo = JsonConvert.DeserializeObject<jsonModel>(json);

                    bool rememberMe = Convert.ToBoolean(loginInfo.rememberMe);
                    rememberMeCheck.Checked = rememberMe;

                    if (rememberMe)
                    {
                        kullaniciad.Text = loginInfo.kullaniciAdi;
                        sifre.Text = Sifreleme.DecodeSifre(loginInfo.sifre);
                    }
                    else
                    {
                        File.Delete(jsonPath);
                    }
                }
            }
            catch (Exception ex)
            {
       
            }
        }






    }
}
//**Serialization: Bir nesnenin saklanacak / transfer edilecek forma dönüştürülme işlemidir. Serileşmenin tersi olarak **Deserialization ifadesi kullanılır ve bu da Stream'in (Akış) nesne modeline dönüştürülme işlemidir.