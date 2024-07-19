using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneYeni
{
    public partial class XtraReportRapor : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportRapor(int kullaniciid)
        {
            InitializeComponent();
            var data = DBOdunc.RaporListe(kullaniciid);

            if (data == null || data.Count == 0)
            {

                ShowNoDataMessage();


            }
            else
            {

                this.DataSource = data;
            }
        }
        private void ShowNoDataMessage()
        {

            MessageBox.Show("Kullanıcıya ait kitap kaydı bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void PageHeader_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}