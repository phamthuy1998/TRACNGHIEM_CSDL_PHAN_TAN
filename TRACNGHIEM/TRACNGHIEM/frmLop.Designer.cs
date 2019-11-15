namespace TRACNGHIEM
{
    partial class frmLop
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mALOPLabel1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaL = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelTimGV = new DevExpress.XtraEditors.PanelControl();
            this.btnTim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.edtTimSV = new DevExpress.XtraEditors.TextEdit();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TNDataSet = new TRACNGHIEM.TNDataSet();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.tbLopADT = new TRACNGHIEM.TNDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager();
            this.bdsDSKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pcLop = new DevExpress.XtraEditors.PanelControl();
            this.edtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.cbbTenKhoa = new System.Windows.Forms.ComboBox();
            this.edtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.edtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.gcSinhVien = new DevExpress.XtraGrid.GridControl();
            this.ctxMenuSV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChuyenLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhucHoiSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTaiLaiSV = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcSV = new DevExpress.XtraEditors.PanelControl();
            this.cbbTenLop = new System.Windows.Forms.ComboBox();
            this.edtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.edtHo = new DevExpress.XtraEditors.TextEdit();
            this.edtTen = new DevExpress.XtraEditors.TextEdit();
            this.edtNgaySInh = new DevExpress.XtraEditors.DateEdit();
            this.edtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.edtMaLopSV = new DevExpress.XtraEditors.TextEdit();
            this.tbDSKhoaADT = new TRACNGHIEM.TNDataSetTableAdapters.DSKHOATableAdapter();
            this.tbSinhVienADT = new TRACNGHIEM.TNDataSetTableAdapters.SINHVIENTableAdapter();
            this.bdsGiaoVienDK = new System.Windows.Forms.BindingSource(this.components);
            this.tbGiaoVienADT = new TRACNGHIEM.TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bdsBangDiem = new System.Windows.Forms.BindingSource(this.components);
            this.tbBangDiemADT = new TRACNGHIEM.TNDataSetTableAdapters.BANGDIEMTableAdapter();
            this.bdsDSLop = new System.Windows.Forms.BindingSource(this.components);
            this.tbDSLopADT = new TRACNGHIEM.TNDataSetTableAdapters.DSLOPTableAdapter();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mALOPLabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTimGV)).BeginInit();
            this.panelTimGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtTimSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLop)).BeginInit();
            this.pcLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).BeginInit();
            this.ctxMenuSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSV)).BeginInit();
            this.pcSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNgaySInh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNgaySInh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaLopSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVienDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLop)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(88, 399);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(121, 34);
            mAKHLabel.TabIndex = 6;
            mAKHLabel.Text = "Mã khoa";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(98, 283);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(77, 34);
            tENKHLabel.TabIndex = 4;
            tENKHLabel.Text = "Khoa";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(98, 60);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(98, 34);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã lớp";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(98, 174);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(108, 34);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(133, 65);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(94, 34);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "Mã SV";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(133, 169);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(49, 34);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(1030, 169);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(62, 34);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(133, 282);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(138, 34);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "Ngày sinh";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(992, 282);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(100, 34);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Location = new System.Drawing.Point(994, 399);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(98, 34);
            mALOPLabel1.TabIndex = 10;
            mALOPLabel1.Text = "Mã lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(133, 399);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 34);
            label2.TabIndex = 13;
            label2.Text = "Tên lớp";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar});
            this.barManager.DockControls.Add(this.barDockControl1);
            this.barManager.DockControls.Add(this.barDockControl2);
            this.barManager.DockControls.Add(this.barDockControl3);
            this.barManager.DockControls.Add(this.barDockControl4);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnGhi,
            this.btnXoa,
            this.btnSua,
            this.btnPhucHoi,
            this.btnTaiLai,
            this.btnThoat,
            this.btnSuaL});
            this.barManager.MainMenu = this.bar;
            this.barManager.MaxItemId = 9;
            // 
            // bar
            // 
            this.bar.BarName = "Main menu";
            this.bar.DockCol = 0;
            this.bar.DockRow = 0;
            this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar.OptionsBar.MultiLine = true;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSuaL
            // 
            this.btnSuaL.Caption = "Sửa";
            this.btnSuaL.Id = 8;
            this.btnSuaL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaL.ImageOptions.Image")));
            this.btnSuaL.Name = "btnSuaL";
            this.btnSuaL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaL_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 1;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Caption = "Tải lại";
            this.btnTaiLai.Id = 5;
            this.btnTaiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.Image")));
            this.btnTaiLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.LargeImage")));
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiLai_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager;
            this.barDockControl1.Size = new System.Drawing.Size(3036, 96);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 1552);
            this.barDockControl2.Manager = this.barManager;
            this.barDockControl2.Size = new System.Drawing.Size(3036, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 96);
            this.barDockControl3.Manager = this.barManager;
            this.barDockControl3.Size = new System.Drawing.Size(0, 1456);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(3036, 96);
            this.barDockControl4.Manager = this.barManager;
            this.barDockControl4.Size = new System.Drawing.Size(0, 1456);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 3;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelTimGV);
            this.panelControl1.Controls.Add(this.cbbCoSo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 96);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(3036, 100);
            this.panelControl1.TabIndex = 5;
            // 
            // panelTimGV
            // 
            this.panelTimGV.Controls.Add(this.btnTim);
            this.panelTimGV.Controls.Add(this.label3);
            this.panelTimGV.Controls.Add(this.edtTimSV);
            this.panelTimGV.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTimGV.Location = new System.Drawing.Point(1892, 3);
            this.panelTimGV.Name = "panelTimGV";
            this.panelTimGV.Size = new System.Drawing.Size(1141, 94);
            this.panelTimGV.TabIndex = 6;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(928, 10);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(142, 74);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tìm kiếm";
            // 
            // edtTimSV
            // 
            this.edtTimSV.Location = new System.Drawing.Point(310, 23);
            this.edtTimSV.MenuManager = this.barManager;
            this.edtTimSV.Name = "edtTimSV";
            this.edtTimSV.Size = new System.Drawing.Size(576, 50);
            this.edtTimSV.TabIndex = 5;
            this.edtTimSV.EditValueChanged += new System.EventHandler(this.edtTimSV_EditValueChanged);
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoSo.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Location = new System.Drawing.Point(445, 26);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(604, 48);
            this.cbbCoSo.TabIndex = 1;
            this.cbbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cơ sở";
            // 
            // TNDataSet
            // 
            this.TNDataSet.DataSetName = "TNDataSet";
            this.TNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.TNDataSet;
            // 
            // tbLopADT
            // 
            this.tbLopADT.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTableAdapter = this.tbLopADT;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsDSKhoa
            // 
            this.bdsDSKhoa.DataMember = "DSKHOA";
            this.bdsDSKhoa.DataSource = this.TNDataSet;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.tableLayoutPanel1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 196);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(3036, 1356);
            this.panelControl3.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.75908F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.24092F));
            this.tableLayoutPanel1.Controls.Add(this.pcLop, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gcSinhVien, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gcLop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pcSV, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.81482F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.18518F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(3030, 1350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pcLop
            // 
            this.pcLop.Controls.Add(this.edtMaKH);
            this.pcLop.Controls.Add(mAKHLabel);
            this.pcLop.Controls.Add(tENKHLabel);
            this.pcLop.Controls.Add(this.cbbTenKhoa);
            this.pcLop.Controls.Add(mALOPLabel);
            this.pcLop.Controls.Add(this.edtMaLop);
            this.pcLop.Controls.Add(tENLOPLabel);
            this.pcLop.Controls.Add(this.edtTenLop);
            this.pcLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcLop.Location = new System.Drawing.Point(3, 797);
            this.pcLop.Name = "pcLop";
            this.pcLop.Size = new System.Drawing.Size(926, 550);
            this.pcLop.TabIndex = 8;
            // 
            // edtMaKH
            // 
            this.edtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MAKH", true));
            this.edtMaKH.Enabled = false;
            this.edtMaKH.Location = new System.Drawing.Point(260, 391);
            this.edtMaKH.MenuManager = this.barManager;
            this.edtMaKH.Name = "edtMaKH";
            this.edtMaKH.Size = new System.Drawing.Size(250, 50);
            this.edtMaKH.TabIndex = 9;
            // 
            // cbbTenKhoa
            // 
            this.cbbTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSKhoa, "TENKH", true));
            this.cbbTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsLop, "MAKH", true));
            this.cbbTenKhoa.DataSource = this.bdsDSKhoa;
            this.cbbTenKhoa.DisplayMember = "TENKH";
            this.cbbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenKhoa.FormattingEnabled = true;
            this.cbbTenKhoa.Location = new System.Drawing.Point(260, 283);
            this.cbbTenKhoa.Name = "cbbTenKhoa";
            this.cbbTenKhoa.Size = new System.Drawing.Size(534, 41);
            this.cbbTenKhoa.TabIndex = 5;
            this.cbbTenKhoa.ValueMember = "MAKH";
            this.cbbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbTenKhoa_SelectedIndexChanged);
            // 
            // edtMaLop
            // 
            this.edtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.edtMaLop.Location = new System.Drawing.Point(260, 62);
            this.edtMaLop.MenuManager = this.barManager;
            this.edtMaLop.Name = "edtMaLop";
            this.edtMaLop.Size = new System.Drawing.Size(534, 50);
            this.edtMaLop.TabIndex = 1;
            // 
            // edtTenLop
            // 
            this.edtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.edtTenLop.Location = new System.Drawing.Point(260, 176);
            this.edtTenLop.MenuManager = this.barManager;
            this.edtTenLop.Name = "edtTenLop";
            this.edtTenLop.Size = new System.Drawing.Size(534, 50);
            this.edtTenLop.TabIndex = 3;
            // 
            // gcSinhVien
            // 
            this.gcSinhVien.ContextMenuStrip = this.ctxMenuSV;
            this.gcSinhVien.DataSource = this.bdsSinhVien;
            this.gcSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSinhVien.Location = new System.Drawing.Point(935, 3);
            this.gcSinhVien.MainView = this.gridView2;
            this.gcSinhVien.MenuManager = this.barManager;
            this.gcSinhVien.Name = "gcSinhVien";
            this.gcSinhVien.Size = new System.Drawing.Size(2092, 788);
            this.gcSinhVien.TabIndex = 1;
            this.gcSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // ctxMenuSV
            // 
            this.ctxMenuSV.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctxMenuSV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemSV,
            this.btnSuaSV,
            this.btnChuyenLop,
            this.btnXoaSV,
            this.btnGhiSV,
            this.btnPhucHoiSV,
            this.btnTaiLaiSV});
            this.ctxMenuSV.Name = "contextMenuStrip1";
            this.ctxMenuSV.Size = new System.Drawing.Size(462, 326);
            // 
            // btnThemSV
            // 
            this.btnThemSV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSV.Image")));
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(461, 46);
            this.btnThemSV.Text = "Thêm sinh viên";
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSV.Image")));
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(461, 46);
            this.btnSuaSV.Text = "Sửa sinh viên";
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);
            // 
            // btnChuyenLop
            // 
            this.btnChuyenLop.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenLop.Image")));
            this.btnChuyenLop.Name = "btnChuyenLop";
            this.btnChuyenLop.Size = new System.Drawing.Size(461, 46);
            this.btnChuyenLop.Text = "Chuyển lớp";
            this.btnChuyenLop.Click += new System.EventHandler(this.btnChuyenLop_Click);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSV.Image")));
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(461, 46);
            this.btnXoaSV.Text = "Xóa sinh viên";
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnGhiSV
            // 
            this.btnGhiSV.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiSV.Image")));
            this.btnGhiSV.Name = "btnGhiSV";
            this.btnGhiSV.Size = new System.Drawing.Size(461, 46);
            this.btnGhiSV.Text = "Ghi sinh viên";
            this.btnGhiSV.Click += new System.EventHandler(this.btnGhiSV_Click);
            // 
            // btnPhucHoiSV
            // 
            this.btnPhucHoiSV.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiSV.Image")));
            this.btnPhucHoiSV.Name = "btnPhucHoiSV";
            this.btnPhucHoiSV.Size = new System.Drawing.Size(461, 46);
            this.btnPhucHoiSV.Text = "Phục hồi";
            this.btnPhucHoiSV.Click += new System.EventHandler(this.btnPhucHoiSV_Click);
            // 
            // btnTaiLaiSV
            // 
            this.btnTaiLaiSV.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLaiSV.Image")));
            this.btnTaiLaiSV.Name = "btnTaiLaiSV";
            this.btnTaiLaiSV.Size = new System.Drawing.Size(461, 46);
            this.btnTaiLaiSV.Text = "Tải lại danh sách sinh viên";
            this.btnTaiLaiSV.Click += new System.EventHandler(this.btnTaiLaiSV_Click);
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSinhVien.DataSource = this.bdsLop;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colMALOP});
            this.gridView2.GridControl = this.gcSinhVien;
            this.gridView2.Name = "gridView2";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 50;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 159;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 50;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowFocus = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 541;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 50;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 179;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 50;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            this.colNGAYSINH.Width = 228;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 50;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 770;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 50;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 5;
            this.colMALOP.Width = 175;
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLop.Location = new System.Drawing.Point(3, 3);
            this.gcLop.MainView = this.gridView1;
            this.gcLop.MenuManager = this.barManager;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(926, 788);
            this.gcLop.TabIndex = 7;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP1,
            this.colTENLOP,
            this.colMAKH});
            this.gridView1.GridControl = this.gcLop;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP1
            // 
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.MinWidth = 50;
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.OptionsColumn.AllowEdit = false;
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 0;
            this.colMALOP1.Width = 135;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 50;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 587;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 50;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 164;
            // 
            // pcSV
            // 
            this.pcSV.ContextMenuStrip = this.ctxMenuSV;
            this.pcSV.Controls.Add(this.cbbTenLop);
            this.pcSV.Controls.Add(label2);
            this.pcSV.Controls.Add(mASVLabel);
            this.pcSV.Controls.Add(this.edtMaSV);
            this.pcSV.Controls.Add(hOLabel);
            this.pcSV.Controls.Add(this.edtHo);
            this.pcSV.Controls.Add(tENLabel);
            this.pcSV.Controls.Add(this.edtTen);
            this.pcSV.Controls.Add(nGAYSINHLabel);
            this.pcSV.Controls.Add(this.edtNgaySInh);
            this.pcSV.Controls.Add(dIACHILabel);
            this.pcSV.Controls.Add(this.edtDiaChi);
            this.pcSV.Controls.Add(mALOPLabel1);
            this.pcSV.Controls.Add(this.edtMaLopSV);
            this.pcSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcSV.Location = new System.Drawing.Point(935, 797);
            this.pcSV.Name = "pcSV";
            this.pcSV.Size = new System.Drawing.Size(2092, 550);
            this.pcSV.TabIndex = 9;
            // 
            // cbbTenLop
            // 
            this.cbbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsLop, "MALOP", true));
            this.cbbTenLop.DataSource = this.bdsDSLop;
            this.cbbTenLop.DisplayMember = "TENLOP";
            this.cbbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenLop.FormattingEnabled = true;
            this.cbbTenLop.Location = new System.Drawing.Point(299, 396);
            this.cbbTenLop.Name = "cbbTenLop";
            this.cbbTenLop.Size = new System.Drawing.Size(563, 41);
            this.cbbTenLop.TabIndex = 14;
            this.cbbTenLop.ValueMember = "MALOP";
            this.cbbTenLop.SelectedIndexChanged += new System.EventHandler(this.cbbTenLop_SelectedIndexChanged);
            // 
            // edtMaSV
            // 
            this.edtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "MASV", true));
            this.edtMaSV.Location = new System.Drawing.Point(299, 62);
            this.edtMaSV.MenuManager = this.barManager;
            this.edtMaSV.Name = "edtMaSV";
            this.edtMaSV.Size = new System.Drawing.Size(250, 50);
            this.edtMaSV.TabIndex = 1;
            // 
            // edtHo
            // 
            this.edtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "HO", true));
            this.edtHo.Location = new System.Drawing.Point(299, 166);
            this.edtHo.MenuManager = this.barManager;
            this.edtHo.Name = "edtHo";
            this.edtHo.Size = new System.Drawing.Size(563, 50);
            this.edtHo.TabIndex = 3;
            // 
            // edtTen
            // 
            this.edtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "TEN", true));
            this.edtTen.Location = new System.Drawing.Point(1139, 166);
            this.edtTen.MenuManager = this.barManager;
            this.edtTen.Name = "edtTen";
            this.edtTen.Size = new System.Drawing.Size(250, 50);
            this.edtTen.TabIndex = 5;
            // 
            // edtNgaySInh
            // 
            this.edtNgaySInh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "NGAYSINH", true));
            this.edtNgaySInh.EditValue = null;
            this.edtNgaySInh.Location = new System.Drawing.Point(299, 279);
            this.edtNgaySInh.MenuManager = this.barManager;
            this.edtNgaySInh.Name = "edtNgaySInh";
            this.edtNgaySInh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtNgaySInh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtNgaySInh.Size = new System.Drawing.Size(563, 50);
            this.edtNgaySInh.TabIndex = 7;
            // 
            // edtDiaChi
            // 
            this.edtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "DIACHI", true));
            this.edtDiaChi.Location = new System.Drawing.Point(1141, 279);
            this.edtDiaChi.MenuManager = this.barManager;
            this.edtDiaChi.Name = "edtDiaChi";
            this.edtDiaChi.Size = new System.Drawing.Size(946, 50);
            this.edtDiaChi.TabIndex = 9;
            // 
            // edtMaLopSV
            // 
            this.edtMaLopSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "MALOP", true));
            this.edtMaLopSV.Enabled = false;
            this.edtMaLopSV.Location = new System.Drawing.Point(1139, 391);
            this.edtMaLopSV.MenuManager = this.barManager;
            this.edtMaLopSV.Name = "edtMaLopSV";
            this.edtMaLopSV.Size = new System.Drawing.Size(250, 50);
            this.edtMaLopSV.TabIndex = 11;
            // 
            // tbDSKhoaADT
            // 
            this.tbDSKhoaADT.ClearBeforeFill = true;
            // 
            // tbSinhVienADT
            // 
            this.tbSinhVienADT.ClearBeforeFill = true;
            // 
            // bdsGiaoVienDK
            // 
            this.bdsGiaoVienDK.DataMember = "FK_GIAOVIEN_DANGKY_LOP";
            this.bdsGiaoVienDK.DataSource = this.bdsLop;
            // 
            // tbGiaoVienADT
            // 
            this.tbGiaoVienADT.ClearBeforeFill = true;
            // 
            // bdsBangDiem
            // 
            this.bdsBangDiem.DataMember = "FK_BANGDIEM_SINHVIEN1";
            this.bdsBangDiem.DataSource = this.bdsSinhVien;
            // 
            // tbBangDiemADT
            // 
            this.tbBangDiemADT.ClearBeforeFill = true;
            // 
            // bdsDSLop
            // 
            this.bdsDSLop.DataMember = "DSLOP";
            this.bdsDSLop.DataSource = this.TNDataSet;
            // 
            // tbDSLopADT
            // 
            this.tbDSLopADT.ClearBeforeFill = true;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3036, 1552);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmLop";
            this.Text = "Form lớp";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTimGV)).EndInit();
            this.panelTimGV.ResumeLayout(false);
            this.panelTimGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtTimSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcLop)).EndInit();
            this.pcLop.ResumeLayout(false);
            this.pcLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).EndInit();
            this.ctxMenuSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSV)).EndInit();
            this.pcSV.ResumeLayout(false);
            this.pcSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNgaySInh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNgaySInh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaLopSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVienDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private System.Windows.Forms.BindingSource bdsLop;
        private TNDataSet TNDataSet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.Label label1;
        private TNDataSetTableAdapters.LOPTableAdapter tbLopADT;
        private TNDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.BindingSource bdsDSKhoa;
        private TNDataSetTableAdapters.DSKHOATableAdapter tbDSKhoaADT;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private TNDataSetTableAdapters.SINHVIENTableAdapter tbSinhVienADT;
        private System.Windows.Forms.ContextMenuStrip ctxMenuSV;
        private System.Windows.Forms.ToolStripMenuItem btnThemSV;
        private System.Windows.Forms.ToolStripMenuItem btnGhiSV;
        private System.Windows.Forms.ToolStripMenuItem btnXoaSV;
        private System.Windows.Forms.BindingSource bdsGiaoVienDK;
        private TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter tbGiaoVienADT;
        private System.Windows.Forms.BindingSource bdsBangDiem;
        private TNDataSetTableAdapters.BANGDIEMTableAdapter tbBangDiemADT;
        private System.Windows.Forms.ToolStripMenuItem btnTaiLaiSV;
        private System.Windows.Forms.ToolStripMenuItem btnPhucHoiSV;
        public DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSuaL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl pcLop;
        private System.Windows.Forms.ComboBox cbbTenKhoa;
        private DevExpress.XtraEditors.TextEdit edtMaLop;
        private DevExpress.XtraEditors.TextEdit edtTenLop;
        private DevExpress.XtraGrid.GridControl gcSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraEditors.PanelControl pcSV;
        private DevExpress.XtraEditors.TextEdit edtMaSV;
        private DevExpress.XtraEditors.TextEdit edtHo;
        private DevExpress.XtraEditors.TextEdit edtTen;
        private DevExpress.XtraEditors.DateEdit edtNgaySInh;
        private DevExpress.XtraEditors.TextEdit edtDiaChi;
        private DevExpress.XtraEditors.TextEdit edtMaLopSV;
        private DevExpress.XtraEditors.PanelControl panelTimGV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit edtTimSV;
        private System.Windows.Forms.ToolStripMenuItem btnSuaSV;
        private System.Windows.Forms.ToolStripMenuItem btnChuyenLop;
        private DevExpress.XtraEditors.TextEdit edtMaKH;
        private System.Windows.Forms.ComboBox cbbTenLop;
        private System.Windows.Forms.BindingSource bdsDSLop;
        private TNDataSetTableAdapters.DSLOPTableAdapter tbDSLopADT;
    }
}