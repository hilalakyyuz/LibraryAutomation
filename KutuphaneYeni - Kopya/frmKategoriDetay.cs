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
    public partial class frmKategoriDetay : Form
    {


        public frmKategoriDetay(int _id)
        {
            id = _id;
            InitializeComponent();
        }
        int id;
        private void frmKategoriDetay_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var item = ApiKategori.KategoriGetir(id);
                AdtextEdit.Text = item.Adi;
            }

        }
         private void Btnkaydet_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                 ApiKategori.KategoriDuzenle(id,new Entities.EntityKategoriler.EntityKategoriler
                {
                    Adi = AdtextEdit.Text,
                    ID = id,
                });
            }
            else
            {
                 ApiKategori.KategoriEkle(new Entities.EntityKategoriler.EntityKategoriler
                {
                    Adi = AdtextEdit.Text,


                });
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btniptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
