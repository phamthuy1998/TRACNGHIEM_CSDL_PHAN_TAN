namespace TRACNGHIEM
{
    partial class frmMonHoc
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
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.btnThemMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLaiMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDanhSachMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatMH = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.gcMonHoc = new DevExpress.XtraEditors.GroupControl();
            this.mACSComboBox = new System.Windows.Forms.ComboBox();
            this.bdsCoSo = new System.Windows.Forms.BindingSource(this.components);
            this.TNDataSet = new TRACNGHIEM.TNDataSet();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.tbMonHoc = new TRACNGHIEM.TNDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tENMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bdsGiaoVienDkiMH = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new TRACNGHIEM.TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bdsBoDeMH = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new TRACNGHIEM.TNDataSetTableAdapters.BODETableAdapter();
            this.bdsBangDiem = new System.Windows.Forms.BindingSource(this.components);
            this.bANGDIEMTableAdapter = new TRACNGHIEM.TNDataSetTableAdapters.BANGDIEMTableAdapter();
            mACSLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
            this.gcMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCoSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVienDkiMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDeMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(617, 102);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(86, 34);
            mACSLabel.TabIndex = 0;
            mACSLabel.Text = "Cơ sở";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(63, 140);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(169, 34);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Mã môn học";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(881, 140);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(179, 34);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "Tên môn học";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(580, 337);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 96);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(2448, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 2108);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(2448, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 96);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 2012);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2448, 96);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 2012);
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar6});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemMH,
            this.btnGhiMH,
            this.btnXoaMH,
            this.btnSuaMH,
            this.btnPhucHoiMH,
            this.btnTaiLaiMH,
            this.btnInDanhSachMH,
            this.btnThoatMH});
            this.barManager2.MainMenu = this.bar6;
            this.barManager2.MaxItemId = 8;
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiLaiMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDanhSachMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // btnThemMH
            // 
            this.btnThemMH.Caption = "Thêm";
            this.btnThemMH.Id = 0;
            this.btnThemMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMH.ImageOptions.Image")));
            this.btnThemMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemMH.ImageOptions.LargeImage")));
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemMH_ItemClick);
            // 
            // btnGhiMH
            // 
            this.btnGhiMH.Caption = "Ghi";
            this.btnGhiMH.Id = 1;
            this.btnGhiMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiMH.ImageOptions.Image")));
            this.btnGhiMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiMH.ImageOptions.LargeImage")));
            this.btnGhiMH.Name = "btnGhiMH";
            this.btnGhiMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiMH_ItemClick);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Caption = "Xóa";
            this.btnXoaMH.Id = 2;
            this.btnXoaMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMH.ImageOptions.Image")));
            this.btnXoaMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaMH.ImageOptions.LargeImage")));
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaMH_ItemClick);
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Caption = "Sửa";
            this.btnSuaMH.Id = 3;
            this.btnSuaMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaMH.ImageOptions.Image")));
            this.btnSuaMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaMH.ImageOptions.LargeImage")));
            this.btnSuaMH.Name = "btnSuaMH";
            // 
            // btnPhucHoiMH
            // 
            this.btnPhucHoiMH.Caption = "Phục hồi";
            this.btnPhucHoiMH.Id = 4;
            this.btnPhucHoiMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiMH.ImageOptions.Image")));
            this.btnPhucHoiMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiMH.ImageOptions.LargeImage")));
            this.btnPhucHoiMH.Name = "btnPhucHoiMH";
            this.btnPhucHoiMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiMH_ItemClick);
            // 
            // btnTaiLaiMH
            // 
            this.btnTaiLaiMH.Caption = "Tải lại";
            this.btnTaiLaiMH.Id = 5;
            this.btnTaiLaiMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLaiMH.ImageOptions.Image")));
            this.btnTaiLaiMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiLaiMH.ImageOptions.LargeImage")));
            this.btnTaiLaiMH.Name = "btnTaiLaiMH";
            this.btnTaiLaiMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiLaiMH_ItemClick);
            // 
            // btnInDanhSachMH
            // 
            this.btnInDanhSachMH.Caption = "In danh sách";
            this.btnInDanhSachMH.Id = 6;
            this.btnInDanhSachMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDanhSachMH.ImageOptions.Image")));
            this.btnInDanhSachMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInDanhSachMH.ImageOptions.LargeImage")));
            this.btnInDanhSachMH.Name = "btnInDanhSachMH";
            this.btnInDanhSachMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDanhSachMH_ItemClick);
            // 
            // btnThoatMH
            // 
            this.btnThoatMH.Caption = "Thoát";
            this.btnThoatMH.Id = 7;
            this.btnThoatMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatMH.ImageOptions.Image")));
            this.btnThoatMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoatMH.ImageOptions.LargeImage")));
            this.btnThoatMH.Name = "btnThoatMH";
            this.btnThoatMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatMH_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(2448, 96);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 2108);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(2448, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 96);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 2012);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(2448, 96);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 2012);
            // 
            // gcMonHoc
            // 
            this.gcMonHoc.Controls.Add(mACSLabel);
            this.gcMonHoc.Controls.Add(this.mACSComboBox);
            this.gcMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMonHoc.Location = new System.Drawing.Point(0, 96);
            this.gcMonHoc.Name = "gcMonHoc";
            this.gcMonHoc.Size = new System.Drawing.Size(2448, 199);
            this.gcMonHoc.TabIndex = 8;
            // 
            // mACSComboBox
            // 
            this.mACSComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCoSo, "MACS", true));
            this.mACSComboBox.FormattingEnabled = true;
            this.mACSComboBox.Location = new System.Drawing.Point(720, 99);
            this.mACSComboBox.Name = "mACSComboBox";
            this.mACSComboBox.Size = new System.Drawing.Size(493, 41);
            this.mACSComboBox.TabIndex = 1;
            // 
            // bdsCoSo
            // 
            this.bdsCoSo.DataMember = "COSO";
            this.bdsCoSo.DataSource = this.TNDataSet;
            // 
            // TNDataSet
            // 
            this.TNDataSet.DataSetName = "TNDataSet";
            this.TNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.TNDataSet;
            // 
            // tbMonHoc
            // 
            this.tbMonHoc.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.tbMonHoc;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(tENMHLabel);
            this.groupControl1.Controls.Add(this.tENMHTextEdit);
            this.groupControl1.Controls.Add(mAMHLabel);
            this.groupControl1.Controls.Add(this.mAMHTextEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 1524);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(2448, 584);
            this.groupControl1.TabIndex = 11;
            // 
            // tENMHTextEdit
            // 
            this.tENMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "TENMH", true));
            this.tENMHTextEdit.Location = new System.Drawing.Point(1107, 132);
            this.tENMHTextEdit.MenuManager = this.barManager1;
            this.tENMHTextEdit.Name = "tENMHTextEdit";
            this.tENMHTextEdit.Size = new System.Drawing.Size(1028, 50);
            this.tENMHTextEdit.TabIndex = 3;
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "MAMH", true));
            this.mAMHTextEdit.Location = new System.Drawing.Point(299, 132);
            this.mAMHTextEdit.MenuManager = this.barManager1;
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Size = new System.Drawing.Size(404, 50);
            this.mAMHTextEdit.TabIndex = 1;
            // 
            // mONHOCGridControl
            // 
            this.mONHOCGridControl.DataSource = this.bdsMonHoc;
            this.mONHOCGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mONHOCGridControl.Location = new System.Drawing.Point(0, 295);
            this.mONHOCGridControl.MainView = this.gridView1;
            this.mONHOCGridControl.MenuManager = this.barManager1;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.Size = new System.Drawing.Size(2448, 1229);
            this.mONHOCGridControl.TabIndex = 11;
            this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.mONHOCGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // bdsGiaoVienDkiMH
            // 
            this.bdsGiaoVienDkiMH.DataMember = "FK_GIAOVIEN_DANGKY_MONHOC1";
            this.bdsGiaoVienDkiMH.DataSource = this.bdsMonHoc;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // bdsBoDeMH
            // 
            this.bdsBoDeMH.DataMember = "FK_BODE_MONHOC";
            this.bdsBoDeMH.DataSource = this.bdsMonHoc;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // bdsBangDiem
            // 
            this.bdsBangDiem.DataMember = "FK_BANGDIEM_MONHOC";
            this.bdsBangDiem.DataSource = this.bdsMonHoc;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2448, 2108);
            this.Controls.Add(this.mONHOCGridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcMonHoc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmMonHoc";
            this.Text = "Form Môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMonHoc_FormClosing);
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
            this.gcMonHoc.ResumeLayout(false);
            this.gcMonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCoSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVienDkiMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDeMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemMH;
        private DevExpress.XtraBars.BarButtonItem btnGhiMH;
        private DevExpress.XtraBars.BarButtonItem btnXoaMH;
        private DevExpress.XtraBars.BarButtonItem btnSuaMH;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiMH;
        private DevExpress.XtraBars.BarButtonItem btnTaiLaiMH;
        private DevExpress.XtraEditors.GroupControl gcMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSachMH;
        private DevExpress.XtraBars.BarButtonItem btnThoatMH;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private TNDataSet TNDataSet;
        private TNDataSetTableAdapters.MONHOCTableAdapter tbMonHoc;
        private TNDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdsCoSo;
        private DevExpress.XtraEditors.TextEdit tENMHTextEdit;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
        private System.Windows.Forms.ComboBox mACSComboBox;
        private System.Windows.Forms.BindingSource bdsGiaoVienDkiMH;
        private TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsBoDeMH;
        private TNDataSetTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource bdsBangDiem;
        private TNDataSetTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
    }
}