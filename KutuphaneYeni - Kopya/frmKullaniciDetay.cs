using DevExpress.XtraEditors;
using KutuphaneYeni.İmage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneYeni
{
    public partial class frmKullaniciDetay : Form
    {
        private int id;
        private byte[] varsayilanResimBytes;

        public frmKullaniciDetay(int _id)
        {
            id = _id;
            InitializeComponent();
        }

        
        private  void frmKullaniciDetay_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var item = ApiKullanici.KullaniciGetir(id);
                var resTask = ApiResim.GetVarsayilanResim(id); 

                if (item != null)
                {
                    AdtextEdit.Text = item.AdSoyad;
                    EmailtextEdit.Text = item.Email;

                   
                    var res = resTask; 

                    if (res != null && res.Resim.Length > 0)
                    {
                        pictureEdit1.Image = imgClass.ByteArrayToImage(res.Resim);
                    }
                    else
                    {
                       
                    }
                }
            }
        }

        private  void Btnkaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AdtextEdit.Text))
            {
                XtraMessageBox.Show("Ad giriniz");
                return;
            }
            if (string.IsNullOrEmpty(EmailtextEdit.Text))
            {
                XtraMessageBox.Show("Email giriniz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (id > 0)
            {
                 ApiKullanici.KullaniciDuzenle(id, new Entities.EntityKullanici.EntityKullanici
                {
                    ID = id,
                    AdSoyad = AdtextEdit.Text,
                    Email = EmailtextEdit.Text,
                    //Resim = resimBytes
                });
            }
            else
            {
              ApiKullanici.KullaniciEkle(new Entities.EntityKullanici.EntityKullanici
                {

                    AdSoyad = AdtextEdit.Text,
                    Email = EmailtextEdit.Text,
                    //Resim = resimBytes
                });

            }

            this.Close();
        }
        private void Btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void imgButton_Click_1(object sender, EventArgs e)
        {
            using (resimForm frm = new resimForm(id))
            {
                frm.ShowDialog();
                }
            }
        }
    }
    
