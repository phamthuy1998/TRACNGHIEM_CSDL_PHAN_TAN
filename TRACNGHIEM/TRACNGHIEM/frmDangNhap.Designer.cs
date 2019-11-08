namespace TRACNGHIEM
{
    partial class frmDangNhap
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCoso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radGiaoVien = new System.Windows.Forms.RadioButton();
            this.radSinhVien = new System.Windows.Forms.RadioButton();
<<<<<<< Updated upstream
=======
            this.dSCS = new TRACNGHIEM.DSCS();
            this.v_DS_COSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_COSOTableAdapter = new TRACNGHIEM.DSCSTableAdapters.V_DS_COSOTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.DSCSTableAdapters.TableAdapterManager();
            this.myLoader1 = new TRACNGHIEM.myLoader();
            ((System.ComponentModel.ISupportInitialize)(this.dSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_COSOBindingSource)).BeginInit();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(983, 812);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(352, 106);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(365, 812);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(352, 106);
            this.btnDangNhap.TabIndex = 18;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 46);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            // 
            // txPassword
            // 
            this.txPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPassword.Location = new System.Drawing.Point(660, 450);
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Size = new System.Drawing.Size(675, 56);
            this.txPassword.TabIndex = 16;
            // 
            // txUsername
            // 
            this.txUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsername.Location = new System.Drawing.Point(660, 300);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(675, 56);
            this.txUsername.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Login";
            // 
            // cbbCoso
            // 
            this.cbbCoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCoso.FormattingEnabled = true;
            this.cbbCoso.Location = new System.Drawing.Point(660, 148);
            this.cbbCoso.Name = "cbbCoso";
            this.cbbCoso.Size = new System.Drawing.Size(675, 59);
            this.cbbCoso.TabIndex = 13;
            this.cbbCoso.SelectedIndexChanged += new System.EventHandler(this.cbbCoso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cơ sở";
            // 
            // radGiaoVien
            // 
            this.radGiaoVien.AutoSize = true;
            this.radGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGiaoVien.Location = new System.Drawing.Point(674, 628);
            this.radGiaoVien.Name = "radGiaoVien";
            this.radGiaoVien.Size = new System.Drawing.Size(246, 50);
            this.radGiaoVien.TabIndex = 20;
            this.radGiaoVien.TabStop = true;
            this.radGiaoVien.Text = "Giảng viên";
            this.radGiaoVien.UseVisualStyleBackColor = true;
            // 
            // radSinhVien
            // 
            this.radSinhVien.AutoSize = true;
            this.radSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSinhVien.Location = new System.Drawing.Point(1115, 628);
            this.radSinhVien.Name = "radSinhVien";
            this.radSinhVien.Size = new System.Drawing.Size(220, 50);
            this.radSinhVien.TabIndex = 21;
            this.radSinhVien.TabStop = true;
            this.radSinhVien.Text = "Sinh viên";
            this.radSinhVien.UseVisualStyleBackColor = true;
            // 
            // myLoader1
            // 
            this.myLoader1.Location = new System.Drawing.Point(808, 258);
            this.myLoader1.Name = "myLoader1";
            this.myLoader1.Size = new System.Drawing.Size(312, 274);
            this.myLoader1.TabIndex = 22;
            this.myLoader1.Visible = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1693, 1066);
            this.Controls.Add(this.myLoader1);
            this.Controls.Add(this.radSinhVien);
            this.Controls.Add(this.radGiaoVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbCoso);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1725, 1154);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCoso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radGiaoVien;
        private System.Windows.Forms.RadioButton radSinhVien;
<<<<<<< Updated upstream
=======
        private DSCS dSCS;
        private System.Windows.Forms.BindingSource v_DS_COSOBindingSource;
        private DSCSTableAdapters.V_DS_COSOTableAdapter v_DS_COSOTableAdapter;
        private DSCSTableAdapters.TableAdapterManager tableAdapterManager;
        private myLoader myLoader1;
>>>>>>> Stashed changes
    }
}