namespace TRACNGHIEM
{
    partial class frmBoDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoDe));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLaiBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatBD = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbCoSoBD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMonHocBD = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tNDataSet = new TRACNGHIEM.TNDataSet();
            this.bODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new TRACNGHIEM.TNDataSetTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager();
            this.bODEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemBD,
            this.btnGhiBD,
            this.btnXoaBD,
            this.btnSuaBD,
            this.btnPhucHoiBD,
            this.btnTaiLaiBD,
            this.btnInDSBD,
            this.btnThoatBD});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(2445, 96);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1464);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(2445, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 96);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1368);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2445, 96);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1368);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiLaiBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemBD
            // 
            this.btnThemBD.Caption = "Thêm";
            this.btnThemBD.Id = 0;
            this.btnThemBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemBD.ImageOptions.Image")));
            this.btnThemBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemBD.ImageOptions.LargeImage")));
            this.btnThemBD.Name = "btnThemBD";
            // 
            // btnGhiBD
            // 
            this.btnGhiBD.Caption = "Ghi";
            this.btnGhiBD.Id = 1;
            this.btnGhiBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiBD.ImageOptions.Image")));
            this.btnGhiBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiBD.ImageOptions.LargeImage")));
            this.btnGhiBD.Name = "btnGhiBD";
            // 
            // btnXoaBD
            // 
            this.btnXoaBD.Caption = "Xóa";
            this.btnXoaBD.Id = 2;
            this.btnXoaBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaBD.ImageOptions.Image")));
            this.btnXoaBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaBD.ImageOptions.LargeImage")));
            this.btnXoaBD.Name = "btnXoaBD";
            // 
            // btnSuaBD
            // 
            this.btnSuaBD.Caption = "Sửa";
            this.btnSuaBD.Id = 3;
            this.btnSuaBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaBD.ImageOptions.Image")));
            this.btnSuaBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaBD.ImageOptions.LargeImage")));
            this.btnSuaBD.Name = "btnSuaBD";
            // 
            // btnPhucHoiBD
            // 
            this.btnPhucHoiBD.Caption = "Phục hồi";
            this.btnPhucHoiBD.Id = 4;
            this.btnPhucHoiBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiBD.ImageOptions.Image")));
            this.btnPhucHoiBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiBD.ImageOptions.LargeImage")));
            this.btnPhucHoiBD.Name = "btnPhucHoiBD";
            // 
            // btnTaiLaiBD
            // 
            this.btnTaiLaiBD.Caption = "Tải lại";
            this.btnTaiLaiBD.Id = 5;
            this.btnTaiLaiBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLaiBD.ImageOptions.Image")));
            this.btnTaiLaiBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiLaiBD.ImageOptions.LargeImage")));
            this.btnTaiLaiBD.Name = "btnTaiLaiBD";
            // 
            // btnInDSBD
            // 
            this.btnInDSBD.Caption = "In danh sách";
            this.btnInDSBD.Id = 6;
            this.btnInDSBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDSBD.ImageOptions.Image")));
            this.btnInDSBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInDSBD.ImageOptions.LargeImage")));
            this.btnInDSBD.Name = "btnInDSBD";
            // 
            // btnThoatBD
            // 
            this.btnThoatBD.Caption = "Thoát";
            this.btnThoatBD.Id = 7;
            this.btnThoatBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatBD.ImageOptions.Image")));
            this.btnThoatBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoatBD.ImageOptions.LargeImage")));
            this.btnThoatBD.Name = "btnThoatBD";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbMonHocBD);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cbbCoSoBD);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 96);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(2445, 271);
            this.groupControl1.TabIndex = 4;
            // 
            // cbbCoSoBD
            // 
            this.cbbCoSoBD.FormattingEnabled = true;
            this.cbbCoSoBD.Location = new System.Drawing.Point(732, 76);
            this.cbbCoSoBD.Name = "cbbCoSoBD";
            this.cbbCoSoBD.Size = new System.Drawing.Size(527, 41);
            this.cbbCoSoBD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cơ sở";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Môn học";
            // 
            // cbbMonHocBD
            // 
            this.cbbMonHocBD.FormattingEnabled = true;
            this.cbbMonHocBD.Location = new System.Drawing.Point(732, 184);
            this.cbbMonHocBD.Name = "cbbMonHocBD";
            this.cbbMonHocBD.Size = new System.Drawing.Size(527, 41);
            this.cbbMonHocBD.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 1005);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(2445, 459);
            this.groupControl2.TabIndex = 5;
            // 
            // tNDataSet
            // 
            this.tNDataSet.DataSetName = "TNDataSet";
            this.tNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bODEBindingSource
            // 
            this.bODEBindingSource.DataMember = "BODE";
            this.bODEBindingSource.DataSource = this.tNDataSet;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bODEGridControl
            // 
            this.bODEGridControl.DataSource = this.bODEBindingSource;
            this.bODEGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bODEGridControl.Location = new System.Drawing.Point(0, 367);
            this.bODEGridControl.MainView = this.gridView1;
            this.bODEGridControl.MenuManager = this.barManager1;
            this.bODEGridControl.Name = "bODEGridControl";
            this.bODEGridControl.Size = new System.Drawing.Size(2445, 638);
            this.bODEGridControl.TabIndex = 7;
            this.bODEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.bODEGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // frmBoDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2445, 1464);
            this.Controls.Add(this.bODEGridControl);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBoDe";
            this.Text = "Form bộ đề";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBoDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThemBD;
        private DevExpress.XtraBars.BarButtonItem btnGhiBD;
        private DevExpress.XtraBars.BarButtonItem btnXoaBD;
        private DevExpress.XtraBars.BarButtonItem btnSuaBD;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiBD;
        private DevExpress.XtraBars.BarButtonItem btnTaiLaiBD;
        private DevExpress.XtraBars.BarButtonItem btnInDSBD;
        private DevExpress.XtraBars.BarButtonItem btnThoatBD;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private TNDataSet tNDataSet;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ComboBox cbbMonHocBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCoSoBD;
        private TNDataSetTableAdapters.BODETableAdapter bODETableAdapter;
        private TNDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl bODEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}