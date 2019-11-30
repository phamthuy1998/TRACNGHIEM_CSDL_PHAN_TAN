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
        private Boolean isSinhVien = false;
        private int thoigianThi = 0;
        private int soCauThi = 0;
        public static CauHoiItem[] listCauHoi;
        public static ListViewItem baiThi;
        private float diem = -1;
        private DateTime ngayThi;

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
            if (isSinhVien == true)
            {
                sql = "exec SP_BAITHI '"
                    + edtMaLop.Text + "','"
                    + Program.mSV + "','"
                    + cbbTenMon.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedValue.ToString().Trim();
            }
            else
            {
                sql = "exec SP_ThiThu '"
                     + cbbTenLop.SelectedValue.ToString() + "','"
                    + cbbTenMon.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedValue.ToString().Trim();
            }
            DataTable dt = Program.ExecSqlDataTable(sql);
            if (dt == null)
            {
                MessageBox.Show("Không thể lấy được đề thi ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            bdsBaiThi.DataSource = dt;
            cbbTenLop.Enabled = cbbTenMon.Enabled = cbbLanThi.Enabled = false;
            listCauHoi = new CauHoiItem[soCauThi];
            checkThi = true;
            if (isSinhVien == true)
            {
                for (int i = 0; i < listCauHoi.Length; i++)
                {
                    listCauHoi[i] = new CauHoiItem();
                    listCauHoi[i].Width = scrollCauHoi.Width;

                    listCauHoi[i].CauSo = i + 1;
                    listCauHoi[i].IDBaiThi = (int)((DataRowView)bdsBaiThi[i])["CauHoi"];
                    Console.WriteLine("id cau hoi: " + listCauHoi[i].IDBaiThi);
                    listCauHoi[i].IDDe = (int)((DataRowView)bdsBaiThi[i])["CauSo"];
                    listCauHoi[i].NDCauHoi = ((DataRowView)bdsBaiThi[i])["NoiDung"].ToString();
                    listCauHoi[i].CauA = ((DataRowView)bdsBaiThi[i])["A"].ToString();
                    listCauHoi[i].CauB = ((DataRowView)bdsBaiThi[i])["B"].ToString();
                    listCauHoi[i].CauC = ((DataRowView)bdsBaiThi[i])["C"].ToString();
                    listCauHoi[i].CauD = ((DataRowView)bdsBaiThi[i])["D"].ToString();
                    listCauHoi[i].CauDapAn = ((DataRowView)bdsBaiThi[i])["DapAn"].ToString();
                    listCauHoi[i].MaBangDiem = (int)((DataRowView)bdsBaiThi[i])["MaBD"];
                    listCauHoi[i].CauDaChon = "";

                    String[] arr = new string[2];
                    arr[0] = (i + 1).ToString();
                    arr[1] = listCauHoi[i].CauDaChon;

                    baiThi = new ListViewItem(arr);
                    Console.WriteLine("cau: " + (i + 1) + ":" + listCauHoi[i].CauDapAn);
                    this.summarylistview.Items.Add(baiThi);


                    if (scrollCauHoi.Controls.Count < 0)
                    {
                        scrollCauHoi.Controls.Clear();
                    }
                    else
                        scrollCauHoi.Controls.Add(listCauHoi[i]);
                }
            }
            else
            {
                for (int i = 0; i < listCauHoi.Length; i++)
                {
                    listCauHoi[i] = new CauHoiItem();
                    listCauHoi[i].Width = scrollCauHoi.Width;

                    listCauHoi[i].CauSo = i + 1;
                    listCauHoi[i].NDCauHoi = ((DataRowView)bdsBaiThi[i])["NOIDUNG"].ToString();
                    listCauHoi[i].CauA = ((DataRowView)bdsBaiThi[i])["A"].ToString();
                    listCauHoi[i].CauB = ((DataRowView)bdsBaiThi[i])["B"].ToString();
                    listCauHoi[i].CauC = ((DataRowView)bdsBaiThi[i])["C"].ToString();
                    listCauHoi[i].CauD = ((DataRowView)bdsBaiThi[i])["D"].ToString();
                    listCauHoi[i].CauDapAn = ((DataRowView)bdsBaiThi[i])["DAP_AN"].ToString();
                    listCauHoi[i].CauDaChon = "";

                    String[] arr = new string[2];
                    arr[0] = (i + 1).ToString();
                    arr[1] = listCauHoi[i].CauDaChon;

                    baiThi = new ListViewItem(arr);
                    Console.WriteLine("cau: " + (i + 1) + ":" + listCauHoi[i].CauDapAn);
                    this.summarylistview.Items.Add(baiThi);


                    if (scrollCauHoi.Controls.Count < 0)
                    {
                        scrollCauHoi.Controls.Clear();
                    }
                    else
                        scrollCauHoi.Controls.Add(listCauHoi[i]);
                }
            }
        }

        private Boolean loadThongTinThi()
        {
            pnBatdau.Visible = false;
            String sql = "";
            if (Program.mGroup.Equals("Sinhvien"))
            {
                if (edtMaLop.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã lớp sinh viên rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (cbbTenMon.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Môn học sinh viên rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (cbbLanThi.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Lần thi sinh viên rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                sql = "exec sp_thongtinlanthi N'"
                    + edtMaLop.Text + "', N'"
                    + cbbTenMon.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedValue.ToString().Trim();
            }
            else
            {
                if (cbbTenLop.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Mã lớp thi thử rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (cbbTenMon.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Môn học thi thử rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (cbbLanThi.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Lần thi thi thử rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                sql = "exec sp_thongtinlanthi N'"
                    + cbbTenLop.SelectedValue.ToString().Trim() + "', N'"
                    + cbbTenMon.SelectedValue.ToString() + "', "
                    + cbbLanThi.SelectedValue.ToString();
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
                    edtNgayThi.DateTime = ngayThi = Program.myReader.GetDateTime(3);
                    Program.myReader.Close();
                    Program.conn.Close();
                    pnBatdau.Visible = true;
                    btnBatDau.Visible = true;
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
            // TODO: This line of code loads data into the 'tNDataSet.DSLOPDK' table. You can move, or remove it, as needed.
            pnBatdau.Visible = false;
            if (Program.mGroup.Equals("Sinhvien"))
            {
                isSinhVien = true;
                cbbTenLop.Visible = false;
            }
            else
            {
                isSinhVien = false;
                cbbTenLop.Visible = true;
            }

            this.ControlBox = false;
            tNDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tNDataSet.DSMONHOC' table. You can move, or remove it, as needed.

            this.tbLopDk.Connection.ConnectionString = Program.connstr;
            this.tbLopDk.Fill(this.tNDataSet.DSLOPDK);


            if (bdsLopDK.Count <= 0)
            {
                MessageBox.Show("Danh sách lớp đăng kí rỗng ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (isSinhVien == true)
                    loadThongTinSInhVien();
                cbbTenLop.SelectedIndex = 0;
                this.tbMonHocDk.Connection.ConnectionString = Program.connstr;
                if (isSinhVien)
                    this.tbMonHocDk.Fill(this.tNDataSet.SP_DSMHDK, edtMaLop.Text.Trim());
                else
                    this.tbMonHocDk.Fill(this.tNDataSet.SP_DSMHDK, cbbTenLop.SelectedValue.ToString().Trim());
                if (bds_MonHocDK.Count > 0)
                {
                    cbbTenMon.SelectedIndex = 0;
                    edtMaMon.Text = cbbTenMon.SelectedValue.ToString().Trim();

                    this.tbLanThiThu.Connection.ConnectionString = Program.connstr;
                    this.tbLanThiThu.Fill(this.tNDataSet.SP_DSLanThiThuGV, cbbTenMon.SelectedValue.ToString().Trim(), cbbTenLop.SelectedValue.ToString().Trim());
                    if (bdsLanThiThu.Count <= 0)
                    {
                        MessageBox.Show("Môn học " + cbbTenMon.SelectedValue.ToString() + " không có lần thi", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        cbbLanThi.SelectedIndex = 0;
                        loadThongTinThi();
                    }
                }
                else
                {
                    MessageBox.Show("Không có môn học đăng ký", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

            }


            if (isSinhVien == true)
            {
                edtMaLop.Visible = true;
                lbHoTen.Visible = edtHoTenSV.Visible = lbTenLop.Visible = edtTenLop.Visible = true;
            }
            else
            {
                edtMaLop.Visible = false;
                lbHoTen.Visible = edtHoTenSV.Visible = lbTenLop.Visible = edtTenLop.Visible = false;
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
                if (dem == 0)
                    return;
                edtMaMon.Text = cbbTenMon.SelectedValue.ToString().Trim();
                if (bds_MonHocDK.Count > 0)
                {
                    edtMaMon.Text = cbbTenMon.SelectedValue.ToString().Trim();

                    this.tbLanThiThu.Connection.ConnectionString = Program.connstr;
                    this.tbLanThiThu.Fill(this.tNDataSet.SP_DSLanThiThuGV, cbbTenMon.SelectedValue.ToString().Trim(), cbbTenLop.SelectedValue.ToString().Trim());
                    if (bdsLanThiThu.Count <= 0)
                    {
                        MessageBox.Show("Môn học " + cbbTenMon.SelectedValue.ToString() + " không có lần thi", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        cbbLanThi.SelectedIndex = 0;
                        loadThongTinThi();
                    }
                }
                else
                {
                    MessageBox.Show("Không có môn học đăng ký", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
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

        private void cbbLanThiThu_SelectedIndexChanged(object sender, EventArgs e)
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
                if (dem == 0)
                    return;
                if (isSinhVien == true)
                    loadThongTinSInhVien();

                cbbTenLop.SelectedIndex = 0;
                this.tbMonHocDk.Connection.ConnectionString = Program.connstr;
                if (isSinhVien)
                    this.tbMonHocDk.Fill(this.tNDataSet.SP_DSMHDK, edtMaLop.Text.Trim());
                else
                    this.tbMonHocDk.Fill(this.tNDataSet.SP_DSMHDK, cbbTenLop.SelectedValue.ToString().Trim());
                if (bds_MonHocDK.Count > 0)
                {
                    cbbTenMon.SelectedIndex = 0;
                    edtMaMon.Text = cbbTenMon.SelectedValue.ToString().Trim();

                    this.tbLanThiThu.Connection.ConnectionString = Program.connstr;
                    this.tbLanThiThu.Fill(this.tNDataSet.SP_DSLanThiThuGV, cbbTenMon.SelectedValue.ToString().Trim(), cbbTenLop.SelectedValue.ToString().Trim());
                    if (bdsLanThiThu.Count <= 0)
                    {
                        MessageBox.Show("Môn học " + cbbTenMon.SelectedValue.ToString() + " không có lần thi", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        cbbLanThi.SelectedIndex = 0;
                        loadThongTinThi();
                    }
                }
                else
                {
                    MessageBox.Show("Không có môn học đăng ký", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
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
                    + cbbLanThi.SelectedValue.ToString().Trim();

                int kq = Program.ExecSqlNonQuery(ktlan);
                if (kq == 1)
                {
                    return;
                }
            }
            if (isSinhVien == true)
            {
                DateTime today = DateTime.Today;
                if (today.CompareTo(ngayThi.Date) != 0)
                {
                    Console.WriteLine("Ngay thi : " + ngayThi + " ngay hien tai: " + today);
                    MessageBox.Show("Chưa đến ngày thi", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            lbTG.Visible = lbTime.Visible = true;
            btnBatDau.Visible = false;
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

                btnNopBai.Visible = false;
                btnBatDau.Visible = btnBatDau.Enabled = true;
                summarylistview.Items.Clear();
                scrollCauHoi.Controls.Clear();
                cbbTenLop.Enabled = cbbLanThi.Enabled = cbbTenMon.Enabled = true;
            }
        }

        private void insertdiemsv()
        {
            String sql = "UPDATE dbo.BANGDIEM SET DIEM = " + diem +
                "WHERE MASV = '" + Program.mSV
                + "' AND MAMH = '" + cbbTenMon.SelectedValue.ToString().Trim()
                + "' AND LAN = " + cbbLanThi.SelectedValue.ToString().Trim();

            try
            {
                int kq = Program.ExecSqlNonQuery(sql);
                ghiDapAn();
                //if (kq == 1)
                //{
                //    ghiDapAn();
                //}
                //else
                //{
                //    MessageBox.Show("Lỗi ghi điểm thi", "", MessageBoxButtons.OK);
                //    return;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi điểm thi " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void ghiDapAn()
        {
            string sqlUpdate = "";
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                sqlUpdate += " UPDATE dbo.BAITHI SET DaChon = '"
                   + listCauHoi[i].CauDaChon
                   + "' WHERE CauHoi = " + listCauHoi[i].IDBaiThi + "  ";
                Console.WriteLine("id cau hoi ghi:  " + listCauHoi[i].IDBaiThi + " da chon:" + listCauHoi[i].CauDaChon);
            }

            Console.WriteLine("câu lệnh: " + sqlUpdate);

            try
            {
                int kq = Program.ExecSqlNonQuery(sqlUpdate);
                //if (kq != 0)
                //{
                //    MessageBox.Show("Ghi kết quả thành công ", "Thông báo", MessageBoxButtons.OK);
                //    return;
                //}
                //else
                //{
                //    MessageBox.Show("Lỗi ghi đáp án thi", "", MessageBoxButtons.OK);
                //    return;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đáp án thi " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void tinhdiem()
        {
            int caudung = 0;
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                if (listCauHoi[i].CauDaChon.Trim().CompareTo(listCauHoi[i].CauDapAn.Trim()) == 0)
                    caudung++;

            }

            if (caudung == 0) diem = 0;

            else diem = (float)Math.Round((double)(10 * caudung) / soCauThi, 2);
            MessageBox.Show("Số câu đúng: " + caudung + "/" + soCauThi + "\nĐiểm: " + diem, "Kết Quả", MessageBoxButtons.OK);
            btnNopBai.Visible = false;
            btnBatDau.Visible = true;
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
                cbbTenLop.Enabled = cbbTenMon.Enabled = cbbLanThi.Enabled = true;
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

        public void capNhapDaChon(int cauSo, String daChon)
        {
            String[] arr = new string[2];
            arr[0] = (cauSo).ToString();
            arr[1] = daChon;
            ListViewItem baiThi = new ListViewItem(arr);
            summarylistview.Items[cauSo - 1] = baiThi;
        }

        private void summarylistview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bdsLopDK.Count < 0 && isSinhVien == false)
                {
                    MessageBox.Show("Danh sách lớp đăng kí rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if (isSinhVien)
                        this.tbMonHocDk.Fill(this.tNDataSet.SP_DSMHDK, edtMaLop.Text.Trim());
                    else
                        this.tbMonHocDk.Fill(this.tNDataSet.SP_DSMHDK, cbbTenLop.SelectedValue.ToString().Trim());

                    if (bds_MonHocDK.Count > 0)
                    {
                        loadThongTinThi();
                    }
                    else
                    {
                        MessageBox.Show("Không có môn học đăng ký", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (bds_MonHocDK.Count > 0)
                {
                    cbbTenMon.SelectedIndex = 0;
                    edtMaMon.Text = cbbTenMon.SelectedValue.ToString().Trim();

                    this.tbLanThiThu.Connection.ConnectionString = Program.connstr;
                    this.tbLanThiThu.Fill(this.tNDataSet.SP_DSLanThiThuGV, cbbTenMon.SelectedValue.ToString().Trim(), cbbTenLop.SelectedValue.ToString().Trim());
                    if (bdsLanThiThu.Count <= 0)
                    {
                        MessageBox.Show("Môn học " + cbbTenMon.SelectedValue.ToString() + " không có lần thi", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        cbbLanThi.SelectedIndex = 0;
                        loadThongTinThi();
                    }
                }
                else
                {
                    MessageBox.Show("Không có môn học đăng ký", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}
