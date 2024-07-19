
namespace KutuphaneYeni
{
    partial class frmKitapDetay
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.Columns.GridColumn colID;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapDetay));
            this.sayfatextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnYazar = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.yazarlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnKategori = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.entityKitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fyttext = new DevExpress.XtraEditors.TextEdit();
            this.Btniptal = new DevExpress.XtraEditors.SimpleButton();
            this.Btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.yayinylyt = new DevExpress.XtraEditors.TextEdit();
            this.AdtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.adlyt = new DevExpress.XtraLayout.LayoutControlItem();
            this.Soyadlyt = new DevExpress.XtraLayout.LayoutControlItem();
            this.c = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sayfatextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnYazar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityKitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fyttext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayinylyt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adlyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soyadlyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // colID
            // 
            colID.FieldName = "ID";
            colID.Name = "colID";
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 122;
            // 
            // sayfatextEdit
            // 
            this.sayfatextEdit.Location = new System.Drawing.Point(97, 116);
            this.sayfatextEdit.Name = "sayfatextEdit";
            this.sayfatextEdit.Size = new System.Drawing.Size(315, 22);
            this.sayfatextEdit.StyleController = this.layoutControl1;
            this.sayfatextEdit.TabIndex = 11;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.layoutControl1.Controls.Add(this.btnYazar);
            this.layoutControl1.Controls.Add(this.btnKategori);
            this.layoutControl1.Controls.Add(this.fyttext);
            this.layoutControl1.Controls.Add(this.Btniptal);
            this.layoutControl1.Controls.Add(this.Btnkaydet);
            this.layoutControl1.Controls.Add(this.yayinylyt);
            this.layoutControl1.Controls.Add(this.AdtextEdit);
            this.layoutControl1.Controls.Add(this.sayfatextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem7});
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(424, 311);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnYazar
            // 
            this.btnYazar.Location = new System.Drawing.Point(97, 64);
            this.btnYazar.Name = "btnYazar";
            this.btnYazar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.btnYazar.Properties.DataSource = this.yazarlarBindingSource;
            this.btnYazar.Properties.DisplayMember = "Ad";
            this.btnYazar.Properties.NullText = "";
            this.btnYazar.Properties.PopupView = this.gridView1;
            this.btnYazar.Properties.ValueMember = "ID";
            this.btnYazar.Size = new System.Drawing.Size(315, 22);
            this.btnYazar.StyleController = this.layoutControl1;
            this.btnYazar.TabIndex = 20;
            // 
            // yazarlarBindingSource
            // 
            this.yazarlarBindingSource.DataSource = typeof(KutuphaneYeni.Yazarlar);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAd,
            this.colSoyad});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 0;
            // 
            // colSoyad
            // 
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.Visible = true;
            this.colSoyad.VisibleIndex = 1;
            // 
            // btnKategori
            // 
            this.btnKategori.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.btnKategori.Location = new System.Drawing.Point(97, 38);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.btnKategori.Properties.DataSource = this.entityKitapBindingSource;
            this.btnKategori.Properties.DisplayMember = "Adi";
            this.btnKategori.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.btnKategori.Properties.NullText = "";
            this.btnKategori.Properties.PopupView = this.searchLookUpEdit1View;
            this.btnKategori.Properties.ValueMember = "ID";
            this.btnKategori.ShowToolTips = false;
            this.btnKategori.Size = new System.Drawing.Size(315, 22);
            this.btnKategori.StyleController = this.layoutControl1;
            this.btnKategori.TabIndex = 19;
            // 
            // entityKitapBindingSource
            // 
            this.entityKitapBindingSource.DataSource = typeof(KutuphaneYeni.Entities.EntityKitap.EntityKitap);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            colID,
            this.colAdi});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colAdi
            // 
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 1;
            this.colAdi.Width = 933;
            // 
            // fyttext
            // 
            this.fyttext.Location = new System.Drawing.Point(97, 142);
            this.fyttext.Name = "fyttext";
            this.fyttext.Size = new System.Drawing.Size(315, 22);
            this.fyttext.StyleController = this.layoutControl1;
            this.fyttext.TabIndex = 18;
            // 
            // Btniptal
            // 
            this.Btniptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btniptal.ImageOptions.Image")));
            this.Btniptal.Location = new System.Drawing.Point(213, 261);
            this.Btniptal.Name = "Btniptal";
            this.Btniptal.Size = new System.Drawing.Size(199, 38);
            this.Btniptal.StyleController = this.layoutControl1;
            this.Btniptal.TabIndex = 16;
            this.Btniptal.Text = "İPTAL";
            this.Btniptal.Click += new System.EventHandler(this.Btniptal_Click);
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnkaydet.ImageOptions.Image")));
            this.Btnkaydet.Location = new System.Drawing.Point(12, 261);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(197, 38);
            this.Btnkaydet.StyleController = this.layoutControl1;
            this.Btnkaydet.TabIndex = 15;
            this.Btnkaydet.Text = "KAYDET";
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // yayinylyt
            // 
            this.yayinylyt.Location = new System.Drawing.Point(97, 90);
            this.yayinylyt.Name = "yayinylyt";
            this.yayinylyt.Size = new System.Drawing.Size(315, 22);
            this.yayinylyt.StyleController = this.layoutControl1;
            this.yayinylyt.TabIndex = 13;
            // 
            // AdtextEdit
            // 
            this.AdtextEdit.Location = new System.Drawing.Point(97, 12);
            this.AdtextEdit.Name = "AdtextEdit";
            this.AdtextEdit.Size = new System.Drawing.Size(315, 22);
            this.AdtextEdit.StyleController = this.layoutControl1;
            this.AdtextEdit.TabIndex = 12;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Location = new System.Drawing.Point(556, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(224, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(149, 399);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.adlyt,
            this.Soyadlyt,
            this.c,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(424, 311);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 156);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(404, 93);
            this.emptySpaceItem1.Text = "DOĞUM TARİHİ";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // adlyt
            // 
            this.adlyt.Control = this.AdtextEdit;
            this.adlyt.Location = new System.Drawing.Point(0, 0);
            this.adlyt.Name = "adlyt";
            this.adlyt.Size = new System.Drawing.Size(404, 26);
            this.adlyt.Text = "AD";
            this.adlyt.TextSize = new System.Drawing.Size(82, 16);
            // 
            // Soyadlyt
            // 
            this.Soyadlyt.Control = this.yayinylyt;
            this.Soyadlyt.Location = new System.Drawing.Point(0, 78);
            this.Soyadlyt.Name = "Soyadlyt";
            this.Soyadlyt.Size = new System.Drawing.Size(404, 26);
            this.Soyadlyt.Text = "YAYIN YILI";
            this.Soyadlyt.TextSize = new System.Drawing.Size(82, 16);
            // 
            // c
            // 
            this.c.Control = this.sayfatextEdit;
            this.c.Location = new System.Drawing.Point(0, 104);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(404, 26);
            this.c.Text = "SAYFA SAYISI";
            this.c.TextSize = new System.Drawing.Size(82, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Btnkaydet;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 249);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(201, 42);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Btniptal;
            this.layoutControlItem3.Location = new System.Drawing.Point(201, 249);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(203, 42);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.fyttext;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(404, 26);
            this.layoutControlItem5.Text = "FİYAT";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(82, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnKategori;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(404, 26);
            this.layoutControlItem4.Text = "KATEGORİ";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(82, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnYazar;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(404, 26);
            this.layoutControlItem6.Text = "YAZAR ADI";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(82, 16);
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataSource = typeof(KutuphaneYeni.Kitaplar);
            // 
            // frmKitapDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(424, 311);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmKitapDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Detay";
            this.Load += new System.EventHandler(this.frmKitapDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sayfatextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnYazar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityKitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fyttext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayinylyt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adlyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soyadlyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit sayfatextEdit;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit yayinylyt;
        private DevExpress.XtraEditors.TextEdit AdtextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem adlyt;
        private DevExpress.XtraLayout.LayoutControlItem Soyadlyt;
        private DevExpress.XtraLayout.LayoutControlItem c;
        private DevExpress.XtraEditors.SimpleButton Btniptal;
        private DevExpress.XtraEditors.SimpleButton Btnkaydet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit fyttext;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SearchLookUpEdit btnKategori;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit btnYazar;
        private System.Windows.Forms.BindingSource yazarlarBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private System.Windows.Forms.BindingSource entityKitapBindingSource;
    }
}