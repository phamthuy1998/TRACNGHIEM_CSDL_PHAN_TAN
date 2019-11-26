using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
namespace TRACNGHIEM
{
    public partial class frmKQThi : Form
    {
        private int dem = 0;
        private String tenLop = null;
        private String ngayThi = null;
        public frmKQThi()
        {
            InitializeComponent();
        }

        private void bAITHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void frmKQThi_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            // TODO: This line of code loads data into the 'tNDataSet.BAITHI' table. You can move, or remove it, as needed.
            String sql = "SELECT LOP.MALOP, LOP.TENLOP FROM SINHVIEN SV inner join LOP ON(SV.MASV='" + Program.mSV + "' AND SV.MALOP = lOP.MALOP)";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            String mLop = Program.myReader.GetString(0);
            tenLop = Program.myReader.GetString(1);
            Program.myReader.Close();

            try
            {

                this.sP_MonHocSVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_MonHocSVTableAdapter.Fill(this.tNDataSet.SP_MonHocSV, Program.mSV);
                if (sPMonHocSV.Count > 0)
                {
                    cbbMHSV.SelectedIndex = 0;
                    this.sP_LanThiSVTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_LanThiSVTableAdapter.Fill(this.tNDataSet.SP_LanThiSV, Program.mSV, cbbMHSV.SelectedValue.ToString());
                    if (sPLanThiSV.Count > 0)
                    {
                        cbbLThi.SelectedIndex = 0;
                        String sqlNgayThi = "SELECT BANGDIEM.NGAYTHI FROM BANGDIEM WHERE BANGDIEM.MASV = '" + Program.mSV + "' AND BANGDIEM.MAMH = '" + cbbMHSV.SelectedValue.ToString() + "'  AND BANGDIEM.LAN = '" + cbbLThi.SelectedValue.ToString() + "' ";
                        Program.myReader = Program.ExecSqlDataReader(sqlNgayThi);
                        if (Program.myReader == null) return;
                        Program.myReader.Read();
                        String ngay = Program.myReader.GetDateTime(0).ToString();
                        String[] arrNgay = ngay.Split(' ');
                        ngayThi = arrNgay[0];
                        Program.myReader.Close();
                        Program.conn.Close();
                    }
                }
                else
                {
                    Program.myReader.Close();
                    Program.conn.Close();
                    MessageBox.Show("Sinh viên không có môn học đăng ký", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("abc " + ex.Message);
            };


        }

        private void cbbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMHSV.SelectedValue != null)
            {
                try
                {
                    dem++;
                    this.sP_LanThiSVTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_LanThiSVTableAdapter.Fill(this.tNDataSet.SP_LanThiSV, Program.mSV, cbbMHSV.SelectedValue.ToString());
                    cbbLThi.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("loi lay dsmh sv: " + ex);
                }
            }
        }

        private void cbbLThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMHSV.SelectedValue != null && cbbLThi.SelectedValue != null)
            {
                Program.myReader.Close();
                try
                {
                    String sqlNgayThi = "SELECT BANGDIEM.NGAYTHI FROM BANGDIEM WHERE BANGDIEM.MASV = '"
                        + Program.mSV
                        + "' AND BANGDIEM.MAMH = '" + cbbMHSV.SelectedValue.ToString()
                        + "'  AND BANGDIEM.LAN = '" + cbbLThi.SelectedValue.ToString() + "' ";
                    Program.myReader = Program.ExecSqlDataReader(sqlNgayThi);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();

                    String ngay = Program.myReader.GetDateTime(0).ToString();
                    String[] arrNgay = ngay.Split(' ');
                    ngayThi = arrNgay[0];
                    Program.myReader.Close();
                    Program.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("loi lay dsmh sv: " + ex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sPMonHocSV.Count <= 0 || sPLanThiSV.Count <= 0)
            {
                MessageBox.Show("Sinh viên chưa có kết quả thi", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            this.sP_INBAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_INBAITHITableAdapter.Fill(this.tNDataSet.SP_INBAITHI, Program.mSV, cbbMHSV.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
        }

        private void btnInDSBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpKQTHI rpKQT = new rpKQTHI(Program.mSV, cbbMHSV.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
            rpKQT.lbLop.Text = tenLop;
            rpKQT.lbHoTen.Text = Program.mHoten;
            rpKQT.lbMH.Text = cbbMHSV.Text;
            rpKQT.lbNgayThi.Text = ngayThi.ToString();
            rpKQT.lbLan.Text = cbbLThi.Text;
            ReportPrintTool report = new ReportPrintTool(rpKQT);
            report.ShowPreviewDialog();
        }

        private void btnThoatBDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReFresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String sql = "SELECT LOP.MALOP, LOP.TENLOP FROM SINHVIEN SV inner join LOP ON(SV.MASV='" + Program.mSV + "' AND SV.MALOP = lOP.MALOP)";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            String mLop = Program.myReader.GetString(0);
            tenLop = Program.myReader.GetString(1);
            Program.myReader.Close();

            try
            {

                this.sP_MonHocSVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_MonHocSVTableAdapter.Fill(this.tNDataSet.SP_MonHocSV, Program.mSV);
                if (sPMonHocSV.Count > 0)
                {
                    cbbMHSV.SelectedIndex = 0;
                    this.sP_LanThiSVTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_LanThiSVTableAdapter.Fill(this.tNDataSet.SP_LanThiSV, Program.mSV, cbbMHSV.SelectedValue.ToString());
                    if (sPLanThiSV.Count > 0)
                    {
                        cbbLThi.SelectedIndex = 0;
                        String sqlNgayThi = "SELECT BANGDIEM.NGAYTHI FROM BANGDIEM WHERE BANGDIEM.MASV = '" + Program.mSV + "' AND BANGDIEM.MAMH = '" + cbbMHSV.SelectedValue.ToString() + "'  AND BANGDIEM.LAN = '" + cbbLThi.SelectedValue.ToString() + "' ";
                        Program.myReader = Program.ExecSqlDataReader(sqlNgayThi);
                        if (Program.myReader == null) return;
                        Program.myReader.Read();
                        String ngay = Program.myReader.GetDateTime(0).ToString();
                        String[] arrNgay = ngay.Split(' ');
                        ngayThi = arrNgay[0];
                        Program.myReader.Close();
                        Program.conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên không có môn học đăng ký", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("abc " + ex.Message);
            };

        }
    }
}
