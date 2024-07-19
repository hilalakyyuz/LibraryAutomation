using DevExpress.XtraEditors;
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
    public partial class frmKitapDetay : Form
    {
        public frmKitapDetay(int _id)
        {
            id = _id;
            InitializeComponent();
        }
        int id;
        private void frmKitapDetay_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var item = ApiKitap.KitapGetir(id);
                AdtextEdit.Text = item.Ad;
                yayinylyt.Text = item.YayinYili;
                sayfatextEdit.Text = item.SayfaSayisi;
                fyttext.Text = item.Fiyat;
                btnYazar.EditValue = item.YazarID;
                btnKategori.EditValue = item.KategoriID;



            }
            btnKategori.Properties.DataSource = ApiKategori.KategoriListe();
            btnYazar.Properties.DataSource = ApiYazar.YazarListe();
        }

        internal void Showdialaog()
        {
            throw new NotImplementedException();
        }

        private  void Btnkaydet_Click(object sender, EventArgs e)
        {

            if (id > 0)
            {
               ApiKitap.KitapDuzenle(id, new Entities.EntityKitap.EntityKitap
                {
                    ID=id,
                    KategoriID=(int?)btnKategori.EditValue,
                    YazarID=(int?)btnYazar.EditValue,
                    Ad =AdtextEdit.Text,
                    YayinYili=yayinylyt.Text,
                    SayfaSayisi=sayfatextEdit.Text,
                    Fiyat=fyttext.Text,
                });
            }
            else
            {
               ApiKitap.KitapEkle(new Entities.EntityKitap.EntityKitap
                {
                    Ad = AdtextEdit.Text,
                    KategoriID = (int?)btnKategori.EditValue,  
                    YayinYili = yayinylyt.Text,
                    SayfaSayisi = sayfatextEdit.Text,
                    Fiyat = fyttext.Text,
                    YazarID = (int?)btnYazar.EditValue,

                });
                
            }
            this.Close();
        }
        private void Btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}