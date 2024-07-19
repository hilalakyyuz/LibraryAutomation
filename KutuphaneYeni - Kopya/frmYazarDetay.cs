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
    public partial class frmYazarDetay : Form
    {
        public frmYazarDetay(int _id)
        {
            id =_id;
            InitializeComponent();
        }
        int id;
        private void frmYazarDetay_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var item = ApiYazar.YazarGetir(id);

                AdtextEdit.Text = item.Ad;
                SoyadtextEdit.Text = item.Soyad;
                dateEdit1.EditValue = item.DogumTarihi;
                ulketextEdit.Text = item.Ulke;


            }


        }
        private  void Btnkaydet_Click(object sender, EventArgs e)
        {
            if (id>0)
            {
                var _dt = (DateTime?)dateEdit1.EditValue;
                ApiYazar.YazarDuzenle(id,new Entities.EntityYazar.EntityYazar
                {
                    ID = id,
                    Ad = AdtextEdit.Text,
                    Soyad = SoyadtextEdit.Text,
                    DogumTarihi = _dt,
                    Ulke = ulketextEdit.Text,




                }); 

            }
            else
            {
                var _dt = (DateTime?)dateEdit1.EditValue;
                 ApiYazar.YazarEkle(new Entities.EntityYazar.EntityYazar
                { 
                     Ad = AdtextEdit.Text,
                    Soyad = SoyadtextEdit.Text,
                    DogumTarihi = _dt,
                    Ulke = ulketextEdit.Text,




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