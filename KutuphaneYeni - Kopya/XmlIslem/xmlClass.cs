using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KutuphaneYeni.XmlIslem
{

  public  class XmlClass
    {
       
        public static void SaveRememberMeSettings(string xmlFileName, string kullaniciad, string sifre, string benihatirla)
        {
            using (XmlWriter writer = XmlWriter.Create(xmlFileName))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("giris");

                writer.WriteStartElement("kullanici");
                writer.WriteValue(kullaniciad);
                writer.WriteEndElement();

                writer.WriteStartElement("sifre");
                writer.WriteValue(sifre);
                writer.WriteEndElement();

                writer.WriteStartElement("rememberMe");
                writer.WriteValue(benihatirla);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}



//using DevExpress.XtraEditors;
//using KutuphaneYeni.Helper;
//using KutuphaneYeni.XmlIslem;
//using System;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using System.Xml;

//namespace KutuphaneYeni
//{
//    public partial class Giris : Form
//    {
//        private const string xmlFileName = "giris.xml";

//        public Giris()
//        {
//            InitializeComponent();
//            LoadRememberMeSettings();
//        }


//        private void GirisButton1_Click(object sender, EventArgs e)
//        {
//            string kullaniciAd = kullaniciad.Text;
//            string sifre = this.sifre.Text;

//            try
//            {
//                using (kutuphane_uygEntities veritabani = new kutuphane_uygEntities())
//                {
//                    string encodedSifre = Sifreleme.EncodeSifre(sifre);

//                    Gorevliler personel = veritabani.Gorevliler
//                        .Where(g => g.AdSoyad == kullaniciAd && g.Sifre == encodedSifre)
//                        .FirstOrDefault();

//                    if (!string.IsNullOrEmpty(kullaniciAd) && !string.IsNullOrEmpty(sifre))
//                    {
//                        if (personel != null)
//                        {
//                            string decodedSifre = Sifreleme.DecodeSifre(personel.Sifre);

//                            if (kullaniciAd == personel.AdSoyad && sifre == decodedSifre)
//                            {
//                                XmlClass.SaveRememberMeSettings(xmlFileName, kullaniciAd, Sifreleme.EncodeSifre(sifre), rememberMeCheck.Checked.ToString());
//                                this.Close();

//                            }
//                            else
//                            {
//                                XtraMessageBox.Show("Kullanıcı adı veya şifre hatalı!");
//                            }
//                        }
//                        else
//                        {
//                            XtraMessageBox.Show("Kullanıcı adı veya şifre bulunamadı!");
//                        }
//                    }
//                    else
//                    {
//                        XtraMessageBox.Show("Kullanıcı adı ve şifre boş olamaz!");
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                if (ex is System.Data.Entity.Core.EntityException)
//                {
//                    XtraMessageBox.Show("Veritabanı bağlantısı hatası!");
//                }
//                else
//                {
//                    XtraMessageBox.Show("Bir hata oluştu: " + ex.GetBaseException().Message);
//                }
//            }
//        }
//        public void LoadRememberMeSettings()
//        {
//            try
//            {
//                if (System.IO.File.Exists(xmlFileName))
//                {
//                    XmlDocument xmlDoc = new XmlDocument();
//                    xmlDoc.Load(xmlFileName);

//                    XmlNode rememberMeNode = xmlDoc.SelectSingleNode("/giris/rememberMe");
//                    bool rememberMe = bool.Parse(rememberMeNode.InnerText);

//                    rememberMeCheck.Checked = rememberMe;

//                    if (rememberMe)
//                    {
//                        XmlNode kullaniciNode = xmlDoc.SelectSingleNode("/giris/kullanici");
//                        XmlNode sifreNode = xmlDoc.SelectSingleNode("/giris/sifre");

//                        kullaniciad.Text = kullaniciNode.InnerText;
//                        sifre.Text = Sifreleme.DecodeSifre(sifreNode.InnerText);
//                    }
//                    else
//                    {
//                        System.IO.File.Delete(xmlFileName);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {

//            }
//        }
//        private void simpleButton2_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }


//    }
//}
