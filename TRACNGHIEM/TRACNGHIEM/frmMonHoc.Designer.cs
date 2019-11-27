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
            this.btnSuaMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLaiMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatMH = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.btnInDanhSachMH = new DevExpress.XtraBars.BarButtonItem();
            this.gcMonHoc = new DevExpress.XtraEditors.GroupControl();
            this.panelTimGV = new DevExpress.XtraEditors.PanelControl();
            this.btnTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edtTim = new DevExpress.XtraEditors.TextEdit();
            this.TNDataSet = new TRACNGHIEM.TNDataSet();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.tbMonHoc = new TRACNGHIEM.TNDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.edtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.edtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.gcMH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsGiaoVienDkiMH = new System.Windows.Forms.BindingSource(this.components);
            this.tbGVDKyADT = new TRACNGHIEM.TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bdsBoDeMH = new System.Windows.Forms.BindingSource(this.components);
            this.tbBoDeADT = new TRACNGHIEM.TNDataSetTableAdapters.BODETableAdapter();
            this.bdsBangDiem = new System.Windows.Forms.BindingSource(this.components);
            this.tbBangDiemADT = new TRACNGHIEM.TNDataSetTableAdapters.BANGDIEMTableAdapter();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
            this.gcMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTimGV)).BeginInit();
            this.panelTimGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtTim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVienDkiMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDeMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(64, 141);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(169, 34);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Mã môn học";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(880, 141);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(2540, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1261);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(2540, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 96);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1165);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2540, 96);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1165);
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
            this.btnThoatMH,
            this.btnRedo,
            this.btnHuy});
            this.barManager2.MainMenu = this.bar6;
            this.barManager2.MaxItemId = 10;
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRedo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiLaiMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnSuaMH
            // 
            this.btnSuaMH.Caption = "Sửa";
            this.btnSuaMH.Id = 3;
            this.btnSuaMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaMH.ImageOptions.Image")));
            this.btnSuaMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaMH.ImageOptions.LargeImage")));
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaMH_ItemClick);
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
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy thêm/Sửa";
            this.btnHuy.Id = 9;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
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
            // btnPhucHoiMH
            // 
            this.btnPhucHoiMH.Caption = "Phục hồi";
            this.btnPhucHoiMH.Id = 4;
            this.btnPhucHoiMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiMH.ImageOptions.Image")));
            this.btnPhucHoiMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiMH.ImageOptions.LargeImage")));
            this.btnPhucHoiMH.Name = "btnPhucHoiMH";
            this.btnPhucHoiMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiMH_ItemClick);
            // 
            // btnRedo
            // 
            this.btnRedo.Caption = "Quay lại";
            this.btnRedo.Id = 8;
            this.btnRedo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.ImageOptions.Image")));
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRedo_ItemClick);
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
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(2540, 96);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 1261);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl2.Size = new System.Drawing.Size(2540, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 96);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(0, 1165);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(2540, 96);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(0, 1165);
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
            // gcMonHoc
            // 
            this.gcMonHoc.Controls.Add(this.panelTimGV);
            this.gcMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMonHoc.Location = new System.Drawing.Point(0, 96);
            this.gcMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcMonHoc.Name = "gcMonHoc";
            this.gcMonHoc.Size = new System.Drawing.Size(2540, 193);
            this.gcMonHoc.TabIndex = 8;
            // 
            // panelTimGV
            // 
            this.panelTimGV.Controls.Add(this.btnTim);
            this.panelTimGV.Controls.Add(this.label2);
            this.panelTimGV.Controls.Add(this.edtTim);
            this.panelTimGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTimGV.Location = new System.Drawing.Point(3, 48);
            this.panelTimGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTimGV.Name = "panelTimGV";
            this.panelTimGV.Size = new System.Drawing.Size(2534, 142);
            this.panelTimGV.TabIndex = 6;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(933, 29);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(141, 74);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm kiếm";
            // 
            // edtTim
            // 
            this.edtTim.Location = new System.Drawing.Point(315, 41);
            this.edtTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtTim.Name = "edtTim";
            this.edtTim.Size = new System.Drawing.Size(576, 50);
            this.edtTim.TabIndex = 5;
            this.edtTim.EditValueChanged += new System.EventHandler(this.edtTim_EditValueChanged);
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
            this.groupControl1.Controls.Add(this.edtTenMH);
            this.groupControl1.Controls.Add(mAMHLabel);
            this.groupControl1.Controls.Add(this.edtMaMH);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 901);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(2540, 360);
            this.groupControl1.TabIndex = 11;
            // 
            // edtTenMH
            // 
            this.edtTenMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "TENMH", true));
            this.edtTenMH.Enabled = false;
            this.edtTenMH.Location = new System.Drawing.Point(1107, 131);
            this.edtTenMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtTenMH.MenuManager = this.barManager1;
            this.edtTenMH.Name = "edtTenMH";
            this.edtTenMH.Size = new System.Drawing.Size(1029, 50);
            this.edtTenMH.TabIndex = 3;
            // 
            // edtMaMH
            // 
            this.edtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "MAMH", true));
            this.edtMaMH.Enabled = false;
            this.edtMaMH.Location = new System.Drawing.Point(299, 131);
            this.edtMaMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtMaMH.MenuManager = this.barManager1;
            this.edtMaMH.Name = "edtMaMH";
            this.edtMaMH.Size = new System.Drawing.Size(405, 50);
            this.edtMaMH.TabIndex = 1;
            // 
            // gcMH
            // 
            this.gcMH.DataSource = this.bdsMonHoc;
            this.gcMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcMH.Location = new System.Drawing.Point(0, 289);
            this.gcMH.MainView = this.gridView1;
            this.gcMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcMH.MenuManager = this.barManager1;
            this.gcMH.Name = "gcMH";
            this.gcMH.Size = new System.Drawing.Size(2540, 612);
            this.gcMH.TabIndex = 11;
            this.gcMH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 0;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridView1.DetailHeight = 351;
            this.gridView1.FooterPanelHeight = 0;
            this.gridView1.GridControl = this.gcMH;
            this.gridView1.GroupRowHeight = 0;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.PreviewIndent = 0;
            this.gridView1.RowHeight = 0;
            this.gridView1.ViewCaptionHeight = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 51;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 733;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 51;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 1675;
            // 
            // bdsGiaoVienDkiMH
            // 
            this.bdsGiaoVienDkiMH.DataMember = "FK_GIAOVIEN_DANGKY_MONHOC1";
            this.bdsGiaoVienDkiMH.DataSource = this.bdsMonHoc;
            // 
            // tbGVDKyADT
            // 
            this.tbGVDKyADT.ClearBeforeFill = true;
            // 
            // bdsBoDeMH
            // 
            this.bdsBoDeMH.DataMember = "FK_BODE_MONHOC";
            this.bdsBoDeMH.DataSource = this.bdsMonHoc;
            // 
            // tbBoDeADT
            // 
            this.tbBoDeADT.ClearBeforeFill = true;
            // 
            // bdsBangDiem
            // 
            this.bdsBangDiem.DataMember = "FK_BANGDIEM_MONHOC";
            this.bdsBangDiem.DataSource = this.bdsMonHoc;
            // 
            // tbBangDiemADT
            // 
            this.tbBangDiemADT.ClearBeforeFill = true;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2540, 1261);
            this.Controls.Add(this.gcMH);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMonHoc";
            this.Text = "Form Môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
            this.gcMonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelTimGV)).EndInit();
            this.panelTimGV.ResumeLayout(false);
            this.panelTimGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtTim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMH)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcMH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit edtTenMH;
        private DevExpress.XtraEditors.TextEdit edtMaMH;
        private System.Windows.Forms.BindingSource bdsGiaoVienDkiMH;
        private TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter tbGVDKyADT;
        private System.Windows.Forms.BindingSource bdsBoDeMH;
        private TNDataSetTableAdapters.BODETableAdapter tbBoDeADT;
        private System.Windows.Forms.BindingSource bdsBangDiem;
        private TNDataSetTableAdapters.BANGDIEMTableAdapter tbBangDiemADT;
        private DevExpress.XtraEditors.PanelControl panelTimGV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit edtTim;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
    }
}