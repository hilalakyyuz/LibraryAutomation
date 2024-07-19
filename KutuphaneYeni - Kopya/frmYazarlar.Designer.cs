
namespace KutuphaneYeni
{
    partial class frmYazarlar
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ButtonCıkıs = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSil = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gwListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDogumTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUlke = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ButtonCıkıs);
            this.layoutControl1.Controls.Add(this.ButtonSil);
            this.layoutControl1.Controls.Add(this.ButtonDuzenle);
            this.layoutControl1.Controls.Add(this.ButtonEkle);
            this.layoutControl1.Controls.Add(this.gcList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(899, 557);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ButtonCıkıs
            // 
            this.ButtonCıkıs.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonCıkıs.Appearance.ForeColor = System.Drawing.Color.Red;
            this.ButtonCıkıs.Appearance.Options.UseFont = true;
            this.ButtonCıkıs.Appearance.Options.UseForeColor = true;
            this.ButtonCıkıs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCıkıs.Location = new System.Drawing.Point(715, 515);
            this.ButtonCıkıs.Name = "ButtonCıkıs";
            this.ButtonCıkıs.Size = new System.Drawing.Size(172, 30);
            this.ButtonCıkıs.StyleController = this.layoutControl1;
            this.ButtonCıkıs.TabIndex = 5;
            this.ButtonCıkıs.Text = "ÇIKIŞ YAP";
            this.ButtonCıkıs.Click += new System.EventHandler(this.ButtonCıkıs_Click);
            // 
            // ButtonSil
            // 
            this.ButtonSil.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonSil.Appearance.ForeColor = System.Drawing.Color.Red;
            this.ButtonSil.Appearance.Options.UseFont = true;
            this.ButtonSil.Appearance.Options.UseForeColor = true;
            this.ButtonSil.Location = new System.Drawing.Point(188, 515);
            this.ButtonSil.Name = "ButtonSil";
            this.ButtonSil.Size = new System.Drawing.Size(172, 30);
            this.ButtonSil.StyleController = this.layoutControl1;
            this.ButtonSil.TabIndex = 3;
            this.ButtonSil.Text = "SİL";
            this.ButtonSil.Click += new System.EventHandler(this.ButtonSil_Click);
            // 
            // ButtonDuzenle
            // 
            this.ButtonDuzenle.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonDuzenle.Appearance.ForeColor = System.Drawing.Color.Red;
            this.ButtonDuzenle.Appearance.Options.UseFont = true;
            this.ButtonDuzenle.Appearance.Options.UseForeColor = true;
            this.ButtonDuzenle.Location = new System.Drawing.Point(364, 515);
            this.ButtonDuzenle.Name = "ButtonDuzenle";
            this.ButtonDuzenle.Size = new System.Drawing.Size(172, 30);
            this.ButtonDuzenle.StyleController = this.layoutControl1;
            this.ButtonDuzenle.TabIndex = 4;
            this.ButtonDuzenle.Text = "DÜZENLE";
            this.ButtonDuzenle.Click += new System.EventHandler(this.ButtonDuzenle_Click);
            // 
            // ButtonEkle
            // 
            this.ButtonEkle.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonEkle.Appearance.ForeColor = System.Drawing.Color.Red;
            this.ButtonEkle.Appearance.Options.UseFont = true;
            this.ButtonEkle.Appearance.Options.UseForeColor = true;
            this.ButtonEkle.Location = new System.Drawing.Point(12, 515);
            this.ButtonEkle.Name = "ButtonEkle";
            this.ButtonEkle.Size = new System.Drawing.Size(172, 30);
            this.ButtonEkle.StyleController = this.layoutControl1;
            this.ButtonEkle.TabIndex = 2;
            this.ButtonEkle.Text = "EKLE";
            this.ButtonEkle.Click += new System.EventHandler(this.ButtonEkle_Click);
            // 
            // gcList
            // 
            this.gcList.Location = new System.Drawing.Point(12, 12);
            this.gcList.MainView = this.gwListe;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(875, 499);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwListe});
            // 
            // gwListe
            // 
            this.gwListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAd,
            this.colSoyad,
            this.colDogumTarihi,
            this.colUlke});
            this.gwListe.GridControl = this.gcList;
            this.gwListe.Name = "gwListe";
            this.gwListe.OptionsBehavior.Editable = false;
            this.gwListe.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.MinWidth = 25;
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 1;
            this.colAd.Width = 94;
            // 
            // colSoyad
            // 
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.MinWidth = 25;
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.Visible = true;
            this.colSoyad.VisibleIndex = 2;
            this.colSoyad.Width = 94;
            // 
            // colDogumTarihi
            // 
            this.colDogumTarihi.Caption = "Doğum Tarihi";
            this.colDogumTarihi.FieldName = "DogumTarihi";
            this.colDogumTarihi.MinWidth = 25;
            this.colDogumTarihi.Name = "colDogumTarihi";
            this.colDogumTarihi.Visible = true;
            this.colDogumTarihi.VisibleIndex = 3;
            this.colDogumTarihi.Width = 94;
            // 
            // colUlke
            // 
            this.colUlke.Caption = "Ülke";
            this.colUlke.FieldName = "Ulke";
            this.colUlke.MinWidth = 25;
            this.colUlke.Name = "colUlke";
            this.colUlke.Visible = true;
            this.colUlke.VisibleIndex = 4;
            this.colUlke.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(899, 557);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(879, 503);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ButtonEkle;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 503);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(176, 34);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ButtonDuzenle;
            this.layoutControlItem3.Location = new System.Drawing.Point(352, 503);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(176, 34);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ButtonSil;
            this.layoutControlItem4.Location = new System.Drawing.Point(176, 503);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(176, 34);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ButtonCıkıs;
            this.layoutControlItem5.Location = new System.Drawing.Point(703, 503);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(176, 34);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(528, 503);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(175, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmYazarlar
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCıkıs;
            this.ClientSize = new System.Drawing.Size(899, 557);
            this.Controls.Add(this.layoutControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmYazarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazarlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmYazarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton ButtonCıkıs;
        private DevExpress.XtraEditors.SimpleButton ButtonSil;
        private DevExpress.XtraEditors.SimpleButton ButtonDuzenle;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gwListe;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colDogumTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colUlke;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton ButtonEkle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}