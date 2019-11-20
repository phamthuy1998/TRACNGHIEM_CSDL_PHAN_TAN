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
    public partial class frmThi : Form
    {
        private int dem = 0;
        public static Boolean checkThi = false;
        public frmThi()
        {
            InitializeComponent();
        }

        private void loadThongTinSInhVien()
        {
            edtHoTenSV.Text = Program.mHoten;
            if (!Program.mSV.Equals(""))
            {
                String ktsocau = "SELECT LOP.MALOP, TENLOP FROM dbo.LOP JOIN dbo.SINHVIEN " +
                    "ON SINHVIEN.MALOP = LOP.MALOP WHERE MASV = '" + Program.mSV + "'";
                Program.myReader = Program.ExecSqlDataReader(ktsocau);
                if (Program.myReader == null)
                {
                    return;
                }
                else
                {
                    Program.myReader.Read();
                    edtMaLop.Text = Program.myReader.GetString(0).Trim();
                    edtTenLop.Text = Program.myReader.GetString(1).Trim();
                }
            }
        }

        private Boolean loadThongTinThi()
        {
            var ngayThi = edtNgayThi.DateTime;
            Console.WriteLine("Ngay thi: " + ngayThi);
            String sql = "";
            if (Program.mGroup.Equals("Sinhvien"))
            {
                sql = "exec sp_thongtinlanthi '"
                    + edtMaLop.Text + "','"
                    + cbbTenMon.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedItem.ToString();
            }
            else
            {
                sql = "exec sp_thongtinlanthi '"
                    + cbbTenLop.SelectedValue.ToString().Trim() + "','"
                    + cbbTenMon.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedItem.ToString();
            }
            Program.myReader.Close();
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return false;
            Program.myReader.Read();

            edtTrinhDo.Text = Program.myReader.GetString(0);
            edtSoCau.Value = Program.myReader.GetInt16(1);
            txtThoiGian.Text = Program.myReader.GetInt16(2).ToString();
            Program.myReader.Close();
            Program.conn.Close();

            return true;
        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            tNDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tNDataSet.DSMONHOC' table. You can move, or remove it, as needed.
            this.tbDSMonHocADT.Connection.ConnectionString = Program.connstr;
            this.tbDSMonHocADT.Fill(this.tNDataSet.DSMONHOC);

            if (bdsDSMonHoc.Count < 0)
            {
                MessageBox.Show("Danh sách môn học rỗng ", "Thông báo", MessageBoxButtons.OK);

            }
            else
            {
                cbbTenMon.SelectedIndex = 0;
                edtMaMon.Text = cbbTenMon.SelectedValue.ToString().Trim();
            }

            this.tbLopADT.Connection.ConnectionString = Program.connstr;
            this.tbLopADT.Fill(this.tNDataSet.DSLOP);

            if (bdsDSLop.Count < 0)
            {
                MessageBox.Show("Danh sách Lớp học rỗng ", "Thông báo", MessageBoxButtons.OK);

            }


            cbbTenLop.SelectedIndex = 0;

            cbbLanThi.Items.Add(1);
            cbbLanThi.Items.Add(2);
            cbbLanThi.SelectedIndex = 0;

            edtNgayThi.DateTime = DateTime.Today;
            if (Program.mGroup.Equals("Sinhvien"))
            {
                loadThongTinSInhVien();
                cbbTenLop.Visible = false;
                edtMaLop.Visible = true;
                lbHoTen.Visible = edtHoTenSV.Visible = lbTenLop.Visible = edtTenLop.Visible = true;
                loadThongTinThi();

            }
            else
            {
                cbbTenLop.Visible = true;
                edtMaLop.Visible = false;
                lbHoTen.Visible = edtHoTenSV.Visible = lbTenLop.Visible = edtTenLop.Visible = false;
                loadThongTinThi();

            }
            dem++;
        }

        public void loadCauHoi()
        {
            int socauhoi = 20;
            CauHoiItem[] listCauHoi = new CauHoiItem[socauhoi];
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                listCauHoi[i] = new CauHoiItem();
                listCauHoi[i].CauSo = i + 1;

                listCauHoi[i].CauHoi = "Thu asjhdhadfyasydyasd ashdg";
                listCauHoi[i].CauA = "ahsgd hashdg ashgdf";
                listCauHoi[i].Width = scrollCauHoi.Width;
                listCauHoi[i].CauB = "nba ashd afg";
                listCauHoi[i].CauC = "hgashd fd";
                listCauHoi[i].CauD = "asdhgd adhg";
                if (scrollCauHoi.Controls.Count < 0)
                {
                    scrollCauHoi.Controls.Clear();
                }
                else
                    scrollCauHoi.Controls.Add(listCauHoi[i]);
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            loadCauHoi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {

        }

        private void cbbTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaMon.Text = cbbTenMon.SelectedValue.ToString().Trim();
                if (dem > 0) loadThongTinThi();
            }
            catch (Exception ex) { }
        }

        private void cbbLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dem > 0) loadThongTinThi();
            }
            catch (Exception) { }
        }
    }
}
