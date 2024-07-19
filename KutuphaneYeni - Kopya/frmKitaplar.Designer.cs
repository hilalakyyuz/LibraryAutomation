
namespace KutuphaneYeni
{
    partial class frmKitaplar
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ButtonCıkıs = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSil = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gclist = new DevExpress.XtraGrid.GridControl();
            this.entityKitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYayinYili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSayfaSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitYapan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegisiklikYapan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegisiklikTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colKategoriID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoKategori = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.entityKategorilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookupYazar = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.entityYazarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYazarID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoYazar = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityKitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityKategorilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookupYazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityYazarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoYazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ButtonCıkıs);
            this.layoutControl1.Controls.Add(this.ButtonSil);
            this.layoutControl1.Controls.Add(this.ButtonDuzenle);
            this.layoutControl1.Controls.Add(this.ButtonEkle);
            this.layoutControl1.Controls.Add(this.gclist);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(793, 436);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ButtonCıkıs
            // 
            this.ButtonCıkıs.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonCıkıs.Appearance.ForeColor = System.Drawing.Color.Red;
            this.ButtonCıkıs.Appearance.Options.UseFont = true;
            this.ButtonCıkıs.Appearance.Options.UseForeColor = true;
            this.ButtonCıkıs.Location = new System.Drawing.Point(582, 394);
            this.ButtonCıkıs.Name = "ButtonCıkıs";
            this.ButtonCıkıs.Size = new System.Drawing.Size(199, 30);
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
            this.ButtonSil.Location = new System.Drawing.Point(139, 394);
            this.ButtonSil.Name = "ButtonSil";
            this.ButtonSil.Size = new System.Drawing.Size(122, 30);
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
            this.ButtonDuzenle.Location = new System.Drawing.Point(265, 394);
            this.ButtonDuzenle.Name = "ButtonDuzenle";
            this.ButtonDuzenle.Size = new System.Drawing.Size(151, 30);
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
            this.ButtonEkle.Location = new System.Drawing.Point(12, 394);
            this.ButtonEkle.Name = "ButtonEkle";
            this.ButtonEkle.Size = new System.Drawing.Size(123, 30);
            this.ButtonEkle.StyleController = this.layoutControl1;
            this.ButtonEkle.TabIndex = 2;
            this.ButtonEkle.Text = "EKLE";
            this.ButtonEkle.Click += new System.EventHandler(this.ButtonEkle_Click);
            // 
            // gclist
            // 
            this.gclist.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gclist.DataSource = this.entityKitapBindingSource;
            this.gclist.Location = new System.Drawing.Point(12, 12);
            this.gclist.MainView = this.gridView1;
            this.gclist.Name = "gclist";
            this.gclist.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repoKategori,
            this.repoYazar,
            this.searchLookupYazar});
            this.gclist.Size = new System.Drawing.Size(769, 368);
            this.gclist.TabIndex = 0;
            this.gclist.UseEmbeddedNavigator = true;
            this.gclist.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // entityKitapBindingSource
            // 
            this.entityKitapBindingSource.DataSource = typeof(KutuphaneYeni.Entities.EntityKitap.EntityKitap);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAd,
            this.colYayinYili,
            this.colSayfaSayisi,
            this.colFiyat,
            this.colKayitYapan,
            this.colKayitTarihi,
            this.colDegisiklikYapan,
            this.colDegisiklikTarihi,
            this.colAdi,
            this.gridColumnDelete,
            this.colKategoriID,
            this.colYazarID});
            this.gridView1.GridControl = this.gclist;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic;
            this.gridView1.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = true;
            this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView1.OptionsView.ShowFooter = true;
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
            // colYayinYili
            // 
            this.colYayinYili.Caption = "Yayın Yılı";
            this.colYayinYili.FieldName = "YayinYili";
            this.colYayinYili.MinWidth = 25;
            this.colYayinYili.Name = "colYayinYili";
            this.colYayinYili.Visible = true;
            this.colYayinYili.VisibleIndex = 4;
            this.colYayinYili.Width = 94;
            // 
            // colSayfaSayisi
            // 
            this.colSayfaSayisi.Caption = "Sayfa Sayısı";
            this.colSayfaSayisi.FieldName = "SayfaSayisi";
            this.colSayfaSayisi.MinWidth = 25;
            this.colSayfaSayisi.Name = "colSayfaSayisi";
            this.colSayfaSayisi.Visible = true;
            this.colSayfaSayisi.VisibleIndex = 5;
            this.colSayfaSayisi.Width = 94;
            // 
            // colFiyat
            // 
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.MinWidth = 25;
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 6;
            this.colFiyat.Width = 94;
            // 
            // colKayitYapan
            // 
            this.colKayitYapan.FieldName = "KayitYapan";
            this.colKayitYapan.MinWidth = 25;
            this.colKayitYapan.Name = "colKayitYapan";
            this.colKayitYapan.Width = 94;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.MinWidth = 25;
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.Width = 94;
            // 
            // colDegisiklikYapan
            // 
            this.colDegisiklikYapan.FieldName = "DegisiklikYapan";
            this.colDegisiklikYapan.MinWidth = 25;
            this.colDegisiklikYapan.Name = "colDegisiklikYapan";
            this.colDegisiklikYapan.Width = 94;
            // 
            // colDegisiklikTarihi
            // 
            this.colDegisiklikTarihi.FieldName = "DegisiklikTarihi";
            this.colDegisiklikTarihi.MinWidth = 25;
            this.colDegisiklikTarihi.Name = "colDegisiklikTarihi";
            this.colDegisiklikTarihi.Width = 94;
            // 
            // colAdi
            // 
            this.colAdi.FieldName = "Adi";
            this.colAdi.MinWidth = 25;
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.ReadOnly = true;
            this.colAdi.Width = 94;
            // 
            // gridColumnDelete
            // 
            this.gridColumnDelete.Caption = "Sil";
            this.gridColumnDelete.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumnDelete.MinWidth = 25;
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 7;
            this.gridColumnDelete.Width = 94;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // colKategoriID
            // 
            this.colKategoriID.Caption = "Kategori";
            this.colKategoriID.ColumnEdit = this.repoKategori;
            this.colKategoriID.FieldName = "KategoriID";
            this.colKategoriID.MinWidth = 25;
            this.colKategoriID.Name = "colKategoriID";
            this.colKategoriID.Visible = true;
            this.colKategoriID.VisibleIndex = 2;
            this.colKategoriID.Width = 94;
            // 
            // repoKategori
            // 
            this.repoKategori.AutoHeight = false;
            this.repoKategori.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoKategori.DataSource = this.entityKategorilerBindingSource;
            this.repoKategori.DisplayMember = "Adi";
            this.repoKategori.Name = "repoKategori";
            this.repoKategori.NullText = "";
            this.repoKategori.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.repoKategori.ValueMember = "ID";
            // 
            // entityKategorilerBindingSource
            // 
            this.entityKategorilerBindingSource.DataSource = typeof(KutuphaneYeni.Entities.EntityKategoriler.EntityKategoriler);
            // 
            // searchLookupYazar
            // 
            this.searchLookupYazar.AutoHeight = false;
            this.searchLookupYazar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookupYazar.DataSource = this.entityYazarBindingSource;
            this.searchLookupYazar.DisplayMember = "Ad";
            this.searchLookupYazar.Name = "searchLookupYazar";
            this.searchLookupYazar.NullText = "";
            this.searchLookupYazar.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.searchLookupYazar.ValueMember = "ID";
            // 
            // entityYazarBindingSource
            // 
            this.entityYazarBindingSource.DataSource = typeof(KutuphaneYeni.Entities.EntityYazar.EntityYazar);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colYazarID
            // 
            this.colYazarID.Caption = "Yazar";
            this.colYazarID.ColumnEdit = this.repoYazar;
            this.colYazarID.FieldName = "YazarID";
            this.colYazarID.MinWidth = 25;
            this.colYazarID.Name = "colYazarID";
            this.colYazarID.Visible = true;
            this.colYazarID.VisibleIndex = 3;
            this.colYazarID.Width = 94;
            // 
            // repoYazar
            // 
            this.repoYazar.AutoHeight = false;
            this.repoYazar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoYazar.DataSource = this.entityYazarBindingSource;
            this.repoYazar.DisplayMember = "Ad";
            this.repoYazar.Name = "repoYazar";
            this.repoYazar.NullText = "";
            this.repoYazar.ValueMember = "ID";
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
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(793, 436);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gclist;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(773, 372);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ButtonEkle;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 382);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(127, 34);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ButtonDuzenle;
            this.layoutControlItem3.Location = new System.Drawing.Point(253, 382);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(155, 34);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ButtonSil;
            this.layoutControlItem4.Location = new System.Drawing.Point(127, 382);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(126, 34);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 372);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(773, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ButtonCıkıs;
            this.layoutControlItem5.Location = new System.Drawing.Point(570, 382);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(203, 34);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(408, 382);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(162, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 436);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityKitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityKategorilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookupYazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityYazarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoYazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton ButtonCıkıs;
        private DevExpress.XtraEditors.SimpleButton ButtonSil;
        private DevExpress.XtraEditors.SimpleButton ButtonDuzenle;
        private DevExpress.XtraEditors.SimpleButton ButtonEkle;
        private DevExpress.XtraGrid.GridControl gclist;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colYayinYili;
        private DevExpress.XtraGrid.Columns.GridColumn colSayfaSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitYapan;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisiklikYapan;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisiklikTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource entityKitapBindingSource;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colKategoriID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoKategori;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoYazar;
        private DevExpress.XtraGrid.Columns.GridColumn colYazarID;
        private System.Windows.Forms.BindingSource entityYazarBindingSource;
        private System.Windows.Forms.BindingSource entityKategorilerBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit searchLookupYazar;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
    }
}