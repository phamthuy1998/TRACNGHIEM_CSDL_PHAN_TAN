using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEM
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txUsername.Text.Trim() == "" || txPassword.Text.Trim() == "")
            {
                MessageBox.Show("Login name và password không được trống", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                myLoader1.Visible = true;
                Program.mlogin = txUsername.Text;
                Program.password = txPassword.Text;

                // Đăng nhập thất bại
                if (Program.KetNoi() == 0) { myLoader1.Visible = false; return; }


<<<<<<< Updated upstream
           // Check giáo viên nhưng lại lấy tài khoản sinh viên đăng nhập
            if (radGiaoVien.Checked)
            {
                if (Program.myReader.GetString(2).Trim().Equals("Sinhvien"))
=======
                Program.mCoSo = cbbCoso.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;

                string strLenh;
                if (radGiaoVien.Checked)
>>>>>>> Stashed changes
                {
                    strLenh = "EXEC SP_LAY_TT_DANGNHAP  '" + Program.mlogin + "'";
                }
                else
                {
                    strLenh = "EXEC SP_LAY_TT_DANGNHAP_SV  '" + Program.mlogin + "'";
                }

                //Thực hiện sp
                Program.myReader = Program.ExecSqlDataReader(strLenh);

                if (Program.myReader == null)
                {
                    myLoader1.Visible = false;
                    return;
                }
                Program.myReader.Read();

<<<<<<< Updated upstream
            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            MessageBox.Show("Nhan vien - Nhom : " + Program.mHoten + " - " + Program.mGroup, "", MessageBoxButtons.OK);

=======
                // Check giáo viên nhưng lại lấy tài khoản sinh viên đăng nhập
                if (radGiaoVien.Checked)
                {
                    if (Program.myReader.GetString(2).Trim().Equals("Sinhvien"))
                    {
                        myLoader1.Visible = false;
                        MessageBox.Show("Bạn đang đăng nhập tài khoản có quyền Sinhvien. \nVui lòng kiểm tra lại.", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                // Check sinh viên nhưng lại lấy Giangvien đăng nhập
                else
                {
                    if (Program.myReader.GetString(2).Trim().Equals("Giangvien"))
                    {
                        myLoader1.Visible = false;
                        MessageBox.Show("Bạn đang đăng nhập tài khoản có quyền của Giangvien." +
                            "\n Vui lòng kiểm tra lại thông tin đăng nhập.", "", MessageBoxButtons.OK);
                        return;
                    }
                }

               
                Program.username = Program.myReader.GetString(0);     // Lay user name
                if (Convert.IsDBNull(Program.username))
                {
                    myLoader1.Visible = false;
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    Program.mHoten = Program.myReader.GetString(1);
                    Program.mGroup = Program.myReader.GetString(2);
                    Program.myReader.Close();
                    Program.conn.Close();

                    if (radSinhVien.Checked)
                    {
                        this.Hide();
                        Program.frmSinhVienMain = new frmSinhVienMain();
                        Program.frmSinhVienMain.Activate();
                        Program.frmSinhVienMain.MASO.Text = "Mã số: " + Program.username;
                        Program.frmSinhVienMain.HOTEN.Text = "Họ tên: " + Program.mHoten;
                        Program.frmSinhVienMain.NHOM.Text = "Nhóm: " + Program.mGroup;
                        Program.frmSinhVienMain.ShowDialog();
                       // this.Close();
                    }
                    else
                    {
                        this.Hide();
                        Program.frmMain = new frmMain();
                        //Program.frmMain.Activate();
                        Program.frmMain.MASO.Text = "Mã số: " + Program.username;
                        Program.frmMain.HOTEN.Text = "Họ tên: " + Program.mHoten;
                        Program.frmMain.NHOM.Text = "Nhóm: " + Program.mGroup;
                        Program.frmMain.ShowDialog();
                       // this.Close();
                    }
                }
            }
>>>>>>> Stashed changes
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            radGiaoVien.Checked = true;
            try
            {
                //Integrated Security=True--> Kết nối về site chủ không cần password và tài khoản
                string chuoiketnoi = "Data Source=THUY;Initial Catalog=TRACNGHIEM;Integrated Security=True";
                Program.conn.ConnectionString = chuoiketnoi;

                // Gọi view V_DS_COSO và trả về datable 
                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_COSO");
                Program.bds_dspm.DataSource = dt;

                // Lấy kết quả đổ vào combobox
                cbbCoso.DataSource = dt;
                cbbCoso.DisplayMember = "TENCS";
                cbbCoso.ValueMember = "TENSERVER";
                cbbCoso.SelectedIndex = 2;
                cbbCoso.SelectedIndex = 1;
                cbbCoso.SelectedIndex = 0;
            }
            catch (Exception a)
            {
                MessageBox.Show("Không thể kết nối tới database! " + a.Message, "", MessageBoxButtons.OK);
            }
        }

        private void cbbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbbCoso.SelectedValue.ToString();
                // txTenServer.Text = Program.servername;
            }
            catch (Exception) { };
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else e.Cancel = true;
        }
    }
}
