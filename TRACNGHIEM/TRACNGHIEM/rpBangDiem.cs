using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TRACNGHIEM
{
    public partial class rpBangDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public rpBangDiem(String maLop, String MaMH, short lanThi)
        {
            InitializeComponent();
          
            tnDataSet1.EnforceConstraints = false;
            if (frmBangDiem.isCoSoKhac == true)
            {
                Program.servername1 = frmBangDiem._coso;
                if (Program.KetNoiCosoKhac() == 0) return;
                else
                {
                    this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_XemKetQuaSVTableAdapter.Fill(tnDataSet1.SP_XemKetQuaSV, maLop, MaMH, lanThi);
                }
            }
            else
            {
                this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_XemKetQuaSVTableAdapter.Fill(tnDataSet1.SP_XemKetQuaSV, maLop, MaMH, lanThi);
            }
        }
    }
}
