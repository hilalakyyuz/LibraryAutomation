

    namespace KutuphaneYeni
{
    partial class frmKullanicilar
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.RaporBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCıkıs = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSil = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gwlist = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitYapan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegisiklikYapan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegisiklikTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOduncKitaplar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.RaporBtn);
            this.layoutControl1.Controls.Add(this.ButtonCıkıs);
            this.layoutControl1.Controls.Add(this.ButtonSil);
            this.layoutControl1.Controls.Add(this.ButtonDuzenle);
            this.layoutControl1.Controls.Add(this.ButtonEkle);
            this.layoutControl1.Controls.Add(this.gcList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(795, 565);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // RaporBtn
            // 
            this.RaporBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RaporBtn.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.RaporBtn.Appearance.Options.UseFont = true;
            this.RaporBtn.Appearance.Options.UseForeColor = true;
            this.RaporBtn.Location = new System.Drawing.Point(612, 492);
            this.RaporBtn.Name = "RaporBtn";
            this.RaporBtn.Size = new System.Drawing.Size(171, 27);
            this.RaporBtn.StyleController = this.layoutControl1;
            this.RaporBtn.TabIndex = 10;
            this.RaporBtn.Text = "RAPOR YAZDIR";
            this.RaporBtn.Click += new System.EventHandler(this.RaporBtn_Click);
            // 
            // ButtonCıkıs
            // 
            this.ButtonCıkıs.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonCıkıs.Appearance.ForeColor = System.Drawing.Color.Red;
            this.ButtonCıkıs.Appearance.Options.UseFont = true;
            this.ButtonCıkıs.Appearance.Options.UseForeColor = true;
            this.ButtonCıkıs.Location = new System.Drawing.Point(612, 523);
            this.ButtonCıkıs.Name = "ButtonCıkıs";
            this.ButtonCıkıs.Size = new System.Drawing.Size(171, 30);
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
            this.ButtonSil.Location = new System.Drawing.Point(167, 523);
            this.ButtonSil.Name = "ButtonSil";
            this.ButtonSil.Size = new System.Drawing.Size(151, 30);
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
            this.ButtonDuzenle.Location = new System.Drawing.Point(322, 523);
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
            this.ButtonEkle.Location = new System.Drawing.Point(12, 523);
            this.ButtonEkle.Name = "ButtonEkle";
            this.ButtonEkle.Size = new System.Drawing.Size(151, 30);
            this.ButtonEkle.StyleController = this.layoutControl1;
            this.ButtonEkle.TabIndex = 2;
            this.ButtonEkle.Text = "EKLE";
            this.ButtonEkle.Click += new System.EventHandler(this.ButtonEkle_Click);
            // 
            // gcList
            // 
            this.gcList.Location = new System.Drawing.Point(12, 12);
            this.gcList.MainView = this.gwlist;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(771, 476);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwlist});
            // 
            // gwlist
            // 
            this.gwlist.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAdSoyad,
            this.colEmail,
            this.colKayitYapan,
            this.colKayitTarihi,
            this.colDegisiklikYapan,
            this.colDegisiklikTarihi,
            this.colResim,
            this.colOduncKitaplar});
            this.gwlist.GridControl = this.gcList;
            this.gwlist.Name = "gwlist";
            this.gwlist.OptionsBehavior.Editable = false;
            this.gwlist.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 22;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            this.colID.Width = 77;
            // 
            // colAdSoyad
            // 
            this.colAdSoyad.FieldName = "AdSoyad";
            this.colAdSoyad.MinWidth = 22;
            this.colAdSoyad.Name = "colAdSoyad";
            this.colAdSoyad.Visible = true;
            this.colAdSoyad.VisibleIndex = 2;
            this.colAdSoyad.Width = 147;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 22;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            this.colEmail.Width = 478;
            // 
            // colKayitYapan
            // 
            this.colKayitYapan.FieldName = "KayitYapan";
            this.colKayitYapan.MinWidth = 22;
            this.colKayitYapan.Name = "colKayitYapan";
            this.colKayitYapan.Width = 82;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.MinWidth = 22;
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.Width = 82;
            // 
            // colDegisiklikYapan
            // 
            this.colDegisiklikYapan.FieldName = "DegisiklikYapan";
            this.colDegisiklikYapan.MinWidth = 22;
            this.colDegisiklikYapan.Name = "colDegisiklikYapan";
            this.colDegisiklikYapan.Width = 82;
            // 
            // colDegisiklikTarihi
            // 
            this.colDegisiklikTarihi.FieldName = "DegisiklikTarihi";
            this.colDegisiklikTarihi.MinWidth = 22;
            this.colDegisiklikTarihi.Name = "colDegisiklikTarihi";
            this.colDegisiklikTarihi.Width = 82;
            // 
            // colResim
            // 
            this.colResim.FieldName = "Resim";
            this.colResim.MinWidth = 22;
            this.colResim.Name = "colResim";
            this.colResim.Visible = true;
            this.colResim.VisibleIndex = 0;
            this.colResim.Width = 82;
            // 
            // colOduncKitaplar
            // 
            this.colOduncKitaplar.FieldName = "OduncKitaplar";
            this.colOduncKitaplar.MinWidth = 22;
            this.colOduncKitaplar.Name = "colOduncKitaplar";
            this.colOduncKitaplar.Width = 82;
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
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(795, 565);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(775, 480);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ButtonEkle;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 511);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(155, 34);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ButtonDuzenle;
            this.layoutControlItem3.Location = new System.Drawing.Point(310, 511);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(155, 34);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ButtonSil;
            this.layoutControlItem4.Location = new System.Drawing.Point(155, 511);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(155, 34);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ButtonCıkıs;
            this.layoutControlItem5.Location = new System.Drawing.Point(600, 511);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(175, 34);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.RaporBtn;
            this.layoutControlItem6.Location = new System.Drawing.Point(600, 480);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(175, 31);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 480);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(600, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(465, 511);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(135, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(795, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 565);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(795, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 565);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(795, 0);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 565);
            // 
            // frmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 565);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKullanicilar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton ButtonCıkıs;
        private DevExpress.XtraEditors.SimpleButton ButtonSil;
        private DevExpress.XtraEditors.SimpleButton ButtonDuzenle;
        private DevExpress.XtraEditors.SimpleButton ButtonEkle;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gwlist;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitYapan;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisiklikYapan;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisiklikTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colResim;
        private DevExpress.XtraGrid.Columns.GridColumn colOduncKitaplar;
        private DevExpress.XtraEditors.SimpleButton RaporBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}