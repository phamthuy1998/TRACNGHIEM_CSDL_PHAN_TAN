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
        private int thoigianThi = 0;
        private int soCauThi = 0;

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
                    Program.myReader.Close();
                    Program.conn.Close();
                    return;
                }
                else
                {
                    Program.myReader.Read();
                    edtMaLop.Text = Program.myReader.GetString(0).Trim();
                    edtTenLop.Text = Program.myReader.GetString(1).Trim();
                    Program.myReader.Close();
                    Program.conn.Close();
                }
            }
        }

        public void loadCauHoi()
        {

            String sql = "";
            if (Program.mGroup.Equals("Sinhvien"))
            {
                sql = "exec SP_BAITHI '"
                    + edtMaLop.Text + "','"
                    + Program.mSV + "','"
                    + cbbTenMon.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedItem.ToString();
            }
            else
            {
                sql = "exec SP_BAITHI '"
                     + edtMaLop.Text + "','"
                    + cbbTenMon.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedItem.ToString();
            }

            DataTable dt = Program.ExecSqlDataTable(sql);
            bdsBaiThi.DataSource = dt;

            CauHoiItem[] listCauHoi = new CauHoiItem[soCauThi];
            for (int i = 0; i < listCauHoi.Length; i++)
            {
               
                listCauHoi[i] = new CauHoiItem();
                listCauHoi[i].Width = scrollCauHoi.Width;

                listCauHoi[i].CauSo = i + 1;
                listCauHoi[i].CauHoi = ((DataRowView)bdsBaiThi[i])["noidung"].ToString();
                listCauHoi[i].CauA = ((DataRowView)bdsBaiThi[i])["a"].ToString();
                listCauHoi[i].CauB = ((DataRowView)bdsBaiThi[i])["b"].ToString();
                listCauHoi[i].CauC = ((DataRowView)bdsBaiThi[i])["c"].ToString();
                listCauHoi[i].CauD = ((DataRowView)bdsBaiThi[i])["d"].ToString();
                listCauHoi[i].CauDapAn = ((DataRowView)bdsBaiThi[i])["dap_an"].ToString();
                if (scrollCauHoi.Controls.Count < 0)
                {
                    scrollCauHoi.Controls.Clear();
                }
                else
                    scrollCauHoi.Controls.Add(listCauHoi[i]);
            }
        }

        private Boolean loadThongTinThi()
        {

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

            try
            {
                Program.myReader = Program.ExecSqlDataReader(sql);
                if (Program.myReader == null)
                {
                    edtTrinhDo.Text = "";
                    edtSoCau.Value = 0;
                    txtThoiGian.Text = "";
                    pnBatdau.Visible = false;
                    Program.conn.Close();
                    return false;
                }
                else
                {
                    Program.myReader.Read();

                    edtTrinhDo.Text = Program.myReader.GetString(0);
                    soCauThi = Program.myReader.GetInt16(1);
                    edtSoCau.Value = soCauThi;
                    thoigianThi = Program.myReader.GetInt16(2);
                    lbTime.Text = thoigianThi + ": 00";
                    txtThoiGian.Text = thoigianThi.ToString();
                    edtNgayThi.DateTime = Program.myReader.GetDateTime(3);
                    Program.myReader.Close();
                    Program.conn.Close();
                    pnBatdau.Visible = true;
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối lấy thông tin thi " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return false;
            }

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

            btnNopBai.Visible = false;
            lbTG.Visible = lbTime.Visible = false;
            dem++;
        }




        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (checkThi == true)
            {
                if (MessageBox.Show("Bạn chưa nộp bài thi, nhấn OK để nộp bài", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    btnNopBai_Click_1(sender, e);
                    if (checkThi == false)
                        this.Close();
                    else
                        return;
                }
            }
            else
            {
                this.Close();
            }


        }

        private void cbbTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaMon.Text = cbbTenMon.SelectedValue.ToString().Trim();
                if (dem > 0)
                    loadThongTinThi();
            }
            catch (Exception ex) { }
        }

        private void cbbLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dem > 0)
                    loadThongTinThi();
            }
            catch (Exception ex) { }
        }

        private void cbbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dem > 0)
                    loadThongTinThi();
            }
            catch (Exception ex) { }
        }

        private void btnBatDau_Click_1(object sender, EventArgs e)
        {
            if (!loadThongTinThi()) return;

            if (Program.mGroup.Equals("Sinhvien"))
            {
                String ktlan = "exec sp_ktlanthi '"
                    + Program.mSV + "', '"
                    + cbbTenMon.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedItem.ToString() + "";

                int kq = Program.ExecSqlNonQuery(ktlan);
                if (kq == 1)
                {
                    return;
                }
            }
            checkThi = true;
            lbTG.Visible = lbTime.Visible = true;
            btnNopBai.Visible = true;
            // load câu hỏi thi
            timer1.Start();
            loadCauHoi();
        }

        private void btnNopBai_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn nộp bài", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                timer1.Stop();
                checkThi = false;
                tinhdiem();

                if (Program.mGroup.Equals("Sinhvien"))
                    insertdiemsv();
                btnNopBai.Enabled = false;
            }

        }

        private void insertdiemsv()
        {
        }

        private void tinhdiem()
        {
        }

        private int s = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            if (s == 0)
            {
                if (thoigianThi != 0)
                {
                    thoigianThi--;
                    s = 59;
                }
            }
            lbTime.Text = thoigianThi.ToString() + " : " + s.ToString();
            if (thoigianThi == 0 && s == 0)
            {
                timer1.Stop();
                checkThi = false;
                MessageBox.Show("Đã hết thời gian thi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tinhdiem();
                if (Program.mGroup.Equals("Sinhvien"))
                {
                    insertdiemsv();
                }
                btnNopBai.Enabled = false;

            }
        }
    }
}
