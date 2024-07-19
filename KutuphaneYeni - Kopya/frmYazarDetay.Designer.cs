
namespace KutuphaneYeni
{
    partial class frmYazarDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYazarDetay));
            this.ulketextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.Btniptal = new DevExpress.XtraEditors.SimpleButton();
            this.Btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.SoyadtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AdtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.adlyt = new DevExpress.XtraLayout.LayoutControlItem();
            this.Soyadlyt = new DevExpress.XtraLayout.LayoutControlItem();
            this.ulkelyt = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDt = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ulketextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoyadtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adlyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soyadlyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulkelyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDt)).BeginInit();
            this.SuspendLayout();
            // 
            // ulketextEdit
            // 
            this.ulketextEdit.Location = new System.Drawing.Point(103, 90);
            this.ulketextEdit.Name = "ulketextEdit";
            this.ulketextEdit.Size = new System.Drawing.Size(309, 22);
            this.ulketextEdit.StyleController = this.layoutControl1;
            this.ulketextEdit.TabIndex = 11;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.MistyRose;
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Controls.Add(this.Btniptal);
            this.layoutControl1.Controls.Add(this.Btnkaydet);
            this.layoutControl1.Controls.Add(this.SoyadtextEdit);
            this.layoutControl1.Controls.Add(this.AdtextEdit);
            this.layoutControl1.Controls.Add(this.ulketextEdit);
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
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(103, 64);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(309, 22);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 17;
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
            // SoyadtextEdit
            // 
            this.SoyadtextEdit.Location = new System.Drawing.Point(103, 38);
            this.SoyadtextEdit.Name = "SoyadtextEdit";
            this.SoyadtextEdit.Size = new System.Drawing.Size(309, 22);
            this.SoyadtextEdit.StyleController = this.layoutControl1;
            this.SoyadtextEdit.TabIndex = 13;
            // 
            // AdtextEdit
            // 
            this.AdtextEdit.Location = new System.Drawing.Point(103, 12);
            this.AdtextEdit.Name = "AdtextEdit";
            this.AdtextEdit.Size = new System.Drawing.Size(309, 22);
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
            this.ulkelyt,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutDt});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(424, 311);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 104);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(404, 145);
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
            this.adlyt.TextSize = new System.Drawing.Size(88, 16);
            // 
            // Soyadlyt
            // 
            this.Soyadlyt.Control = this.SoyadtextEdit;
            this.Soyadlyt.Location = new System.Drawing.Point(0, 26);
            this.Soyadlyt.Name = "Soyadlyt";
            this.Soyadlyt.Size = new System.Drawing.Size(404, 26);
            this.Soyadlyt.Text = "SOYAD";
            this.Soyadlyt.TextSize = new System.Drawing.Size(88, 16);
            // 
            // ulkelyt
            // 
            this.ulkelyt.Control = this.ulketextEdit;
            this.ulkelyt.Location = new System.Drawing.Point(0, 78);
            this.ulkelyt.Name = "ulkelyt";
            this.ulkelyt.Size = new System.Drawing.Size(404, 26);
            this.ulkelyt.Text = "ÜLKE";
            this.ulkelyt.TextSize = new System.Drawing.Size(88, 16);
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
            // layoutDt
            // 
            this.layoutDt.Control = this.dateEdit1;
            this.layoutDt.Location = new System.Drawing.Point(0, 52);
            this.layoutDt.Name = "layoutDt";
            this.layoutDt.Size = new System.Drawing.Size(404, 26);
            this.layoutDt.Text = "DOĞUM TARİHİ";
            this.layoutDt.TextSize = new System.Drawing.Size(88, 16);
            // 
            // frmYazarDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(424, 311);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmYazarDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazar Detay";
            this.Load += new System.EventHandler(this.frmYazarDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ulketextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoyadtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adlyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soyadlyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulkelyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit ulketextEdit;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit SoyadtextEdit;
        private DevExpress.XtraEditors.TextEdit AdtextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem adlyt;
        private DevExpress.XtraLayout.LayoutControlItem Soyadlyt;
        private DevExpress.XtraLayout.LayoutControlItem ulkelyt;
        private DevExpress.XtraEditors.SimpleButton Btniptal;
        private DevExpress.XtraEditors.SimpleButton Btnkaydet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutDt;
    }
}