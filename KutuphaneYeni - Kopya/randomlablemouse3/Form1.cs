using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomlablemouse3
{
    public partial class Form1 : Form
    {
        private Random rastgele = new Random();
        private List<Label> labellar = new List<Label>();
        private Rectangle seciliAlan;
        private Rectangle secimAlani;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Rastgele 10 etiket oluştur
            for (int i = 0; i < 10; i++)
            {
                Label label = new Label();
                label.Text = "Label " + (i + 1);
                label.AutoSize = true;
                label.Location = new Point(rastgele.Next(this.Width), rastgele.Next(this.Height));
                this.Controls.Add(label);
                labellar.Add(label);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Fare tıklandığında seçilen alanı başlat
            secimAlaniBaslat(e.Location);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Fare hareket ettiğinde seçilen alanı güncelle
            if (e.Button == MouseButtons.Left)
            {
                secimAlaniGuncelle(e.Location);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Fare tuşu bırakıldığında seçilen alandaki labellar üzerinde kare aç
            if (e.Button == MouseButtons.Left)
            {
                secimAlaniBitir();
                foreach (Label label in labellar)
                {
                    if (secimAlaniIci(label.Location))
                    {
                        // Seçilen alandaki labellar üzerinde kare aç
                        label.BorderStyle = BorderStyle.FixedSingle;
                    }
                }
            }
        }

        private void secimAlaniBaslat(Point baslangicNoktasi)
        {
            secimAlani = new Rectangle(baslangicNoktasi, Size.Empty);
        }

        private void secimAlaniGuncelle(Point sonNokta)
        {
            secimAlani.X = Math.Min(secimAlani.X, sonNokta.X);
            secimAlani.Y = Math.Min(secimAlani.Y, sonNokta.Y);
            secimAlani.Width = Math.Max(secimAlani.Width, sonNokta.X - secimAlani.X);
            secimAlani.Height = Math.Max(secimAlani.Height, sonNokta.Y - secimAlani.Y);
            this.Invalidate();
        }

        private void secimAlaniBitir()
        {
            secimAlani = Rectangle.Empty;
        }

        private bool secimAlaniIci(Point nokta)
        {
            return secimAlani.Contains(nokta);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Seçilen alanı çiz
            if (!secimAlani.IsEmpty)
            {
                e.Graphics.DrawRectangle(Pens.Black, secimAlani);
            }
        }
    }

}