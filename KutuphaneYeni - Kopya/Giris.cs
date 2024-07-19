using DevExpress.XtraEditors;
using KutuphaneYeni;
using KutuphaneYeni.jsonFormat;
using KutuphaneYeni.XmlIslem;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace KutuphaneYeni
{
    public partial class Giris : Form
    {
        private const string jsonPath = "LoginInfo.json";

        public Giris()
        {
            InitializeComponent();
            JsonClass.JsonLoad(jsonPath, rememberMeCheck, kullaniciad, sifre);

        }
        private void GirisButton1_Click(object sender, EventArgs e)
        {
            GirisIslemler();
        }
        private void GirisIslemler()
        {
            string kullaniciAd = kullaniciad.Text;
            string sifre = this.sifre.Text;
            string rememberCheck = rememberMeCheck.Checked.ToString();
            try
            {
                using (kutuphane_uygEntities1 veritabani = new kutuphane_uygEntities1())
                {
                    string encodedSifre = Sifreleme.EncodeSifre(sifre);

                    Gorevliler personel = veritabani.Gorevliler
                        .Where(g => g.AdSoyad == kullaniciAd && g.Sifre == encodedSifre)
                        .FirstOrDefault();

                    if (!string.IsNullOrEmpty(kullaniciAd) && !string.IsNullOrEmpty(sifre))
                    {
                        if (personel != null)
                        {
                            string decodedSifre = Sifreleme.DecodeSifre(personel.Sifre);

                            if (kullaniciAd == personel.AdSoyad && sifre == decodedSifre)

                            {

                                JsonClass.JsonSave(jsonPath, kullaniciAd, encodedSifre, rememberMeCheck.Checked.ToString());
                                this.Close();

                            }
                            else
                            {
                                XtraMessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Kullanıcı adı veya şifre bulunamadı!");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Kullanıcı adı ve şifre boş olamaz!");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is System.Data.Entity.Core.EntityException)
                {
                    XtraMessageBox.Show("Veritabanı bağlantısı hatası!");
                }
                else
                {
                    XtraMessageBox.Show("Bir hata oluştu: " + ex.GetBaseException().Message);
                }
            }
        }
        private void CıkısBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
