﻿namespace TRACNGHIEM
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.cbbTenLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTenMonhoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tNDataSet = new TRACNGHIEM.TNDataSet();
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Location = new System.Drawing.Point(141, 74);
            this.cbbCoSo.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(304, 24);
            this.cbbCoSo.TabIndex = 1;
            this.cbbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbbCoSo_SelectedIndexChanged);
            // 
            // cbbTenLop
            // 
            this.cbbTenLop.FormattingEnabled = true;
            this.cbbTenLop.Location = new System.Drawing.Point(617, 74);
            this.cbbTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenLop.Name = "cbbTenLop";
            this.cbbTenLop.Size = new System.Drawing.Size(298, 24);
            this.cbbTenLop.TabIndex = 3;
            this.cbbTenLop.SelectedIndexChanged += new System.EventHandler(this.cbbTenLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Môn học";
            // 
            // cbbTenMonhoc
            // 
            this.cbbTenMonhoc.FormattingEnabled = true;
            this.cbbTenMonhoc.Location = new System.Drawing.Point(2736, 134);
            this.cbbTenMonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenMonhoc.Name = "cbbTenMonhoc";
            this.cbbTenMonhoc.Size = new System.Drawing.Size(616, 24);
            this.cbbTenMonhoc.TabIndex = 5;
            this.cbbTenMonhoc.SelectedIndexChanged += new System.EventHandler(this.cbbTenMonhoc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2442, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên mô học";
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Location = new System.Drawing.Point(3906, 169);
            this.cbbLanThi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLanThi.Name = "cbbLanThi";
            this.cbbLanThi.Size = new System.Drawing.Size(238, 24);
            this.cbbLanThi.TabIndex = 7;
            this.cbbLanThi.SelectedIndexChanged += new System.EventHandler(this.cbbLanThi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3692, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lần thi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBox1);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cbbTenLop);
            this.groupControl1.Controls.Add(this.cbbLanThi);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.cbbCoSo);
            this.groupControl1.Controls.Add(this.cbbTenMonhoc);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1327, 187);
            this.groupControl1.TabIndex = 8;
            // 
            // tNDataSet
            // 
            this.tNDataSet.DataSetName = "TNDataSet";
            this.tNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnThoatBDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoatBDiem.ImageOptions.LargeImage")));
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
            this.barDockControlTop.Size = new System.Drawing.Size(1327, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1055);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1005);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1327, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1005);
            // 
            // bANGDIEMGridControl
            // 
            this.bANGDIEMGridControl.DataSource = this.bdsBangDiem;
            this.bANGDIEMGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bANGDIEMGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.bANGDIEMGridControl.Location = new System.Drawing.Point(0, 237);
            this.bANGDIEMGridControl.MainView = this.gridView1;
            this.bANGDIEMGridControl.Margin = new System.Windows.Forms.Padding(275, 0, 275, 271);
            this.bANGDIEMGridControl.MenuManager = this.barManager1;
            this.bANGDIEMGridControl.Name = "bANGDIEMGridControl";
            this.bANGDIEMGridControl.Size = new System.Drawing.Size(1327, 818);
            this.bANGDIEMGridControl.TabIndex = 13;
            this.bANGDIEMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 474;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.bANGDIEMGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(992, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lần thi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1068, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 1055);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBangDiem_FormClosing);
            this.Load += new System.EventHandler(this.frmBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.ComboBox cbbTenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTenMonhoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLanThi;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}