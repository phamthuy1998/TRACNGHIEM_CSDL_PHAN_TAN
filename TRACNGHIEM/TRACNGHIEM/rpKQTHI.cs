using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TRACNGHIEM
{
    public partial class rpKQTHI : DevExpress.XtraReports.UI.XtraReport
    {
        public rpKQTHI(String maSV, String maMH, short lan)
        {
            InitializeComponent();
            tnDataSet1.EnforceConstraints = false;
            this.sP_INBAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_INBAITHITableAdapter.Fill(this.tnDataSet1.SP_INBAITHI, maSV, maMH, lan);
        }

    }
}
