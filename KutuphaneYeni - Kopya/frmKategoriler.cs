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
    public partial class frmKategoriler : Form
    {
        public frmKategoriler()
        {
            InitializeComponent();
        }
        private void frmKategriler_Load(object sender, EventArgs e)
        {
            ListeYukle();
        }
        private void frmKategoriler_Load(object sender, EventArgs e)
        {
            
            gclist.DataSource = ApiKategori.KategoriListe();
        }


        private void ButtonEkleClick(object sender, EventArgs e)
        {

            using (frmKategoriDetay frm = new frmKategoriDetay(0))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ListeYukle();
                }
            }
        }

        private void ButtonSil_Click_1(object sender, EventArgs e)
        {
            var id = gridView1.GetFocusedRowCellValue("ID");
            if (XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ApiKategori.KategoriSil((int)id);
                ListeYukle();
            }
            else { return; }
        }
        private void ButtonDuzenle_Click(object sender, EventArgs e)
        {
            var id = gridView1.GetFocusedRowCellValue("ID");
            frmKategoriDetay frm = new frmKategoriDetay((int)id);
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
            ListeYukle();
        }

        private void ButtonCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ListeYukle()
        {
            gclist.DataSource = ApiKategori.KategoriListe();
        }

       
    }


}
















