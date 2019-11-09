namespace TRACNGHIEM
{
    partial class frmGiangVien
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label hOCVILabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.TNDataSet = new TRACNGHIEM.TNDataSet();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.tbGiaoVien = new TRACNGHIEM.TNDataSetTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager1 = new TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.edtHocViGv = new DevExpress.XtraEditors.TextEdit();
            this.edtDiaChiGV = new DevExpress.XtraEditors.TextEdit();
            this.edtTenGV = new DevExpress.XtraEditors.TextEdit();
            this.edtHoGv = new DevExpress.XtraEditors.TextEdit();
            this.cbbMaKhoa = new System.Windows.Forms.ComboBox();
            this.edtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.bdsBoDeGV = new System.Windows.Forms.BindingSource(this.components);
            this.tbBoDe = new TRACNGHIEM.TNDataSetTableAdapters.BODETableAdapter();
            this.bdsGVDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.tb_GiaoVienDKi = new TRACNGHIEM.TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbCoSoGV = new System.Windows.Forms.ComboBox();
            this.bdsCoSo = new System.Windows.Forms.BindingSource(this.components);
            this.cbbKhoa = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tbCoSo = new TRACNGHIEM.TNDataSetTableAdapters.COSOTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gIAOVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            mAGVLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            hOCVILabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtHocViGv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDiaChiGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHoGv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDeGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCoSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(147, 148);
            mAGVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(97, 34);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã GV";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(1104, 148);
            mAKHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(121, 34);
            mAKHLabel.TabIndex = 2;
            mAKHLabel.Text = "Mã khoa";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(147, 358);
            hOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(49, 34);
            hOLabel.TabIndex = 4;
            hOLabel.Text = "Họ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(1104, 358);
            tENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(62, 34);
            tENLabel.TabIndex = 6;
            tENLabel.Text = "Tên";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(147, 564);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(117, 34);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // hOCVILabel
            // 
            hOCVILabel.AutoSize = true;
            hOCVILabel.Location = new System.Drawing.Point(2318, 153);
            hOCVILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOCVILabel.Name = "hOCVILabel";
            hOCVILabel.Size = new System.Drawing.Size(91, 34);
            hOCVILabel.TabIndex = 10;
            hOCVILabel.Text = "Học vị";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1104, 133);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 34);
            label1.TabIndex = 12;
            label1.Text = "Khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(147, 122);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 34);
            label2.TabIndex = 13;
            label2.Text = "Cơ sở";
            // 
            // TNDataSet
            // 
            this.TNDataSet.DataSetName = "TNDataSet";
            this.TNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "GIAOVIEN";
            this.bdsGV.DataSource = this.TNDataSet;
            // 
            // tbGiaoVien
            // 
            this.tbGiaoVien.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BAITHITableAdapter = null;
            this.tableAdapterManager1.BANGDIEMTableAdapter = null;
            this.tableAdapterManager1.BODETableAdapter = null;
            this.tableAdapterManager1.COSOTableAdapter = null;
            this.tableAdapterManager1.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager1.GIAOVIENTableAdapter = this.tbGiaoVien;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TRACNGHIEM.TNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(hOCVILabel);
            this.groupControl.Controls.Add(this.edtHocViGv);
            this.groupControl.Controls.Add(dIACHILabel);
            this.groupControl.Controls.Add(this.edtDiaChiGV);
            this.groupControl.Controls.Add(tENLabel);
            this.groupControl.Controls.Add(this.edtTenGV);
            this.groupControl.Controls.Add(hOLabel);
            this.groupControl.Controls.Add(this.edtHoGv);
            this.groupControl.Controls.Add(mAKHLabel);
            this.groupControl.Controls.Add(this.cbbMaKhoa);
            this.groupControl.Controls.Add(mAGVLabel);
            this.groupControl.Controls.Add(this.edtMaGV);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl.Location = new System.Drawing.Point(0, 1333);
            this.groupControl.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(3526, 709);
            this.groupControl.TabIndex = 39;
            // 
            // edtHocViGv
            // 
            this.edtHocViGv.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HOCVI", true));
            this.edtHocViGv.Location = new System.Drawing.Point(2570, 137);
            this.edtHocViGv.Margin = new System.Windows.Forms.Padding(4);
            this.edtHocViGv.Name = "edtHocViGv";
            this.edtHocViGv.Size = new System.Drawing.Size(527, 50);
            this.edtHocViGv.TabIndex = 11;
            // 
            // edtDiaChiGV
            // 
            this.edtDiaChiGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "DIACHI", true));
            this.edtDiaChiGV.Location = new System.Drawing.Point(371, 554);
            this.edtDiaChiGV.Margin = new System.Windows.Forms.Padding(4);
            this.edtDiaChiGV.Name = "edtDiaChiGV";
            this.edtDiaChiGV.Size = new System.Drawing.Size(1475, 50);
            this.edtDiaChiGV.TabIndex = 9;
            // 
            // edtTenGV
            // 
            this.edtTenGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "TEN", true));
            this.edtTenGV.Location = new System.Drawing.Point(1343, 354);
            this.edtTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.edtTenGV.Name = "edtTenGV";
            this.edtTenGV.Size = new System.Drawing.Size(503, 50);
            this.edtTenGV.TabIndex = 7;
            // 
            // edtHoGv
            // 
            this.edtHoGv.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HO", true));
            this.edtHoGv.Location = new System.Drawing.Point(371, 354);
            this.edtHoGv.Margin = new System.Windows.Forms.Padding(4);
            this.edtHoGv.Name = "edtHoGv";
            this.edtHoGv.Size = new System.Drawing.Size(525, 50);
            this.edtHoGv.TabIndex = 5;
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAKH", true));
            this.cbbMaKhoa.Enabled = false;
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Location = new System.Drawing.Point(1343, 144);
            this.cbbMaKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(503, 41);
            this.cbbMaKhoa.TabIndex = 3;
            // 
            // edtMaGV
            // 
            this.edtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "MAGV", true));
            this.edtMaGV.Location = new System.Drawing.Point(371, 142);
            this.edtMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.edtMaGV.Name = "edtMaGV";
            this.edtMaGV.Size = new System.Drawing.Size(525, 50);
            this.edtMaGV.TabIndex = 1;
            // 
            // bdsBoDeGV
            // 
            this.bdsBoDeGV.DataMember = "FK_BODE_GIAOVIEN";
            this.bdsBoDeGV.DataSource = this.bdsGV;
            // 
            // tbBoDe
            // 
            this.tbBoDe.ClearBeforeFill = true;
            // 
            // bdsGVDangKy
            // 
            this.bdsGVDangKy.DataMember = "FK_GIAOVIEN_DANGKY_GIAOVIEN1";
            this.bdsGVDangKy.DataSource = this.bdsGV;
            // 
            // tb_GiaoVienDKi
            // 
            this.tb_GiaoVienDKi.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbCoSoGV);
            this.groupControl1.Controls.Add(label2);
            this.groupControl1.Controls.Add(label1);
            this.groupControl1.Controls.Add(this.cbbKhoa);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(3526, 243);
            this.groupControl1.TabIndex = 57;
            // 
            // cbbCoSoGV
            // 
            this.cbbCoSoGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCoSo, "MACS", true));
            this.cbbCoSoGV.FormattingEnabled = true;
            this.cbbCoSoGV.Location = new System.Drawing.Point(371, 129);
            this.cbbCoSoGV.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCoSoGV.Name = "cbbCoSoGV";
            this.cbbCoSoGV.Size = new System.Drawing.Size(535, 41);
            this.cbbCoSoGV.TabIndex = 15;
            // 
            // bdsCoSo
            // 
            this.bdsCoSo.DataMember = "COSO";
            this.bdsCoSo.DataSource = this.TNDataSet;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.Location = new System.Drawing.Point(1343, 122);
            this.cbbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbKhoa.Size = new System.Drawing.Size(505, 50);
            this.cbbKhoa.TabIndex = 1;
            // 
            // tbCoSo
            // 
            this.tbCoSo.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gIAOVIENGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 243);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(3526, 1090);
            this.groupControl2.TabIndex = 74;
            this.groupControl2.Text = "groupControl2";
            // 
            // gIAOVIENGridControl
            // 
            this.gIAOVIENGridControl.DataSource = this.bdsGV;
            this.gIAOVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gIAOVIENGridControl.Location = new System.Drawing.Point(3, 48);
            this.gIAOVIENGridControl.MainView = this.gridView1;
            this.gIAOVIENGridControl.Name = "gIAOVIENGridControl";
            this.gIAOVIENGridControl.Size = new System.Drawing.Size(3520, 1039);
            this.gIAOVIENGridControl.TabIndex = 0;
            this.gIAOVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gIAOVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3526, 2042);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiangVien";
            this.Text = "Form Giảng viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiangVien_FormClosing);
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtHocViGv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDiaChiGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHoGv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDeGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCoSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TNDataSet TNDataSet;
        private System.Windows.Forms.BindingSource bdsGV;
        private TNDataSetTableAdapters.GIAOVIENTableAdapter tbGiaoVien;
        private TNDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.TextEdit edtHocViGv;
        private DevExpress.XtraEditors.TextEdit edtDiaChiGV;
        private DevExpress.XtraEditors.TextEdit edtTenGV;
        private DevExpress.XtraEditors.TextEdit edtHoGv;
        private System.Windows.Forms.ComboBox cbbMaKhoa;
        private DevExpress.XtraEditors.TextEdit edtMaGV;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource bdsBoDeGV;
        private TNDataSetTableAdapters.BODETableAdapter tbBoDe;
        private System.Windows.Forms.BindingSource bdsGVDangKy;
        private TNDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter tb_GiaoVienDKi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbbKhoa;
        private System.Windows.Forms.BindingSource bdsCoSo;
        private TNDataSetTableAdapters.COSOTableAdapter tbCoSo;
        private System.Windows.Forms.ComboBox cbbCoSoGV;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gIAOVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}