using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TRACNGHIEM
{

    public partial class frmDangKy : Form
    {
        public static Boolean checkSave = true;
        private Boolean checkThem = false;
        private int dem = 0;

        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (edtTenDN.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "", MessageBoxButtons.OK);
                edtTenDN.Focus();
                return;
            }
            if (edtPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "", MessageBoxButtons.OK);
                edtPass.Focus();
                return;
            }
            SqlCommand sqlcmd;
            //neu dăng nhập với quyền co so
            if (Program.mGroup.Equals("Coso"))
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                sqlcmd = Program.conn.CreateCommand();
            }
            else
            {
                if (cbbCoSo.SelectedIndex != Program.mCoSo)
                {
                    Program.servername1 = cbbCoSo.SelectedValue.ToString();

                    if (Program.KetNoiCosoKhac() == 0) return;
                    else
                    {
                        this.tb_SP_GVChuaCoTk.Connection.ConnectionString = Program.connstr1;
                        this.tb_SP_GVChuaCoTk.Fill(this.TNDataSet.SP_MA_GV_CHUA_TAO_TK);
                        sqlcmd = Program.conn1.CreateCommand();
                    }
                }
                else
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    sqlcmd = Program.conn.CreateCommand();
                }
            }


            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_TaoTaiKhoan";
            sqlcmd.Parameters.Add(new SqlParameter("@LGNAME", edtTenDN.Text.Trim()));
            sqlcmd.Parameters.Add(new SqlParameter("@PASS", edtPass.Text.Trim()));
            sqlcmd.Parameters.Add(new SqlParameter("@USERNAME", cbbMaGV.SelectedValue.ToString().Trim()));
            sqlcmd.Parameters.Add(new SqlParameter("@ROLE", cbbLoaiTK.SelectedItem.ToString().Trim()));
            SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
            sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
            sqlcmd.Parameters.Add(sqlParameter);


            int result = -1;
            try
            {
                sqlcmd.ExecuteNonQuery();
                result = (int)sqlcmd.Parameters["@return"].Value;
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show("Lỗi tạo tài khoản " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (result != -1)
            {
                if (result == 1)
                {
                    Program.conn.Close();
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    edtTenDN.Focus();
                    return;
                }
                if (result == 2)
                {
                    Program.conn.Close();
                    MessageBox.Show("Mã giảng viên đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                    cbbMaGV.Focus();
                    return;
                }
                //tao tk thành công
                if (result == 0)
                {
                    Program.conn.Close();
                    MessageBox.Show("Tạo tài khoản thành công", "Thành công", MessageBoxButtons.OK);
                    edtPass.Text = "";
                    edtTenDN.Text = "";
                    this.tb_SP_GVChuaCoTk.Connection.ConnectionString = Program.connstr1;
                    this.tb_SP_GVChuaCoTk.Fill(this.TNDataSet.SP_MA_GV_CHUA_TAO_TK);
                    return;
                }
                else
                {
                    Program.conn.Close();
                    MessageBox.Show("Tạo tài khoản thất bại", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại", "Lỗi", MessageBoxButtons.OK);
                return;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo tài khoản, bạn có muốn lưu thông tin này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnDangKy_Click(sender, e);
                    if (checkSave == true)
                        this.Close();
                    else
                        return;
                }
                else
                {
                    checkSave = true;
                    Close();
                }
            }
            else
            {
                checkSave = true;
                this.Close();
            }
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            Program.connstr1 = Program.connstr;
            TNDataSet.EnforceConstraints = false;

            try
            {
                cbbCoSo.DataSource = Program.bds_dspm.DataSource;
                cbbCoSo.DisplayMember = "TENCS";
                cbbCoSo.ValueMember = "TENSERVER";
                cbbCoSo.SelectedIndex = Program.mCoSo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load cơ sở " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }

            this.tb_SP_GVChuaCoTk.Connection.ConnectionString = Program.connstr;
            this.tb_SP_GVChuaCoTk.Fill(this.TNDataSet.SP_MA_GV_CHUA_TAO_TK);



            // phân quyền
            if (Program.mGroup == "Coso")
            {
                cbbCoSo.Enabled = false;
                cbbLoaiTK.Items.Add("Coso");
                cbbLoaiTK.Items.Add("Giangvien");
            }
            else if (Program.mGroup == "Truong")
            {
                cbbCoSo.Enabled = true;
                cbbLoaiTK.Items.Add("Truong");
            }

            cbbLoaiTK.SelectedIndex = 0;
            dem++;
        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbCoSo.SelectedValue != null && Program.mGroup.Equals("Truong") && dem > 0)
                {
                    if (cbbCoSo.SelectedIndex != Program.mCoSo)
                    {
                        Program.servername1 = cbbCoSo.SelectedValue.ToString();
                        if (Program.KetNoiCosoKhac() == 0) return;
                        else
                        {
                            this.tb_SP_GVChuaCoTk.Connection.ConnectionString = Program.connstr1;
                            this.tb_SP_GVChuaCoTk.Fill(this.TNDataSet.SP_MA_GV_CHUA_TAO_TK);
                        }
                    }
                    else
                    {
                        this.tb_SP_GVChuaCoTk.Connection.ConnectionString = Program.connstr;
                        this.tb_SP_GVChuaCoTk.Fill(this.TNDataSet.SP_MA_GV_CHUA_TAO_TK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn cơ sở " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            };
        }

    }
}
