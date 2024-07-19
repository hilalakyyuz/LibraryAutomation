using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using KutuphaneYeni.Entities.EntityKitap;
using KutuphaneYeni.Entities.EntityOduncKitaplar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYeni
{
    public partial class frmOdunc : Form
    {

        public frmOdunc()
        {
            InitializeComponent();

        }
        List<EntityKitap> kitapListe = new List<EntityKitap>();
        private void frmOdunc_Load(object sender, EventArgs e)
        {
            entityOduncKBindingSource.DataSource = ApiOdunc.OduncListe();
            KayitYukleYazar();
            KayitYukleKitap();
            KayitYukleKullanici();

        }
        void KayitYukleYazar()
        {
            var _liste =ApiYazar.YazarListe().Select(x => new
            {
                YazarID = x.ID,
                YazarAd = x.Ad,

            });
            repYazar.DataSource = _liste;
        }
        void KayitYukleKullanici()
        {

            var _list =ApiKullanici.KullaniciListe().Select(x => new
            {
                KullaniciID = x.ID,
                AdSoyad = x.AdSoyad

            });
            repKullanici.DataSource = _list;
        }
        void KayitYukleKitap()
        {

            kitapListe =ApiKitap.KitapListe();
            rcpoKitap.DataSource = kitapListe;
        }
        private void ButtonEkle_Click(object sender, EventArgs e)
        {
            frmOduncDetay frm = new frmOduncDetay(0);
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
            ListeYukle();

        }

        private async void ButtonSil_Click(object sender, EventArgs e)
        {
            var id = gridView1.GetFocusedRowCellValue("ID");
            if (XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
              
                await ApiOdunc.OduncSil((int)id);
                ListeYukle();
            }
            else
            {
                return;


            }
        }
        private void ButtonDuzenle_Click(object sender, EventArgs e)
        {
            var id = gridView1.GetFocusedRowCellValue("ID");
            frmOduncDetay frm = new frmOduncDetay((int)id);
            frm.ShowDialog();
            this.DialogResult = DialogResult.OK;
            ListeYukle();

        }
        private void ButtonCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private  void ListeYukle()
        {
            gcliste.DataSource =  ApiOdunc.OduncListe();
        }

        private async void repDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = gridView1.GetFocusedRowCellValue("ID");
                XtraMessageBox.Show("Siliniyor ...");
                if ((int)id > 0)
                {
                    var sonuc = await ApiOdunc.OduncSil((int)id);
                    if (sonuc == true)
                    {
                        gridView1.DeleteSelectedRows();
                    }

                }
                else
                {
                    gridView1.DeleteSelectedRows();

                }
            }
        }
        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, "AlisTarihi", DateTime.Now.Date);
            view.SetRowCellValue(e.RowHandle, "TeslimTarihi", DateTime.Now.Date);
        }
        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn colKitap = view.Columns["KitapID"];
            GridColumn colKullanici = view.Columns["KullaniciID"];

            int kitap = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, colKitap));
            int kullanici = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, colKullanici));
            if (kitap == 0)
            {
                view.SetColumnError(colKitap, "Kitap seçiniz.");

                view.SetColumnError(null, "Invalid data");
                e.Valid = false;
                e.ErrorText = "'Units On Order' and 'Units In Stock' values are not consistent.";
            }
        }
        private async void KaydetButton_Click(object sender, EventArgs e)
        {
            var data = (List<EntityOduncK>)entityOduncKBindingSource.DataSource;
            var sonuc = await ApiOdunc.OduncKaydet(data);
            if (sonuc)
            {
                ListeYukle();
            }
        }


        private List<EntityKitap> clone = null;
        private void gvDetay_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "KitapID" && view.ActiveEditor is LookUpEdit)
            {
                int yazarid = 0;
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "YazarID") != null)
                {
                    yazarid = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "YazarID");
                    clone = kitapListe.Where(a => a.YazarID == yazarid).OrderBy(a => a.Adi).ToList();
                }
                else
                {
                    clone = new List<EntityKitap>();
                }
                LookUpEdit edit = (LookUpEdit)view.ActiveEditor;
                edit.Properties.DataSource = clone;
            }
        }
        private void gvDetay_HiddenEditor(object sender, EventArgs e)
        {
            if (clone != null)
            {
                clone = null;
            }
        }

        private void repYazar_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.SetFocusedRowCellValue("KitapID", null);
        }

        private void FisYazdir_Click(object sender, EventArgs e)
        {

            int id = (int)gridView1.GetFocusedRowCellValue("ID");
            var entity = ApiOdunc.OduncGetir2(id);

            XtraReport1 report = new XtraReport1();



            report.Parameters["AlisTarihi"].Value = entity.AlisTarihi;
            report.Parameters["AdSoyad"].Value = entity.KullaniciAdi;
            report.Parameters["Ad"].Value = entity.KitapAdi;
            report.Parameters["SayfaSayisi"].Value = entity.SayfaSayisi;
            report.Parameters["Fiyat"].Value = entity.Fiyat;
            report.Parameters["ID"].Value = entity.ID;
            report.Parameters["KayitYapan"].Value = entity.KayitYapan;
            report.Parameters["YazarAdi"].Value = entity.YazarAdi;
            report.RequestParameters = false;
            report.ShowPreviewDialog();

        }



    }
}







