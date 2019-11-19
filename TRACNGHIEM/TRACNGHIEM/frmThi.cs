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
        public static Boolean checkThi = false;
        public frmThi()
        {
            InitializeComponent();
        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            edtHoTenSV.Text = Program.mHoten;

            if (Program.mGroup == "SINHVIEN")
            {
                gbThongTinSV.Visible = true;
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
            else
            {
                gbThongTinSV.Visible = false;
            }

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
    }
}
