using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        public frmKullanicilar()
        {
            InitializeComponent();
        }
        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            ListeYukle();

            gcList.DataSource = ApiKullanici.KullaniciListe();
        }
        private void ListeYukle()
        {

            gcList.DataSource = ApiKullanici.KullaniciListe();
        }
        private void ButtonEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciDetay frm = new frmKullaniciDetay(0);
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
            ListeYukle();
        }

        private  void ButtonSil_Click(object sender, EventArgs e)
        {
            var id = gwlist.GetFocusedRowCellValue("ID");
            if (XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
         ApiKullanici.KullaniciSil((int)id);
                ListeYukle();
            }
            else { return; }
        }
        private void ButtonDuzenle_Click(object sender, EventArgs e)
        {

            var id = gwlist.GetFocusedRowCellValue("ID");
            frmKullaniciDetay frm = new frmKullaniciDetay((int)id);
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
            ListeYukle();
        }

        private void ButtonCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void RaporBtn_Click(object sender, EventArgs e)
        {
            int id = (int)gwlist.GetFocusedRowCellValue("ID");

            var data = ApiOdunc.RaporListeAsync(id);
            if (data == null )
            {
                MessageBox.Show("Kullanıcıya ait kitap kaydı bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                XtraReportRapor report = new XtraReportRapor(id);

                report.ShowPreviewDialog();
            }


        }
    }
}
