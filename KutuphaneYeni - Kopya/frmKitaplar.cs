using DevExpress.XtraBars;
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
    public partial class frmKitaplar : Form
    {
        public frmKitaplar()
        {
            InitializeComponent();
        }
   
        private void frmKitaplar_Load(object sender, EventArgs e)
        {
            
            entityKitapBindingSource.DataSource = ApiKitap.KitapListe();

            repoKategori.Columns.Clear(); 
            repoKategori.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Adi", "Kategori Adı")});

            repoYazar.Columns.Clear();
            repoYazar.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ad", "Yazar Adı")});

           

            repoKategori.DataSource = ApiKategori.KategoriListe();
            repoYazar.DataSource = ApiYazar.YazarListe();




        }
        private void ButtonEkle_Click(object sender, EventArgs e)
        {
            frmKitapDetay frm = new frmKitapDetay(0);
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
            ListeYukle(); ;
        }
        private void ButtonDuzenle_Click(object sender, EventArgs e)
        {
            var id = gridView1.GetFocusedRowCellValue("ID");
            frmKitapDetay frm = new frmKitapDetay((int)id);
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
            ListeYukle();
        }

        private  void ButtonSil_Click(object sender, EventArgs e)
        {
            var id = gridView1.GetFocusedRowCellValue("ID");
            if (XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                ApiKitap.KitapSil((int)id);
                ListeYukle();
            }
            else { return; }
          


        }
        private void ButtonCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeYukle()
        {
            gclist.DataSource = ApiKitap.KitapListe();

        }
        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = gridView1.GetFocusedRowCellValue("ID");
                XtraMessageBox.Show("Siliniyor ...");
                if (id != null || (int)id > 0)
                {
                    var sonuc =ApiKitap.KitapSil((int)id);
                    if (sonuc == true)
                    {
                        gridView1.DeleteSelectedRows();
                    }


                }


            }
        }

     
    }
}