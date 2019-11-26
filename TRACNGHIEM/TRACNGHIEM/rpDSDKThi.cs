using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TRACNGHIEM
{
    public partial class rpDSDKThi : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDSDKThi(DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            tnDataSet1.EnforceConstraints = false;

            if (frmDSDK.status == true)
            {
                Program.servername1 = frmDSDK._coso;
                if (Program.KetNoiCosoKhac() == 0) return;
                else
                {
                    this.sP_DanhSach_DK_ThiTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_DanhSach_DK_ThiTableAdapter.Fill(tnDataSet1.SP_DanhSach_DK_Thi, fromDate, toDate);
                }
            }
            else
            {
                this.sP_DanhSach_DK_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DanhSach_DK_ThiTableAdapter.Fill(tnDataSet1.SP_DanhSach_DK_Thi, fromDate, toDate);
            }

        }

    }
}
