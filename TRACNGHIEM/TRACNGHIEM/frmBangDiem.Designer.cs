namespace TRACNGHIEM
{
    partial class frmBangDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangDiem));
            this.dSLOPDK = new System.Windows.Forms.BindingSource(this.components);
            this.tNDataSet = new TRACNGHIEM.TNDataSet();
            this.sP_DSLanThiDK = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DSMHDK = new System.Windows.Forms.BindingSource(this.components);
            this.bdsBangDiem = new System.Windows.Forms.BindingSource(this.components);
            this.tbBangDiem = new TRACNGHIEM.TNDataSetTableAdapters.BANGDIEMTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnInDSBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatBDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bANGDIEMGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_XemKetQuaSV = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEMCHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dSLOPDKTableAdapter = new TRACNGHIEM.TNDataSetTableAdapters.DSLOPDKTableAdapter();
            this.sP_DSMHDKTableAdapter = new TRACNGHIEM.TNDataSetTableAdapters.SP_DSMHDKTableAdapter();
            this.sP_DSLanThiDKTableAdapter = new TRACNGHIEM.TNDataSetTableAdapters.SP_DSLanThiDKTableAdapter();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMH = new System.Windows.Forms.ComboBox();
            this.cbbLThi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sP_XemKetQuaSVTableAdapter = new TRACNGHIEM.TNDataSetTableAdapters.SP_XemKetQuaSVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSLOPDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSLanThiDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSMHDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_XemKetQuaSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSLOPDK
            // 
            this.dSLOPDK.DataMember = "DSLOPDK";
            this.dSLOPDK.DataSource = this.tNDataSet;
            // 
            // tNDataSet
            // 
            this.tNDataSet.DataSetName = "TNDataSet";
            this.tNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_DSLanThiDK
            // 
            this.sP_DSLanThiDK.DataMember = "SP_DSLanThiDK";
            this.sP_DSLanThiDK.DataSource = this.tNDataSet;
            // 
            // sP_DSMHDK
            // 
            this.sP_DSMHDK.DataMember = "SP_DSMHDK";
            this.sP_DSMHDK.DataSource = this.tNDataSet;
            // 
            // bdsBangDiem
            // 
            this.bdsBangDiem.DataMember = "BANGDIEM";
            this.bdsBangDiem.DataSource = this.tNDataSet;
            // 
            // tbBangDiem
            // 
            this.tbBangDiem.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.tbBangDiem;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.btnInDSBD,
            this.btnThoatBDiem});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatBDiem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnInDSBD
            // 
            this.btnInDSBD.Caption = "In danh sách";
            this.btnInDSBD.Id = 0;
            this.btnInDSBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDSBD.ImageOptions.Image")));
            this.btnInDSBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInDSBD.ImageOptions.LargeImage")));
            this.btnInDSBD.Name = "btnInDSBD";
            this.btnInDSBD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDSBD_ItemClick);
            // 
            // btnThoatBDiem
            // 
            this.btnThoatBDiem.Caption = "Thoát";
            this.btnThoatBDiem.Id = 1;
            this.btnThoatBDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatBDiem.ImageOptions.Image")));
            this.btnThoatBDiem.Name = "btnThoatBDiem";
            this.btnThoatBDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatBDiem_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(3844, 96);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 2108);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(3844, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 96);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 2012);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(3844, 96);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 2012);
            // 
            // bANGDIEMGridControl
            // 
            this.bANGDIEMGridControl.DataSource = this.sP_XemKetQuaSV;
            this.bANGDIEMGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bANGDIEMGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.bANGDIEMGridControl.Location = new System.Drawing.Point(0, 309);
            this.bANGDIEMGridControl.MainView = this.gridView1;
            this.bANGDIEMGridControl.Margin = new System.Windows.Forms.Padding(275, 0, 275, 271);
            this.bANGDIEMGridControl.MenuManager = this.barManager1;
            this.bANGDIEMGridControl.Name = "bANGDIEMGridControl";
            this.bANGDIEMGridControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bANGDIEMGridControl.Size = new System.Drawing.Size(3844, 1799);
            this.bANGDIEMGridControl.TabIndex = 13;
            this.bANGDIEMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_XemKetQuaSV
            // 
            this.sP_XemKetQuaSV.DataMember = "SP_XemKetQuaSV";
            this.sP_XemKetQuaSV.DataSource = this.tNDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colDIEM,
            this.colDIEMCHU});
            this.gridView1.DetailHeight = 474;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.bANGDIEMGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.MinWidth = 25;
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 3;
            this.colDIEM.Width = 94;
            // 
            // colDIEMCHU
            // 
            this.colDIEMCHU.FieldName = "DIEMCHU";
            this.colDIEMCHU.MinWidth = 25;
            this.colDIEMCHU.Name = "colDIEMCHU";
            this.colDIEMCHU.Visible = true;
            this.colDIEMCHU.VisibleIndex = 4;
            this.colDIEMCHU.Width = 94;
            // 
            // dSLOPDKTableAdapter
            // 
            this.dSLOPDKTableAdapter.ClearBeforeFill = true;
            // 
            // sP_DSMHDKTableAdapter
            // 
            this.sP_DSMHDKTableAdapter.ClearBeforeFill = true;
            // 
            // sP_DSLanThiDKTableAdapter
            // 
            this.sP_DSLanThiDKTableAdapter.ClearBeforeFill = true;
            // 
            // cbbLop
            // 
            this.cbbLop.DataSource = this.dSLOPDK;
            this.cbbLop.DisplayMember = "TENLOP";
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(472, 78);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(240, 41);
            this.cbbLop.TabIndex = 1;
            this.cbbLop.ValueMember = "MALOP";
            this.cbbLop.SelectedIndexChanged += new System.EventHandler(this.cbbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp";
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Location = new System.Drawing.Point(3906, 169);
            this.cbbLanThi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLanThi.Name = "cbbLanThi";
            this.cbbLanThi.Size = new System.Drawing.Size(238, 41);
            this.cbbLanThi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(793, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 41);
            this.label5.TabIndex = 8;
            this.label5.Text = "Môn học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1221, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 41);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lần thi";
            // 
            // cbbMH
            // 
            this.cbbMH.DataSource = this.sP_DSMHDK;
            this.cbbMH.DisplayMember = "TENMH";
            this.cbbMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMH.FormattingEnabled = true;
            this.cbbMH.Location = new System.Drawing.Point(884, 75);
            this.cbbMH.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMH.Name = "cbbMH";
            this.cbbMH.Size = new System.Drawing.Size(240, 41);
            this.cbbMH.TabIndex = 10;
            this.cbbMH.ValueMember = "MAMH";
            this.cbbMH.SelectedIndexChanged += new System.EventHandler(this.cbbMH_SelectedIndexChanged);
            // 
            // cbbLThi
            // 
            this.cbbLThi.DataSource = this.sP_DSLanThiDK;
            this.cbbLThi.DisplayMember = "LAN";
            this.cbbLThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLThi.FormattingEnabled = true;
            this.cbbLThi.Location = new System.Drawing.Point(1298, 77);
            this.cbbLThi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLThi.Name = "cbbLThi";
            this.cbbLThi.Size = new System.Drawing.Size(133, 41);
            this.cbbLThi.TabIndex = 11;
            this.cbbLThi.ValueMember = "LAN";
            this.cbbLThi.SelectedIndexChanged += new System.EventHandler(this.cbbLThi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 41);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cơ sở";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Location = new System.Drawing.Point(95, 75);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(221, 41);
            this.cbbCoSo.TabIndex = 14;
            this.cbbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbbCoSo_SelectedIndexChanged_1);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbCoSo);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cbbLThi);
            this.groupControl1.Controls.Add(this.cbbMH);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cbbLanThi);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cbbLop);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 96);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(3844, 213);
            this.groupControl1.TabIndex = 8;
            // 
            // sP_XemKetQuaSVTableAdapter
            // 
            this.sP_XemKetQuaSVTableAdapter.ClearBeforeFill = true;
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(3844, 2108);
            this.Controls.Add(this.bANGDIEMGridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangDiem";
            this.Text = "Form bảng điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSLOPDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSLanThiDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSMHDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_XemKetQuaSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TNDataSet tNDataSet;
        private System.Windows.Forms.BindingSource bdsBangDiem;
        private TNDataSetTableAdapters.BANGDIEMTableAdapter tbBangDiem;
        private TNDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnInDSBD;
        private DevExpress.XtraBars.BarButtonItem btnThoatBDiem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl bANGDIEMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dSLOPDK;
        private TNDataSetTableAdapters.DSLOPDKTableAdapter dSLOPDKTableAdapter;
        private System.Windows.Forms.BindingSource sP_DSMHDK;
        private TNDataSetTableAdapters.SP_DSMHDKTableAdapter sP_DSMHDKTableAdapter;
        private System.Windows.Forms.BindingSource sP_DSLanThiDK;
        private TNDataSetTableAdapters.SP_DSLanThiDKTableAdapter sP_DSLanThiDKTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLThi;
        private System.Windows.Forms.ComboBox cbbMH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbLanThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.BindingSource sP_XemKetQuaSV;
        private TNDataSetTableAdapters.SP_XemKetQuaSVTableAdapter sP_XemKetQuaSVTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEMCHU;
    }
}