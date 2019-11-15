using System;

namespace TRACNGHIEM
{
    partial class frmKhoa
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
            System.Windows.Forms.Label mACSLabel1;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mAKHLabel1;
            System.Windows.Forms.Label hOCVILabel;
            System.Windows.Forms.Label mAKHLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaK = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnTimKiem = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelTimGV = new DevExpress.XtraEditors.PanelControl();
            this.btnTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edtTimGV = new DevExpress.XtraEditors.TextEdit();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TNDataSet = new TRACNGHIEM.TNDataSet();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.tbKhoaADT = new TRACNGHIEM.TNDataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager();
            this.tbGiaoVienADT = new TRACNGHIEM.TNDataSetTableAdapters.GIAOVIENTableAdapter();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gcGiaoVien = new DevExpress.XtraGrid.GridControl();
            this.ctxMenuGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChuyenKhoaGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhucHoiGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTaiLaiGV = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsGiaoVien = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.cbbCoSoAdd = new System.Windows.Forms.ComboBox();
            this.txtMaCS = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.gcKhoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.cbbHocVi = new System.Windows.Forms.ComboBox();
            this.cbbKhoaGV = new System.Windows.Forms.ComboBox();
            this.bdsDSKHOA = new System.Windows.Forms.BindingSource(this.components);
            this.edtMaKHGV = new DevExpress.XtraEditors.TextEdit();
            this.edtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.edtHoGV = new DevExpress.XtraEditors.TextEdit();
            this.edtTenGV = new DevExpress.XtraEditors.TextEdit();
            this.edtDiachiGV = new DevExpress.XtraEditors.TextEdit();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.tbLopADT = new TRACNGHIEM.TNDataSetTableAdapters.LOPTableAdapter();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.tbGiaoVienDKADT = new TRACNGHIEM.TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bdsBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.tbBoDeADT = new TRACNGHIEM.TNDataSetTableAdapters.BODETableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tbDSKHOAADT = new TRACNGHIEM.TNDataSetTableAdapters.DSKHOATableAdapter();
            mACSLabel1 = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mAKHLabel1 = new System.Windows.Forms.Label();
            hOCVILabel = new System.Windows.Forms.Label();
            mAKHLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTimGV)).BeginInit();
            this.panelTimGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtTimGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVien)).BeginInit();
            this.ctxMenuGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaKHGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHoGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDiachiGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mACSLabel1
            // 
            mACSLabel1.AutoSize = true;
            mACSLabel1.Location = new System.Drawing.Point(71, 358);
            mACSLabel1.Name = "mACSLabel1";
            mACSLabel1.Size = new System.Drawing.Size(128, 34);
            mACSLabel1.TabIndex = 9;
            mACSLabel1.Text = "Mã cơ sở";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(71, 56);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(121, 34);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "Mã khoa";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(71, 157);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(131, 34);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "Tên khoa";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(71, 251);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(86, 34);
            mACSLabel.TabIndex = 4;
            mACSLabel.Text = "Cơ sở";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(138, 56);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(97, 34);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã GV";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(138, 157);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(49, 34);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(914, 149);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(62, 34);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(135, 251);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(100, 34);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // mAKHLabel1
            // 
            mAKHLabel1.AutoSize = true;
            mAKHLabel1.Location = new System.Drawing.Point(138, 358);
            mAKHLabel1.Name = "mAKHLabel1";
            mAKHLabel1.Size = new System.Drawing.Size(77, 34);
            mAKHLabel1.TabIndex = 8;
            mAKHLabel1.Text = "Khoa";
            // 
            // hOCVILabel
            // 
            hOCVILabel.AutoSize = true;
            hOCVILabel.Location = new System.Drawing.Point(696, 56);
            hOCVILabel.Name = "hOCVILabel";
            hOCVILabel.Size = new System.Drawing.Size(100, 34);
            hOCVILabel.TabIndex = 10;
            hOCVILabel.Text = "Học vị ";
            // 
            // mAKHLabel2
            // 
            mAKHLabel2.AutoSize = true;
            mAKHLabel2.Location = new System.Drawing.Point(914, 348);
            mAKHLabel2.Name = "mAKHLabel2";
            mAKHLabel2.Size = new System.Drawing.Size(96, 34);
            mAKHLabel2.TabIndex = 12;
            mAKHLabel2.Text = "Mã KH";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar6});
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
            this.btnSuaK,
            this.btnTimKiem});
            this.barManager.MainMenu = this.bar6;
            this.barManager.MaxItemId = 10;
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
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
            // btnSuaK
            // 
            this.btnSuaK.Caption = "Sửa";
            this.btnSuaK.Id = 8;
            this.btnSuaK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaK.ImageOptions.Image")));
            this.btnSuaK.Name = "btnSuaK";
            this.btnSuaK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaK_ItemClick);
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
            this.barDockControl1.Size = new System.Drawing.Size(2665, 96);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 1461);
            this.barDockControl2.Manager = this.barManager;
            this.barDockControl2.Size = new System.Drawing.Size(2665, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 96);
            this.barDockControl3.Manager = this.barManager;
            this.barDockControl3.Size = new System.Drawing.Size(0, 1365);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(2665, 96);
            this.barDockControl4.Manager = this.barManager;
            this.barDockControl4.Size = new System.Drawing.Size(0, 1365);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 3;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Caption = "Tìm kiếm";
            this.btnTimKiem.Id = 9;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Name = "btnTimKiem";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelTimGV);
            this.panelControl1.Controls.Add(this.cbbCoSo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 96);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2665, 114);
            this.panelControl1.TabIndex = 4;
            // 
            // panelTimGV
            // 
            this.panelTimGV.Controls.Add(this.btnTim);
            this.panelTimGV.Controls.Add(this.label2);
            this.panelTimGV.Controls.Add(this.edtTimGV);
            this.panelTimGV.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTimGV.Location = new System.Drawing.Point(1521, 3);
            this.panelTimGV.Name = "panelTimGV";
            this.panelTimGV.Size = new System.Drawing.Size(1141, 108);
            this.panelTimGV.TabIndex = 5;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm kiếm";
            // 
            // edtTimGV
            // 
            this.edtTimGV.Location = new System.Drawing.Point(310, 23);
            this.edtTimGV.MenuManager = this.barManager;
            this.edtTimGV.Name = "edtTimGV";
            this.edtTimGV.Size = new System.Drawing.Size(576, 50);
            this.edtTimGV.TabIndex = 5;
            this.edtTimGV.EditValueChanged += new System.EventHandler(this.edtTimGV_EditValueChanged);
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
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.TNDataSet;
            // 
            // tbKhoaADT
            // 
            this.tbKhoaADT.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.tbGiaoVienADT;
            this.tableAdapterManager.KHOATableAdapter = this.tbKhoaADT;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbGiaoVienADT
            // 
            this.tbGiaoVienADT.ClearBeforeFill = true;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.tableLayoutPanel1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 210);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(2665, 1251);
            this.panelControl3.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.3861F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.6139F));
            this.tableLayoutPanel1.Controls.Add(this.gcGiaoVien, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gcKhoa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.39793F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.60207F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2659, 1245);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // gcGiaoVien
            // 
            this.gcGiaoVien.ContextMenuStrip = this.ctxMenuGV;
            this.gcGiaoVien.DataSource = this.bdsGiaoVien;
            this.gcGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGiaoVien.Location = new System.Drawing.Point(1076, 3);
            this.gcGiaoVien.MainView = this.gridView2;
            this.gcGiaoVien.MenuManager = this.barManager;
            this.gcGiaoVien.Name = "gcGiaoVien";
            this.gcGiaoVien.Size = new System.Drawing.Size(1580, 758);
            this.gcGiaoVien.TabIndex = 10;
            this.gcGiaoVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // ctxMenuGV
            // 
            this.ctxMenuGV.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctxMenuGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemGV,
            this.btnSuaGV,
            this.btnChuyenKhoaGV,
            this.btnXoaGV,
            this.btnGhiGV,
            this.btnPhucHoiGV,
            this.btnTaiLaiGV});
            this.ctxMenuGV.Name = "btnThemGV";
            this.ctxMenuGV.Size = new System.Drawing.Size(389, 381);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemGV.Image")));
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(388, 46);
            this.btnThemGV.Text = "Thêm giảng viên";
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click_1);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaGV.Image")));
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(388, 46);
            this.btnSuaGV.Text = "Sửa giảng viên";
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // btnChuyenKhoaGV
            // 
            this.btnChuyenKhoaGV.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenKhoaGV.Image")));
            this.btnChuyenKhoaGV.Name = "btnChuyenKhoaGV";
            this.btnChuyenKhoaGV.Size = new System.Drawing.Size(388, 46);
            this.btnChuyenKhoaGV.Text = "Chuyển khoa";
            this.btnChuyenKhoaGV.Click += new System.EventHandler(this.btnChuyenKhoaGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaGV.Image")));
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(388, 46);
            this.btnXoaGV.Text = "Xóa giảng viên";
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click_1);
            // 
            // btnGhiGV
            // 
            this.btnGhiGV.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiGV.Image")));
            this.btnGhiGV.Name = "btnGhiGV";
            this.btnGhiGV.Size = new System.Drawing.Size(388, 46);
            this.btnGhiGV.Text = "Ghi giảng viên";
            this.btnGhiGV.Click += new System.EventHandler(this.btnGhiGV_Click_1);
            // 
            // btnPhucHoiGV
            // 
            this.btnPhucHoiGV.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiGV.Image")));
            this.btnPhucHoiGV.Name = "btnPhucHoiGV";
            this.btnPhucHoiGV.Size = new System.Drawing.Size(388, 46);
            this.btnPhucHoiGV.Text = "Phục hồi  giảng viên";
            this.btnPhucHoiGV.Click += new System.EventHandler(this.btnPhucHoiGV_Click_1);
            // 
            // btnTaiLaiGV
            // 
            this.btnTaiLaiGV.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLaiGV.Image")));
            this.btnTaiLaiGV.Name = "btnTaiLaiGV";
            this.btnTaiLaiGV.Size = new System.Drawing.Size(388, 46);
            this.btnTaiLaiGV.Text = "Tải lại danh sách";
            this.btnTaiLaiGV.Click += new System.EventHandler(this.btnTaiLaiGV_Click_1);
            // 
            // bdsGiaoVien
            // 
            this.bdsGiaoVien.DataMember = "FK_GIAOVIEN_KHOA";
            this.bdsGiaoVien.DataSource = this.bdsKhoa;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colMAKH1,
            this.colHOCVI});
            this.gridView2.GridControl = this.gcGiaoVien;
            this.gridView2.Name = "gridView2";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 50;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 134;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 50;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 395;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 50;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 156;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 50;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 357;
            // 
            // colMAKH1
            // 
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.MinWidth = 50;
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.OptionsColumn.AllowEdit = false;
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 4;
            this.colMAKH1.Width = 153;
            // 
            // colHOCVI
            // 
            this.colHOCVI.FieldName = "HOCVI";
            this.colHOCVI.MinWidth = 50;
            this.colHOCVI.Name = "colHOCVI";
            this.colHOCVI.OptionsColumn.AllowEdit = false;
            this.colHOCVI.Visible = true;
            this.colHOCVI.VisibleIndex = 5;
            this.colHOCVI.Width = 345;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtMaKH);
            this.panelControl2.Controls.Add(this.cbbCoSoAdd);
            this.panelControl2.Controls.Add(mACSLabel1);
            this.panelControl2.Controls.Add(this.txtMaCS);
            this.panelControl2.Controls.Add(mAKHLabel);
            this.panelControl2.Controls.Add(tENKHLabel);
            this.panelControl2.Controls.Add(this.txtTenKH);
            this.panelControl2.Controls.Add(mACSLabel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(3, 767);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1067, 475);
            this.panelControl2.TabIndex = 10;
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MAKH", true));
            this.txtMaKH.Location = new System.Drawing.Point(251, 48);
            this.txtMaKH.MenuManager = this.barManager;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(486, 50);
            this.txtMaKH.TabIndex = 12;
            // 
            // cbbCoSoAdd
            // 
            this.cbbCoSoAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoSoAdd.Enabled = false;
            this.cbbCoSoAdd.FormattingEnabled = true;
            this.cbbCoSoAdd.Location = new System.Drawing.Point(251, 248);
            this.cbbCoSoAdd.Name = "cbbCoSoAdd";
            this.cbbCoSoAdd.Size = new System.Drawing.Size(486, 41);
            this.cbbCoSoAdd.TabIndex = 11;
            this.cbbCoSoAdd.SelectedIndexChanged += new System.EventHandler(this.cbbCoSoAdd_SelectedIndexChanged_1);
            // 
            // txtMaCS
            // 
            this.txtMaCS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MACS", true));
            this.txtMaCS.Enabled = false;
            this.txtMaCS.Location = new System.Drawing.Point(251, 350);
            this.txtMaCS.MenuManager = this.barManager;
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Size = new System.Drawing.Size(486, 50);
            this.txtMaCS.TabIndex = 10;
            // 
            // txtTenKH
            // 
            this.txtTenKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "TENKH", true));
            this.txtTenKH.Location = new System.Drawing.Point(251, 149);
            this.txtTenKH.MenuManager = this.barManager;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(486, 50);
            this.txtTenKH.TabIndex = 3;
            // 
            // gcKhoa
            // 
            this.gcKhoa.DataSource = this.bdsKhoa;
            this.gcKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKhoa.Location = new System.Drawing.Point(3, 3);
            this.gcKhoa.MainView = this.gridView1;
            this.gcKhoa.MenuManager = this.barManager;
            this.gcKhoa.Name = "gcKhoa";
            this.gcKhoa.Size = new System.Drawing.Size(1067, 758);
            this.gcKhoa.TabIndex = 1;
            this.gcKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.GridControl = this.gcKhoa;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 50;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 193;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 50;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.OptionsColumn.AllowEdit = false;
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 625;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 50;
            this.colMACS.Name = "colMACS";
            this.colMACS.OptionsColumn.AllowEdit = false;
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 209;
            // 
            // panelControl4
            // 
            this.panelControl4.ContextMenuStrip = this.ctxMenuGV;
            this.panelControl4.Controls.Add(this.cbbHocVi);
            this.panelControl4.Controls.Add(this.cbbKhoaGV);
            this.panelControl4.Controls.Add(mAKHLabel2);
            this.panelControl4.Controls.Add(this.edtMaKHGV);
            this.panelControl4.Controls.Add(mAGVLabel);
            this.panelControl4.Controls.Add(this.edtMaGV);
            this.panelControl4.Controls.Add(hOLabel);
            this.panelControl4.Controls.Add(this.edtHoGV);
            this.panelControl4.Controls.Add(tENLabel);
            this.panelControl4.Controls.Add(this.edtTenGV);
            this.panelControl4.Controls.Add(dIACHILabel);
            this.panelControl4.Controls.Add(this.edtDiachiGV);
            this.panelControl4.Controls.Add(mAKHLabel1);
            this.panelControl4.Controls.Add(hOCVILabel);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(1076, 767);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1580, 475);
            this.panelControl4.TabIndex = 11;
            // 
            // cbbHocVi
            // 
            this.cbbHocVi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiaoVien, "HOCVI", true));
            this.cbbHocVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocVi.FormattingEnabled = true;
            this.cbbHocVi.Location = new System.Drawing.Point(855, 49);
            this.cbbHocVi.Name = "cbbHocVi";
            this.cbbHocVi.Size = new System.Drawing.Size(400, 41);
            this.cbbHocVi.TabIndex = 15;
            // 
            // cbbKhoaGV
            // 
            this.cbbKhoaGV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsKhoa, "MAKH", true));
            this.cbbKhoaGV.DataSource = this.bdsDSKHOA;
            this.cbbKhoaGV.DisplayMember = "TENKH";
            this.cbbKhoaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoaGV.Enabled = false;
            this.cbbKhoaGV.FormattingEnabled = true;
            this.cbbKhoaGV.Location = new System.Drawing.Point(302, 355);
            this.cbbKhoaGV.Name = "cbbKhoaGV";
            this.cbbKhoaGV.Size = new System.Drawing.Size(540, 41);
            this.cbbKhoaGV.TabIndex = 14;
            this.cbbKhoaGV.ValueMember = "MAKH";
            this.cbbKhoaGV.SelectedIndexChanged += new System.EventHandler(this.cbbKhoaGV_SelectedIndexChanged);
            // 
            // bdsDSKHOA
            // 
            this.bdsDSKHOA.DataMember = "DSKHOA";
            this.bdsDSKHOA.DataSource = this.TNDataSet;
            // 
            // edtMaKHGV
            // 
            this.edtMaKHGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "MAKH", true));
            this.edtMaKHGV.Enabled = false;
            this.edtMaKHGV.Location = new System.Drawing.Point(1024, 340);
            this.edtMaKHGV.MenuManager = this.barManager;
            this.edtMaKHGV.Name = "edtMaKHGV";
            this.edtMaKHGV.Size = new System.Drawing.Size(231, 50);
            this.edtMaKHGV.TabIndex = 13;
            // 
            // edtMaGV
            // 
            this.edtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "MAGV", true));
            this.edtMaGV.Location = new System.Drawing.Point(302, 44);
            this.edtMaGV.MenuManager = this.barManager;
            this.edtMaGV.Name = "edtMaGV";
            this.edtMaGV.Size = new System.Drawing.Size(250, 50);
            this.edtMaGV.TabIndex = 1;
            // 
            // edtHoGV
            // 
            this.edtHoGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "HO", true));
            this.edtHoGV.Location = new System.Drawing.Point(302, 149);
            this.edtHoGV.MenuManager = this.barManager;
            this.edtHoGV.Name = "edtHoGV";
            this.edtHoGV.Size = new System.Drawing.Size(540, 50);
            this.edtHoGV.TabIndex = 3;
            // 
            // edtTenGV
            // 
            this.edtTenGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "TEN", true));
            this.edtTenGV.Location = new System.Drawing.Point(1024, 141);
            this.edtTenGV.MenuManager = this.barManager;
            this.edtTenGV.Name = "edtTenGV";
            this.edtTenGV.Size = new System.Drawing.Size(231, 50);
            this.edtTenGV.TabIndex = 5;
            // 
            // edtDiachiGV
            // 
            this.edtDiachiGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "DIACHI", true));
            this.edtDiachiGV.Location = new System.Drawing.Point(302, 244);
            this.edtDiachiGV.MenuManager = this.barManager;
            this.edtDiachiGV.Name = "edtDiachiGV";
            this.edtDiachiGV.Size = new System.Drawing.Size(540, 50);
            this.edtDiachiGV.TabIndex = 7;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "FK_LOP_KHOA";
            this.bdsLop.DataSource = this.bdsKhoa;
            // 
            // tbLopADT
            // 
            this.tbLopADT.ClearBeforeFill = true;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "FK_GIAOVIEN_DANGKY_GIAOVIEN1";
            this.bdsGVDK.DataSource = this.bdsGiaoVien;
            // 
            // tbGiaoVienDKADT
            // 
            this.tbGiaoVienDKADT.ClearBeforeFill = true;
            // 
            // bdsBoDe
            // 
            this.bdsBoDe.DataMember = "FK_BODE_GIAOVIEN";
            this.bdsBoDe.DataSource = this.bdsGiaoVien;
            // 
            // tbBoDeADT
            // 
            this.tbBoDeADT.ClearBeforeFill = true;
            // 
            // tbDSKHOAADT
            // 
            this.tbDSKHOAADT.ClearBeforeFill = true;
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2665, 1461);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmKhoa";
            this.Text = "Form khoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTimGV)).EndInit();
            this.panelTimGV.ResumeLayout(false);
            this.panelTimGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtTimGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVien)).EndInit();
            this.ctxMenuGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaKHGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHoGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDiachiGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarButtonItem btnThem;
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
        private System.Windows.Forms.BindingSource bdsKhoa;
        private TNDataSet TNDataSet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.Label label1;
        private TNDataSetTableAdapters.KHOATableAdapter tbKhoaADT;
        private TNDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private TNDataSetTableAdapters.GIAOVIENTableAdapter tbGiaoVienADT;
        private System.Windows.Forms.BindingSource bdsGiaoVien;
        private System.Windows.Forms.BindingSource bdsLop;
        private TNDataSetTableAdapters.LOPTableAdapter tbLopADT;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter tbGiaoVienDKADT;
        private System.Windows.Forms.BindingSource bdsBoDe;
        private TNDataSetTableAdapters.BODETableAdapter tbBoDeADT;
        private DevExpress.XtraBars.BarButtonItem btnSuaK;
        private DevExpress.XtraBars.BarButtonItem btnTimKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gcGiaoVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVI;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox cbbCoSoAdd;
        private DevExpress.XtraEditors.TextEdit txtMaCS;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraGrid.GridControl gcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.TextEdit edtMaGV;
        private DevExpress.XtraEditors.TextEdit edtHoGV;
        private DevExpress.XtraEditors.TextEdit edtTenGV;
        private DevExpress.XtraEditors.TextEdit edtDiachiGV;
        private System.Windows.Forms.ComboBox cbbKhoaGV;
        private DevExpress.XtraEditors.TextEdit edtMaKHGV;
        private System.Windows.Forms.ContextMenuStrip ctxMenuGV;
        private System.Windows.Forms.ToolStripMenuItem btnThemGV;
        private System.Windows.Forms.ToolStripMenuItem btnXoaGV;
        private System.Windows.Forms.ToolStripMenuItem btnGhiGV;
        private System.Windows.Forms.ToolStripMenuItem btnPhucHoiGV;
        private System.Windows.Forms.ToolStripMenuItem btnTaiLaiGV;
        private System.Windows.Forms.ComboBox cbbHocVi;
        private System.Windows.Forms.ToolStripMenuItem btnSuaGV;
        private System.Windows.Forms.ToolStripMenuItem btnChuyenKhoaGV;
        private DevExpress.XtraEditors.PanelControl panelTimGV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit edtTimGV;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource bdsDSKHOA;
        private TNDataSetTableAdapters.DSKHOATableAdapter tbDSKHOAADT;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
    }
}