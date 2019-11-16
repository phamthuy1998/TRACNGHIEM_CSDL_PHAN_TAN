namespace TRACNGHIEM
{
    partial class frmGiangVienDangKy
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVienDangKy));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemGVDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaGVDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaGVDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiGVDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuchoiGVDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLaiGVDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatGVDK = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnInDSGVDK = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.gcDetail = new DevExpress.XtraEditors.GroupControl();
            this.cbbTenGV = new System.Windows.Forms.ComboBox();
            this.bdsDSGiangVien = new System.Windows.Forms.BindingSource(this.components);
            this.tNDataSet = new TRACNGHIEM.TNDataSet();
            this.bdsGiangVienDK = new System.Windows.Forms.BindingSource(this.components);
            this.cbbLan = new System.Windows.Forms.ComboBox();
            this.cbbThoiGian = new System.Windows.Forms.ComboBox();
            this.cbbTenMon = new System.Windows.Forms.ComboBox();
            this.bdsDSMH = new System.Windows.Forms.BindingSource(this.components);
            this.cbbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsDSLop = new System.Windows.Forms.BindingSource(this.components);
            this.cbbTrinhDo = new System.Windows.Forms.ComboBox();
            this.edtSoCau = new DevExpress.XtraEditors.SpinEdit();
            this.edtNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.edtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.edtMaMon = new DevExpress.XtraEditors.TextEdit();
            this.edtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.tbGiangVienDK = new TRACNGHIEM.TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager();
            this.gcGVDK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbDSMH = new TRACNGHIEM.TNDataSetTableAdapters.DSMONHOCTableAdapter();
            this.tbDSLopADT = new TRACNGHIEM.TNDataSetTableAdapters.DSLOPTableAdapter();
            this.tbDSGiangVien = new TRACNGHIEM.TNDataSetTableAdapters.DSGIAOVIENTableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetail)).BeginInit();
            this.gcDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVienDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSoCau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(131, 132);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(188, 34);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã giảng viên";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(1184, 132);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(126, 34);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "Tên môn";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(131, 244);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(119, 34);
            tRINHDOLabel.TabIndex = 6;
            tRINHDOLabel.Text = "Trình độ";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(1184, 244);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(118, 34);
            nGAYTHILabel.TabIndex = 8;
            nGAYTHILabel.Text = "Ngày thi";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(131, 344);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(100, 34);
            lANLabel.TabIndex = 10;
            lANLabel.Text = "Lần thi";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(1184, 344);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(139, 34);
            sOCAUTHILabel.TabIndex = 12;
            sOCAUTHILabel.Text = "Số câu thi";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(2253, 339);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(130, 34);
            tHOIGIANLabel.TabIndex = 14;
            tHOIGIANLabel.Text = "Thời gian";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(975, 76);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 34);
            label1.TabIndex = 5;
            label1.Text = "Cơ sở";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(2703, 344);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 34);
            label2.TabIndex = 16;
            label2.Text = "(Phút)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(2253, 132);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 34);
            label3.TabIndex = 19;
            label3.Text = "Tên lớp";
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
            this.btnThemGVDK,
            this.btnGhiGVDK,
            this.btnXoaGVDK,
            this.btnSuaGVDK,
            this.btnPhuchoiGVDK,
            this.btnTaiLaiGVDK,
            this.btnInDSGVDK,
            this.btnThoatGVDK});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemGVDK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaGVDK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaGVDK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiGVDK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhuchoiGVDK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiLaiGVDK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatGVDK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemGVDK
            // 
            this.btnThemGVDK.Caption = "Thêm";
            this.btnThemGVDK.Id = 0;
            this.btnThemGVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemGVDK.ImageOptions.Image")));
            this.btnThemGVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemGVDK.ImageOptions.LargeImage")));
            this.btnThemGVDK.Name = "btnThemGVDK";
            this.btnThemGVDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemGVDK_ItemClick);
            // 
            // btnSuaGVDK
            // 
            this.btnSuaGVDK.Caption = "Sửa";
            this.btnSuaGVDK.Id = 3;
            this.btnSuaGVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaGVDK.ImageOptions.Image")));
            this.btnSuaGVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaGVDK.ImageOptions.LargeImage")));
            this.btnSuaGVDK.Name = "btnSuaGVDK";
            this.btnSuaGVDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaGVDK_ItemClick);
            // 
            // btnXoaGVDK
            // 
            this.btnXoaGVDK.Caption = "Xóa";
            this.btnXoaGVDK.Id = 2;
            this.btnXoaGVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaGVDK.ImageOptions.Image")));
            this.btnXoaGVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaGVDK.ImageOptions.LargeImage")));
            this.btnXoaGVDK.Name = "btnXoaGVDK";
            this.btnXoaGVDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaGVDK_ItemClick);
            // 
            // btnGhiGVDK
            // 
            this.btnGhiGVDK.Caption = "Ghi";
            this.btnGhiGVDK.Id = 1;
            this.btnGhiGVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiGVDK.ImageOptions.Image")));
            this.btnGhiGVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiGVDK.ImageOptions.LargeImage")));
            this.btnGhiGVDK.Name = "btnGhiGVDK";
            this.btnGhiGVDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiGVDK_ItemClick);
            // 
            // btnPhuchoiGVDK
            // 
            this.btnPhuchoiGVDK.Caption = "Phục hồi";
            this.btnPhuchoiGVDK.Id = 4;
            this.btnPhuchoiGVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhuchoiGVDK.ImageOptions.Image")));
            this.btnPhuchoiGVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhuchoiGVDK.ImageOptions.LargeImage")));
            this.btnPhuchoiGVDK.Name = "btnPhuchoiGVDK";
            this.btnPhuchoiGVDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuchoiGVDK_ItemClick);
            // 
            // btnTaiLaiGVDK
            // 
            this.btnTaiLaiGVDK.Caption = "Tải lại";
            this.btnTaiLaiGVDK.Id = 5;
            this.btnTaiLaiGVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLaiGVDK.ImageOptions.Image")));
            this.btnTaiLaiGVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiLaiGVDK.ImageOptions.LargeImage")));
            this.btnTaiLaiGVDK.Name = "btnTaiLaiGVDK";
            this.btnTaiLaiGVDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiLaiGVDK_ItemClick);
            // 
            // btnThoatGVDK
            // 
            this.btnThoatGVDK.Caption = "Thoát";
            this.btnThoatGVDK.Id = 7;
            this.btnThoatGVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatGVDK.ImageOptions.Image")));
            this.btnThoatGVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoatGVDK.ImageOptions.LargeImage")));
            this.btnThoatGVDK.Name = "btnThoatGVDK";
            this.btnThoatGVDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatGVDK_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(3349, 96);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 2108);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(3349, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(3349, 96);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 2012);
            // 
            // btnInDSGVDK
            // 
            this.btnInDSGVDK.Caption = "In danh sách";
            this.btnInDSGVDK.Id = 6;
            this.btnInDSGVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDSGVDK.ImageOptions.Image")));
            this.btnInDSGVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInDSGVDK.ImageOptions.LargeImage")));
            this.btnInDSGVDK.Name = "btnInDSGVDK";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbCoSo);
            this.groupControl1.Controls.Add(label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 96);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(3349, 156);
            this.groupControl1.TabIndex = 4;
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Location = new System.Drawing.Point(1131, 73);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(651, 41);
            this.cbbCoSo.TabIndex = 6;
            this.cbbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbbCoSo_SelectedIndexChanged);
            // 
            // gcDetail
            // 
            this.gcDetail.Controls.Add(this.cbbTenGV);
            this.gcDetail.Controls.Add(this.cbbLan);
            this.gcDetail.Controls.Add(this.cbbThoiGian);
            this.gcDetail.Controls.Add(this.cbbTenMon);
            this.gcDetail.Controls.Add(this.cbbTenLop);
            this.gcDetail.Controls.Add(label3);
            this.gcDetail.Controls.Add(this.cbbTrinhDo);
            this.gcDetail.Controls.Add(label2);
            this.gcDetail.Controls.Add(tHOIGIANLabel);
            this.gcDetail.Controls.Add(sOCAUTHILabel);
            this.gcDetail.Controls.Add(this.edtSoCau);
            this.gcDetail.Controls.Add(lANLabel);
            this.gcDetail.Controls.Add(nGAYTHILabel);
            this.gcDetail.Controls.Add(this.edtNgayThi);
            this.gcDetail.Controls.Add(tRINHDOLabel);
            this.gcDetail.Controls.Add(this.edtMaLop);
            this.gcDetail.Controls.Add(mAMHLabel);
            this.gcDetail.Controls.Add(this.edtMaMon);
            this.gcDetail.Controls.Add(mAGVLabel);
            this.gcDetail.Controls.Add(this.edtMaGV);
            this.gcDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDetail.Location = new System.Drawing.Point(0, 1566);
            this.gcDetail.Name = "gcDetail";
            this.gcDetail.Size = new System.Drawing.Size(3349, 542);
            this.gcDetail.TabIndex = 5;
            // 
            // cbbTenGV
            // 
            this.cbbTenGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSGiangVien, "TEN", true));
            this.cbbTenGV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsGiangVienDK, "MAGV", true));
            this.cbbTenGV.DataSource = this.bdsDSGiangVien;
            this.cbbTenGV.DisplayMember = "TEN";
            this.cbbTenGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenGV.FormattingEnabled = true;
            this.cbbTenGV.Location = new System.Drawing.Point(382, 129);
            this.cbbTenGV.Name = "cbbTenGV";
            this.cbbTenGV.Size = new System.Drawing.Size(493, 41);
            this.cbbTenGV.TabIndex = 24;
            this.cbbTenGV.ValueMember = "MAGV";
            this.cbbTenGV.SelectedIndexChanged += new System.EventHandler(this.cbbTenGV_SelectedIndexChanged);
            // 
            // bdsDSGiangVien
            // 
            this.bdsDSGiangVien.DataMember = "DSGIAOVIEN";
            this.bdsDSGiangVien.DataSource = this.tNDataSet;
            // 
            // tNDataSet
            // 
            this.tNDataSet.DataSetName = "TNDataSet";
            this.tNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGiangVienDK
            // 
            this.bdsGiangVienDK.DataMember = "GIAOVIEN_DANGKY";
            this.bdsGiangVienDK.DataSource = this.tNDataSet;
            // 
            // cbbLan
            // 
            this.cbbLan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiangVienDK, "LAN", true));
            this.cbbLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLan.FormattingEnabled = true;
            this.cbbLan.Location = new System.Drawing.Point(382, 341);
            this.cbbLan.Name = "cbbLan";
            this.cbbLan.Size = new System.Drawing.Size(250, 41);
            this.cbbLan.TabIndex = 23;
            // 
            // cbbThoiGian
            // 
            this.cbbThoiGian.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiangVienDK, "THOIGIAN", true));
            this.cbbThoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThoiGian.FormattingEnabled = true;
            this.cbbThoiGian.Location = new System.Drawing.Point(2414, 341);
            this.cbbThoiGian.Name = "cbbThoiGian";
            this.cbbThoiGian.Size = new System.Drawing.Size(272, 41);
            this.cbbThoiGian.TabIndex = 22;
            // 
            // cbbTenMon
            // 
            this.cbbTenMon.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsGiangVienDK, "MAMH", true));
            this.cbbTenMon.DataSource = this.bdsDSMH;
            this.cbbTenMon.DisplayMember = "TENMH";
            this.cbbTenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenMon.FormattingEnabled = true;
            this.cbbTenMon.Location = new System.Drawing.Point(1407, 129);
            this.cbbTenMon.Name = "cbbTenMon";
            this.cbbTenMon.Size = new System.Drawing.Size(598, 41);
            this.cbbTenMon.TabIndex = 21;
            this.cbbTenMon.ValueMember = "MAMH";
            this.cbbTenMon.SelectedIndexChanged += new System.EventHandler(this.cbbTenMon_SelectedIndexChanged);
            // 
            // bdsDSMH
            // 
            this.bdsDSMH.DataMember = "DSMONHOC";
            this.bdsDSMH.DataSource = this.tNDataSet;
            // 
            // cbbTenLop
            // 
            this.cbbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsGiangVienDK, "MALOP", true));
            this.cbbTenLop.DataSource = this.bdsDSLop;
            this.cbbTenLop.DisplayMember = "TENLOP";
            this.cbbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenLop.FormattingEnabled = true;
            this.cbbTenLop.Location = new System.Drawing.Point(2414, 129);
            this.cbbTenLop.Name = "cbbTenLop";
            this.cbbTenLop.Size = new System.Drawing.Size(401, 41);
            this.cbbTenLop.TabIndex = 20;
            this.cbbTenLop.ValueMember = "MALOP";
            this.cbbTenLop.SelectedIndexChanged += new System.EventHandler(this.cbbTenLop_SelectedIndexChanged);
            // 
            // bdsDSLop
            // 
            this.bdsDSLop.DataMember = "DSLOP";
            this.bdsDSLop.DataSource = this.tNDataSet;
            // 
            // cbbTrinhDo
            // 
            this.cbbTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiangVienDK, "TRINHDO", true));
            this.cbbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrinhDo.FormattingEnabled = true;
            this.cbbTrinhDo.Location = new System.Drawing.Point(382, 241);
            this.cbbTrinhDo.Name = "cbbTrinhDo";
            this.cbbTrinhDo.Size = new System.Drawing.Size(250, 41);
            this.cbbTrinhDo.TabIndex = 18;
            // 
            // edtSoCau
            // 
            this.edtSoCau.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiangVienDK, "SOCAUTHI", true));
            this.edtSoCau.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edtSoCau.Location = new System.Drawing.Point(1407, 336);
            this.edtSoCau.MenuManager = this.barManager1;
            this.edtSoCau.Name = "edtSoCau";
            this.edtSoCau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtSoCau.Size = new System.Drawing.Size(250, 50);
            this.edtSoCau.TabIndex = 13;
            // 
            // edtNgayThi
            // 
            this.edtNgayThi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiangVienDK, "NGAYTHI", true));
            this.edtNgayThi.EditValue = null;
            this.edtNgayThi.Location = new System.Drawing.Point(1407, 236);
            this.edtNgayThi.MenuManager = this.barManager1;
            this.edtNgayThi.Name = "edtNgayThi";
            this.edtNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtNgayThi.Size = new System.Drawing.Size(598, 50);
            this.edtNgayThi.TabIndex = 9;
            // 
            // edtMaLop
            // 
            this.edtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiangVienDK, "MALOP", true));
            this.edtMaLop.Enabled = false;
            this.edtMaLop.Location = new System.Drawing.Point(2893, 124);
            this.edtMaLop.MenuManager = this.barManager1;
            this.edtMaLop.Name = "edtMaLop";
            this.edtMaLop.Size = new System.Drawing.Size(137, 50);
            this.edtMaLop.TabIndex = 5;
            // 
            // edtMaMon
            // 
            this.edtMaMon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiangVienDK, "MAMH", true));
            this.edtMaMon.Enabled = false;
            this.edtMaMon.Location = new System.Drawing.Point(2049, 125);
            this.edtMaMon.MenuManager = this.barManager1;
            this.edtMaMon.Name = "edtMaMon";
            this.edtMaMon.Size = new System.Drawing.Size(119, 50);
            this.edtMaMon.TabIndex = 3;
            // 
            // edtMaGV
            // 
            this.edtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiangVienDK, "MAGV", true));
            this.edtMaGV.Enabled = false;
            this.edtMaGV.Location = new System.Drawing.Point(936, 125);
            this.edtMaGV.MenuManager = this.barManager1;
            this.edtMaGV.Name = "edtMaGV";
            this.edtMaGV.Size = new System.Drawing.Size(88, 50);
            this.edtMaGV.TabIndex = 1;
            // 
            // tbGiangVienDK
            // 
            this.tbGiangVienDK.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.tbGiangVienDK;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcGVDK
            // 
            this.gcGVDK.DataSource = this.bdsGiangVienDK;
            this.gcGVDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGVDK.Location = new System.Drawing.Point(0, 252);
            this.gcGVDK.MainView = this.gridView1;
            this.gcGVDK.MenuManager = this.barManager1;
            this.gcGVDK.Name = "gcGVDK";
            this.gcGVDK.Size = new System.Drawing.Size(3349, 1314);
            this.gcGVDK.TabIndex = 7;
            this.gcGVDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.GridControl = this.gcGVDK;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 50;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 187;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 50;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 187;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 50;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            this.colMALOP.Width = 187;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 50;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.OptionsColumn.AllowEdit = false;
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            this.colTRINHDO.Width = 187;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.MinWidth = 50;
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.OptionsColumn.AllowEdit = false;
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            this.colNGAYTHI.Width = 187;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 50;
            this.colLAN.Name = "colLAN";
            this.colLAN.OptionsColumn.AllowEdit = false;
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            this.colLAN.Width = 187;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.MinWidth = 50;
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.OptionsColumn.AllowEdit = false;
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            this.colSOCAUTHI.Width = 187;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.MinWidth = 50;
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.OptionsColumn.AllowEdit = false;
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            this.colTHOIGIAN.Width = 187;
            // 
            // tbDSMH
            // 
            this.tbDSMH.ClearBeforeFill = true;
            // 
            // tbDSLopADT
            // 
            this.tbDSLopADT.ClearBeforeFill = true;
            // 
            // tbDSGiangVien
            // 
            this.tbDSGiangVien.ClearBeforeFill = true;
            // 
            // frmGiangVienDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(3349, 2108);
            this.Controls.Add(this.gcGVDK);
            this.Controls.Add(this.gcDetail);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmGiangVienDangKy";
            this.Text = "Form giảng viên đăng ký";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiangVienDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetail)).EndInit();
            this.gcDetail.ResumeLayout(false);
            this.gcDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVienDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSoCau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGVDK)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnThemGVDK;
        private DevExpress.XtraBars.BarButtonItem btnGhiGVDK;
        private DevExpress.XtraBars.BarButtonItem btnXoaGVDK;
        private DevExpress.XtraBars.BarButtonItem btnSuaGVDK;
        private DevExpress.XtraBars.BarButtonItem btnPhuchoiGVDK;
        private DevExpress.XtraBars.BarButtonItem btnTaiLaiGVDK;
        private DevExpress.XtraBars.BarButtonItem btnInDSGVDK;
        private DevExpress.XtraBars.BarButtonItem btnThoatGVDK;
        private System.Windows.Forms.BindingSource bdsGiangVienDK;
        private TNDataSet tNDataSet;
        private DevExpress.XtraEditors.GroupControl gcDetail;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter tbGiangVienDK;
        private TNDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcGVDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit edtNgayThi;
        private DevExpress.XtraEditors.TextEdit edtMaLop;
        private DevExpress.XtraEditors.TextEdit edtMaMon;
        private DevExpress.XtraEditors.TextEdit edtMaGV;
        private DevExpress.XtraEditors.SpinEdit edtSoCau;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.ComboBox cbbTrinhDo;
        private System.Windows.Forms.ComboBox cbbTenMon;
        private System.Windows.Forms.ComboBox cbbTenLop;
        private System.Windows.Forms.BindingSource bdsDSMH;
        private TNDataSetTableAdapters.DSMONHOCTableAdapter tbDSMH;
        private System.Windows.Forms.BindingSource bdsDSLop;
        private TNDataSetTableAdapters.DSLOPTableAdapter tbDSLopADT;
        private System.Windows.Forms.ComboBox cbbThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.ComboBox cbbLan;
        private System.Windows.Forms.BindingSource bdsDSGiangVien;
        private TNDataSetTableAdapters.DSGIAOVIENTableAdapter tbDSGiangVien;
        private System.Windows.Forms.ComboBox cbbTenGV;
    }
}