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
    public partial class frmYazarlar : Form
    {
        public frmYazarlar()
        {
            InitializeComponent();
        }
        private void frmyazarlar_Load(object sender, EventArgs e)
        {
            ListeYukle();
        }
        private void frmYazarlar_Load(object sender, EventArgs e)
        {
            
            gcList.DataSource = ApiYazar.YazarListe();
        }

        private void ButtonEkle_Click(object sender, EventArgs e)
        {
            frmYazarDetay frm = new frmYazarDetay(0);
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
            ListeYukle();
        }

        private  void ButtonSil_Click(object sender, EventArgs e)
        {

            var id = gwListe.GetFocusedRowCellValue("ID");
            if (XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
               ApiYazar.YazarSil((int)id);
                ListeYukle();
            }
            else { return; }

        }

        private void ButtonDuzenle_Click(object sender, EventArgs e)
        {
            var id = gwListe.GetFocusedRowCellValue("ID");
            frmYazarDetay frm = new frmYazarDetay((int)id);
            frm.ShowDialog();
            ListeYukle();
        }

        private void ButtonCıkıs_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void ListeYukle()
        {
            
            gcList.DataSource = ApiYazar.YazarListe();
        }
    }
}
