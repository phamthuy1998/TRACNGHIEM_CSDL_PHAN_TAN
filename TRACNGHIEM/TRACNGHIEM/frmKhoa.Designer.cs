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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaK = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDS = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TNDataSet = new TRACNGHIEM.TNDataSet();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.tbKhoaADT = new TRACNGHIEM.TNDataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager();
            this.tbGiaoVienADT = new TRACNGHIEM.TNDataSetTableAdapters.GIAOVIENTableAdapter();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcGiaoVien = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsGiaoVien = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cbbCoSoAdd = new System.Windows.Forms.ComboBox();
            this.txtMaCS = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.gcKhoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.tbLopADT = new TRACNGHIEM.TNDataSetTableAdapters.LOPTableAdapter();
            this.ctxMenuGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhucHoiGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTaiLaiGV = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.tbGiaoVienDKADT = new TRACNGHIEM.TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bdsBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.tbBoDeADT = new TRACNGHIEM.TNDataSetTableAdapters.BODETableAdapter();
            mACSLabel1 = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            this.ctxMenuGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).BeginInit();
            this.SuspendLayout();
            // 
            // mACSLabel1
            // 
            mACSLabel1.AutoSize = true;
            mACSLabel1.Location = new System.Drawing.Point(71, 403);
            mACSLabel1.Name = "mACSLabel1";
            mACSLabel1.Size = new System.Drawing.Size(128, 34);
            mACSLabel1.TabIndex = 9;
            mACSLabel1.Text = "Mã cơ sở";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(71, 96);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(121, 34);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "Mã khoa";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(71, 197);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(131, 34);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "Tên khoa";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(71, 291);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(86, 34);
            mACSLabel.TabIndex = 4;
            mACSLabel.Text = "Cơ sở";
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
            this.btnInDS,
            this.btnThoat,
            this.btnSuaK});
            this.barManager.MainMenu = this.bar6;
            this.barManager.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDS, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnInDS
            // 
            this.btnInDS.Caption = "In danh sách";
            this.btnInDS.Id = 6;
            this.btnInDS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDS.ImageOptions.Image")));
            this.btnInDS.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInDS.ImageOptions.LargeImage")));
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDS_ItemClick);
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
            this.barDockControl1.Size = new System.Drawing.Size(2496, 96);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 1461);
            this.barDockControl2.Manager = this.barManager;
            this.barDockControl2.Size = new System.Drawing.Size(2496, 0);
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
            this.barDockControl4.Location = new System.Drawing.Point(2496, 96);
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbCoSo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 96);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2496, 100);
            this.panelControl1.TabIndex = 4;
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
            this.panelControl3.Controls.Add(this.gcGiaoVien);
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Controls.Add(this.gcKhoa);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 196);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(2496, 1265);
            this.panelControl3.TabIndex = 8;
            // 
            // gcGiaoVien
            // 
            this.gcGiaoVien.AutoGenerateColumns = false;
            this.gcGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gcGiaoVien.DataSource = this.bdsGiaoVien;
            this.gcGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGiaoVien.Location = new System.Drawing.Point(980, 573);
            this.gcGiaoVien.Name = "gcGiaoVien";
            this.gcGiaoVien.RowTemplate.Height = 40;
            this.gcGiaoVien.Size = new System.Drawing.Size(1513, 689);
            this.gcGiaoVien.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAGV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAGV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HO";
            this.dataGridViewTextBoxColumn2.HeaderText = "HO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TEN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn5.HeaderText = "MAKH";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HOCVI";
            this.dataGridViewTextBoxColumn6.HeaderText = "HOCVI";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bdsGiaoVien
            // 
            this.bdsGiaoVien.DataMember = "FK_GIAOVIEN_KHOA";
            this.bdsGiaoVien.DataSource = this.bdsKhoa;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cbbCoSoAdd);
            this.panelControl2.Controls.Add(mACSLabel1);
            this.panelControl2.Controls.Add(this.txtMaCS);
            this.panelControl2.Controls.Add(mAKHLabel);
            this.panelControl2.Controls.Add(this.txtMaKH);
            this.panelControl2.Controls.Add(tENKHLabel);
            this.panelControl2.Controls.Add(this.txtTenKH);
            this.panelControl2.Controls.Add(mACSLabel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(3, 573);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(977, 689);
            this.panelControl2.TabIndex = 9;
            // 
            // cbbCoSoAdd
            // 
            this.cbbCoSoAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoSoAdd.Enabled = false;
            this.cbbCoSoAdd.FormattingEnabled = true;
            this.cbbCoSoAdd.Location = new System.Drawing.Point(251, 288);
            this.cbbCoSoAdd.Name = "cbbCoSoAdd";
            this.cbbCoSoAdd.Size = new System.Drawing.Size(486, 41);
            this.cbbCoSoAdd.TabIndex = 11;
            this.cbbCoSoAdd.SelectedIndexChanged += new System.EventHandler(this.cbbCoSoAdd_SelectedIndexChanged);
            // 
            // txtMaCS
            // 
            this.txtMaCS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MACS", true));
            this.txtMaCS.Enabled = false;
            this.txtMaCS.Location = new System.Drawing.Point(251, 395);
            this.txtMaCS.MenuManager = this.barManager;
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Size = new System.Drawing.Size(486, 50);
            this.txtMaCS.TabIndex = 10;
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MAKH", true));
            this.txtMaKH.Location = new System.Drawing.Point(251, 88);
            this.txtMaKH.MenuManager = this.barManager;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(486, 50);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "TENKH", true));
            this.txtTenKH.Location = new System.Drawing.Point(251, 189);
            this.txtTenKH.MenuManager = this.barManager;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(486, 50);
            this.txtTenKH.TabIndex = 3;
            // 
            // gcKhoa
            // 
            this.gcKhoa.DataSource = this.bdsKhoa;
            this.gcKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKhoa.Location = new System.Drawing.Point(3, 3);
            this.gcKhoa.MainView = this.gridView1;
            this.gcKhoa.MenuManager = this.barManager;
            this.gcKhoa.Name = "gcKhoa";
            this.gcKhoa.Size = new System.Drawing.Size(2490, 570);
            this.gcKhoa.TabIndex = 0;
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
            this.colMAKH.Width = 187;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 50;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.OptionsColumn.AllowEdit = false;
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 187;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 50;
            this.colMACS.Name = "colMACS";
            this.colMACS.OptionsColumn.AllowEdit = false;
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 187;
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
            // ctxMenuGV
            // 
            this.ctxMenuGV.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctxMenuGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemGV,
            this.btnXoaGV,
            this.btnGhiGV,
            this.btnPhucHoiGV,
            this.btnTaiLaiGV});
            this.ctxMenuGV.Name = "btnThemGV";
            this.ctxMenuGV.Size = new System.Drawing.Size(389, 234);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemGV.Image")));
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(388, 46);
            this.btnThemGV.Text = "Thêm giảng viên";
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaGV.Image")));
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(388, 46);
            this.btnXoaGV.Text = "Xóa giảng viên";
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnGhiGV
            // 
            this.btnGhiGV.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiGV.Image")));
            this.btnGhiGV.Name = "btnGhiGV";
            this.btnGhiGV.Size = new System.Drawing.Size(388, 46);
            this.btnGhiGV.Text = "Ghi giảng viên";
            this.btnGhiGV.Click += new System.EventHandler(this.btnGhiGV_Click);
            // 
            // btnPhucHoiGV
            // 
            this.btnPhucHoiGV.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiGV.Image")));
            this.btnPhucHoiGV.Name = "btnPhucHoiGV";
            this.btnPhucHoiGV.Size = new System.Drawing.Size(388, 46);
            this.btnPhucHoiGV.Text = "Phục hồi  giảng viên";
            this.btnPhucHoiGV.Click += new System.EventHandler(this.btnPhucHoiGV_Click);
            // 
            // btnTaiLaiGV
            // 
            this.btnTaiLaiGV.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLaiGV.Image")));
            this.btnTaiLaiGV.Name = "btnTaiLaiGV";
            this.btnTaiLaiGV.Size = new System.Drawing.Size(388, 46);
            this.btnTaiLaiGV.Text = "Tải lại danh sách";
            this.btnTaiLaiGV.Click += new System.EventHandler(this.btnTaiLaiGV_Click);
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
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2496, 1461);
            this.ContextMenuStrip = this.ctxMenuGV;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmKhoa";
            this.Text = "Form khoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhoa_FormClosing);
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            this.ctxMenuGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnInDS;
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
        private System.Windows.Forms.ContextMenuStrip ctxMenuGV;
        private System.Windows.Forms.ToolStripMenuItem btnThemGV;
        private System.Windows.Forms.ToolStripMenuItem btnXoaGV;
        private System.Windows.Forms.ToolStripMenuItem btnGhiGV;
        private System.Windows.Forms.ToolStripMenuItem btnTaiLaiGV;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter tbGiaoVienDKADT;
        private System.Windows.Forms.BindingSource bdsBoDe;
        private TNDataSetTableAdapters.BODETableAdapter tbBoDeADT;
        private System.Windows.Forms.ToolStripMenuItem btnPhucHoiGV;
        private DevExpress.XtraBars.BarButtonItem btnSuaK;
        private System.Windows.Forms.DataGridView gcGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox cbbCoSoAdd;
        private DevExpress.XtraEditors.TextEdit txtMaCS;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraGrid.GridControl gcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
    }
}