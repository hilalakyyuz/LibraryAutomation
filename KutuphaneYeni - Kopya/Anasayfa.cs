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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        private void ButtonKlnaci_Click(object sender, EventArgs e)
        {
            frmKullanicilar frm = new frmKullanicilar();
            frm.Show();
         
            
        }

        private void ButtonKtp_Click(object sender, EventArgs e)
        {
            frmKitaplar frm = new frmKitaplar();
            frm.Show();

        }

        private void ButtonYzr_Click(object sender, EventArgs e)
        {
            frmYazarlar frm = new frmYazarlar();
            frm.Show();
        }

        private void ButtonKtgr_Click(object sender, EventArgs e)
        {
            frmKategoriler frm = new frmKategoriler();
            frm.Show();
           
        }

        private void ButtonOdnc_Click(object sender, EventArgs e)
        {
             frmOdunc frm = new frmOdunc();
             frm.Show();

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Giris frm = new Giris();
            frm.ShowDialog();
           
        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

     

      
    }
}
