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
    public partial class Anasayfa2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Anasayfa2()
        {
            InitializeComponent();
        }
        private void kullaniciBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKullanicilar frm = new frmKullanicilar();
            frm.MdiParent = this; 
            frm.Show();
        }

        private void kitapBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKitaplar frm = new frmKitaplar();
            frm.MdiParent = this; 
            frm.Show();
        }

        private void yazarBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYazarlar frm = new frmYazarlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kategoriBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKategoriler frm = new frmKategoriler();
            frm.MdiParent = this; 
            frm.Show();
        }

        private void oduncBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOdunc frm = new frmOdunc();
            frm.MdiParent = this; 
            frm.Show();
        }
        private void kullaniciBtn2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKullanicilar frm = new frmKullanicilar();
            frm.MdiParent = this;
            frm.Show();

        }
        private void kitapBtn2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKitaplar frm = new frmKitaplar();
            frm.MdiParent = this;
            frm.Show();
        }
        private void yazarBtn2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYazarlar frm = new frmYazarlar();
            frm.MdiParent = this;
            frm.Show();

        }
        private void kategoriBtn2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKategoriler frm = new frmKategoriler();
            frm.MdiParent = this;
            frm.Show();
        }
        private void oduncBtn2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOdunc frm = new frmOdunc();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Anasayfa2_Load(object sender, EventArgs e)
        {
            
            Giris frm = new Giris();
            frm.ShowDialog();
        }
        private void Anasayfa2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void resimBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider frm = new imageSlider();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
