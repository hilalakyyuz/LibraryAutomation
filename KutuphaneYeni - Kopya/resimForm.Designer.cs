
namespace KutuphaneYeni
{
    partial class resimForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resimForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ekleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // kapatBtn
            // 
            this.kapatBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapatBtn.Appearance.ForeColor = System.Drawing.Color.Red;
            this.kapatBtn.Appearance.Options.UseFont = true;
            this.kapatBtn.Appearance.Options.UseForeColor = true;
            this.kapatBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kapatBtn.ImageOptions.Image")));
            this.kapatBtn.Location = new System.Drawing.Point(108, 427);
            this.kapatBtn.Name = "kapatBtn";
            this.kapatBtn.Size = new System.Drawing.Size(103, 28);
            this.kapatBtn.TabIndex = 8;
            this.kapatBtn.Text = "Kapat";
            this.kapatBtn.Click += new System.EventHandler(this.kapatBtn_Click);
            // 
            // ekleBtn
            // 
            this.ekleBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleBtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ekleBtn.Appearance.Options.UseFont = true;
            this.ekleBtn.Appearance.Options.UseForeColor = true;
            this.ekleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ekleBtn.ImageOptions.Image")));
            this.ekleBtn.Location = new System.Drawing.Point(3, 427);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(99, 28);
            this.ekleBtn.TabIndex = 6;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = null;
            this.galleryControlClient1.Location = new System.Drawing.Point(0, 0);
            this.galleryControlClient1.Size = new System.Drawing.Size(0, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 420);
            this.panel2.TabIndex = 9;
            // 
            // resimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.kapatBtn);
            this.Name = "resimForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "resimForm";
            this.Load += new System.EventHandler(this.resimForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ekleBtn;
        private DevExpress.XtraEditors.SimpleButton kapatBtn;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private System.Windows.Forms.Panel panel2;
    }
}