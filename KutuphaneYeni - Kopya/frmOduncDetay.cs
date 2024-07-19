using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYeni
{
    public partial class frmOduncDetay : Form
    {
        public frmOduncDetay(int _id)
        {
            id = _id;
            InitializeComponent();
        }
        int id;
        private void frmOduncDetay_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var item = ApiOdunc.OduncGetir(id);
                kitapAdi.EditValue = item.KitapID;
                kullaniciad.EditValue = item.KullaniciID;
                AlisTEdit.EditValue = item.AlisTarihi;
                dateEdit2.EditValue = item.TeslimTarihi;
                checkEdit1.EditValue = item.TeslimDurumu;

            }
            kitapAdi.Properties.DataSource = ApiKitap.KitapListe();
            kullaniciad.Properties.DataSource = ApiKullanici.KullaniciListe();
        }

        internal void Showdialaog()
        {
            throw new NotImplementedException();
        }
        private async void Btnkaydet_Click(object sender, EventArgs e)
        {
                var att = (DateTime?)AlisTEdit.EditValue;
                var ttt = (DateTime?)dateEdit2.EditValue;
                var tss = (bool?)checkEdit1.EditValue;
                var kk = (int?)(kitapAdi.EditValue);
                var kll = (int?)(kullaniciad.EditValue);
            if (id>0)
            {
                

              await  ApiOdunc.OduncDuzenle(id ,new Entities.EntityOduncKitaplar.EntityOduncK
                {
                    ID=id,
                    AlisTarihi = att,
                    TeslimTarihi = ttt,
                    TeslimDurumu = tss,
                    KitapID = kk,
                    KullaniciID = kll,

                });
            }
            else
            {
               

               await ApiOdunc.OduncEkle(new Entities.EntityOduncKitaplar.EntityOduncK
                {
                    AlisTarihi = att,
                    TeslimTarihi = ttt,
                    TeslimDurumu = tss,
                    KitapID = kk,
                    KullaniciID = kll,


                });
            }
           
            this.Close();
        }

        private void Btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void kitapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //btnKategori.Properties.DataSource = DBKategori.Liste2();

        }

        
    }

}

